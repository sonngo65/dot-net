using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace bai9
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public class MonHoc
        {
            public string name { get; set; }
            public override string ToString()
            {
                return name;
            }
        }
        List<MonHoc> item = new List<MonHoc>();
        List<MonHoc> item2 = new List<MonHoc>();
        public MainWindow()
        {
            InitializeComponent();
            item.Add(new MonHoc() { name = "Lập trình php" });
            item.Add(new MonHoc() { name = "Công nghệ thực tế ảo" });
            item.Add(new MonHoc() { name = "Đảm Bảo chất lượng phần mềm" });
            item.Add(new MonHoc() { name = "Giải thuật di chuyền và ứng dụng" });
            item.Add(new MonHoc() { name = "Hệ chuyên gia" });
            item.Add(new MonHoc() { name = "Một số phương pháp tính toán phần mềm" });
            item.Add(new MonHoc() { name = "Phân tích thiết kế hệ thống " });
            item.Add(new MonHoc() { name = "Thiết kế cơ sở dữ liệu" });
            foreach(MonHoc a in item)
            {
                listbox1.Items.Add(a);
            }
            
        }

        
        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            MonHoc a = (listbox1.SelectedItem as MonHoc);

            listbox2.Items.Add(a);
            
            listbox1.Items.Remove(a);
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            foreach(MonHoc  a in item)
            {
                listbox2.Items.Add(a);
            }
           
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {

        }

         

        private void addItem(object sender, SelectionChangedEventArgs e)
        {

          
        }
    }
}
