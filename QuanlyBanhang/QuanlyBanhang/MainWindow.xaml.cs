using QuanlyBanhang.Models;
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

namespace QuanlyBanhang
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        QlSanPhamContext db = new QlSanPhamContext();
        public void hienthi() {
            var query = from sp in db.Sanphams select sp;
            var query2 = from nh in db.Nhomhangs select nh.Manhomhang;
            list.ItemsSource = query.ToList();
            cmbox.ItemsSource = query2.ToList();
            cmbox.SelectedIndex = 0;
        }

        private void Winload(object sender, RoutedEventArgs e)
        {
            hienthi();
        }

        private void btn_add(object sender, RoutedEventArgs e)
        {

        }

        private void btn_search(object sender, RoutedEventArgs e)
        {
            var query = db.Sanphams.SingleOrDefault(t => t.Masp == int.Parse(txtMa.Text));
            if (query != null)
            {
                MessageBox.Show("Ma sp da co");
            }
            else if (int.Parse(txtSo1.Text) < 1)
            {
                MessageBox.Show("So luong ban < 1");
            }
            
            else{
                try
                {


                    Sanpham a = new Sanpham();
                    a.Masp = int.Parse(txtMa.Text);
                    a.Tensanpham = txtTen.Text;
                    a.Soluongban = int.Parse(txtSo1.Text);
                    a.Dongia = double.Parse(txtDon.Text);
                    a.Tienban = double.Parse(txtTien.Text);
                    a.Manhomhang = (int)cmbox.SelectedItem;
                    db.Sanphams.Add(a);
                    db.SaveChanges();
                    hienthi();
                } catch (FormatException x)
                {
                    MessageBox.Show("Nhập sai ");
                }
            }
        }

        private void choseCell(object sender, SelectedCellsChangedEventArgs e)
        {
            Sanpham sp = list.SelectedItem as Sanpham;
            txtMa.Text = ""+sp.Masp;
            txtTen.Text = "" + sp.Tensanpham;
            txtSo1.Text = "" + sp.Soluongban;
            txtDon.Text = "" + sp.Dongia;
            txtTien.Text = "" + sp.Tienban;
            cmbox.SelectedItem = sp.Manhomhang;
        }
    
    }
   
}
