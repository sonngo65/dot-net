using dialogTest.Models;
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

namespace dialogTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        QlluongContext db = new QlluongContext();
        public MainWindow()
        {

            InitializeComponent();

          
        }

        public void hienThi() {

            var nv = from a in db.Donvis
                     select a;



            dataGrid.ItemsSource = nv.ToList();
        }


        

        private void windowLoad(object sender, RoutedEventArgs e)
        {
            hienThi();
        }

        private void btn_add(object sender, RoutedEventArgs e)
        {
            var check = db.Donvis.SingleOrDefault(t => t.Madv == txtMa.Text);
            if (check != null)
            {   
                MessageBox.Show("Da co");
            }else if (txtMa.Text == "" || txtMa.Text=="" || txtSo.Text=="")
            {

                MessageBox.Show("Hãy nhập đầy đủ");
            }
            else {
                Donvi a = new Donvi() { Madv = txtMa.Text, Tendv = txtTen.Text, Dienthoai = txtSo.Text };
                db.Donvis.Add(a);
                db.SaveChanges();
               
                hienThi();
            }
        }

        private void btn_change(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = (from a in db.Donvis where a.Madv.Equals(txtMa.Text) select a).Single() as Donvi;

              
                query.Tendv = txtTen.Text;
                query.Dienthoai = txtSo.Text;
                MessageBox.Show(query.Madv + " " + query.Tendv + " " + query.Dienthoai);
                db.SaveChanges();
                hienThi();
            }
            catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
        }

        private void btn_search(object sender, RoutedEventArgs e)
        {
            Window1 b = new Window1();
            var query = from dv in db.Donvis where dv.Madv=="dv01" select new {dv.Madv,dv.Tendv,dv.Dienthoai};
            b.dataGrid2.ItemsSource= query.ToList();
            b.ShowDialog();
        }

        private void select(object sender, SelectedCellsChangedEventArgs e)
        {


            Donvi a = dataGrid.SelectedItem as Donvi;
            txtMa.Text = a.Madv;
            txtTen.Text = a.Tendv;
            txtSo.Text = a.Dienthoai;



        }
    }
}
