using bai8.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

namespace bai8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {

            InitializeComponent();
            
        }
        QlbanhangContext db = new QlbanhangContext();
        private void load_window(object sender, RoutedEventArgs e)
        {
            show();
            showcom();
        }
        private void show()
        {

            var query = from a in db.Sanphams select new { a.Masp, a.Tensp, a.Maloai, a.Dongia, a.Soluong, Thanhtien = a.Soluong * a.Dongia };
            datagrid.ItemsSource = query.ToList();
           
        }
        private void showcom()
        {
            var query2 = db.Loaisanphams.Select(t => t.Tenloai);
            cmbox.ItemsSource = query2.ToList();

            cmbox.SelectedIndex = 0;

        }
        private void select_row(object sender, SelectedCellsChangedEventArgs e)
        {
            Type a = datagrid.SelectedItem.GetType();
            PropertyInfo[] p = a.GetProperties();
            txtMa.Text = p[0].GetValue(datagrid.SelectedValue).ToString();
            txtTen.Text = p[1].GetValue(datagrid.SelectedValue).ToString();
            cmbox.SelectedValue = db.Loaisanphams.Where(t => p[2].GetValue(datagrid.SelectedValue).Equals(t.Maloai)).Select(t => t.Tenloai).Single();
            txtSo.Text = p[3].GetValue(datagrid.SelectedValue).ToString();
            txtDon.Text = p[4].GetValue(datagrid.SelectedValue).ToString();
        }

        private void Them(object sender, RoutedEventArgs e)
        {
            try
            {
                Sanpham a = new Sanpham();
                a.Masp = txtMa.Text;
                a.Tensp = txtTen.Text;
                Loaisanpham b = db.Loaisanphams.SingleOrDefault(t => t.Tenloai.Equals(cmbox.SelectedItem)) as Loaisanpham;
                a.Maloai = b.Maloai;
                a.Soluong = int.Parse(txtSo.Text);
                a.Dongia = int.Parse(txtDon.Text);
                db.Sanphams.Add(a);
                db.SaveChanges();
                show();
            }catch(Exception x)
            {
                MessageBox.Show(x.ToString());
            }
                }

        private void tim(object sender, RoutedEventArgs e)
        {
            var query = db.Sanphams.Where(t => t.Tensp.Equals(txtTen.Text)).Select(t => new { t.Masp, t.Tensp, t.Soluong, t.Maloai, t.Dongia, Thanhtien = t.Soluong * t.Dongia });
            datagrid.ItemsSource = query.ToList();
        }

        private void sua(object sender, RoutedEventArgs e)
        {
            var query = db.Sanphams.SingleOrDefault(t => t.Masp.Equals(txtMa.Text));
            if (query != null)
            {
                if (check())
                {
                    try
                    {
                        query.Tensp = txtTen.Text;
                        query.Soluong = int.Parse(txtSo.Text);
                        query.Dongia = Decimal.Parse(txtDon.Text);
                        Loaisanpham a = db.Loaisanphams.SingleOrDefault(t => t.Tenloai.Equals(cmbox.SelectedItem)) as Loaisanpham;
                        query.Maloai = a.Maloai;
                        db.SaveChanges();
                        show();
                    }
                    catch(Exception x)
                    {
                        MessageBox.Show(x.ToString());
                    }
                }
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại");

            }
        }
        private bool check()
        {
            if (txtMa.Text.Trim().Equals("") || txtTen.Text.Trim().Equals("") || txtSo.Text.Trim().Equals("") || txtDon.Text.Trim().Equals(""))
            {
                MessageBox.Show("không được để trống ");
                return false;
                
            }
            else
            {
              return true;
                  
            }
        }
    }

}
