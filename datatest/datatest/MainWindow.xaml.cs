using datatest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace datatest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public QlluongContext db = new QlluongContext();
        public MainWindow()
        {
           
            InitializeComponent();
            var nhanvien = from nv in db.Nhanviens select new{nv.Manv, nv.Hoten,nv.Gioitinh,nv.Ngaysinh,nv.Hsluong,nv.Macv,nv.Madv };
            dataGrid.ItemsSource = nhanvien.ToList();
            
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
         
        }
    }
}
