using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
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
using thiKTHP.Models;

namespace thiKTHP
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
        QuanLySanPhamContext db = new QuanLySanPhamContext();
        public void hienthidata()
        {
            var q = from sp in db.SanPhams orderby sp.DonGia select new { sp.MaSp, sp.TenSp, sp.MaLoai, sp.SoLuong, sp.DonGia, thanhtien = sp.SoLuong * sp.DonGia };
            datagrid.ItemsSource = q.ToList();
        }
        public void hienthicmb()
        {
            var q = from l in db.LoaiSanPhams select l.TenLoai;
            cmb.ItemsSource = q.ToList();
            cmb.SelectedIndex = 0;

        }

        private void window_load(object sender, RoutedEventArgs e)
        {
            hienthicmb();
            hienthidata();
        }
        public bool check()
        {
            string tb = "";
            if(txtMa.Text == "" || txtTen.Text == "" || txtMa.Text=="" || txtSo.Text == "")
            {
                tb += "\n không được để trống ";
            }
            if (!Regex.IsMatch(txtSo.Text, @"^\d+$"))
            {
                tb += "\n Số lượng phải là số ";
            }
            else
            {
                int so = int.Parse(txtSo.Text);
                if (so < 0)
                {
                    tb += "\n Số lượng phải lớn hơn 0";
                }
            }
            if (!Regex.IsMatch(txtDon.Text, @"^\d+$"))
            {
                tb += "\nĐơn giá phải là số ";
            }
            else
            {
                double don = double.Parse(txtDon.Text);
                if (don < 0)
                {
                    tb += "\nĐơn giá phải lớn hơn 0";
                }
            }
            if (tb != "")
            {
                MessageBox.Show(tb,"thong bao",MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void them_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                var q = db.SanPhams.SingleOrDefault(t => t.MaSp == int.Parse(txtMa.Text));
                if (q == null)
                {
                    if (check())
                    {
                        SanPham a = new SanPham();
                        a.MaSp = int.Parse(txtMa.Text);
                        a.TenSp = txtTen.Text;
                        var b = db.LoaiSanPhams.SingleOrDefault(t => t.TenLoai.Equals(cmb.SelectedItem));
                        a.MaLoai = b.MaLoai;
                        a.DonGia = double.Parse(txtDon.Text);
                        a.SoLuong = int.Parse(txtSo.Text);
                        db.SanPhams.Add(a);
                        db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("Sản phẩm đã có rồi ");
                }
                
            }catch(Exception x)
            {
                MessageBox.Show("có lỗi " + x.Message);
            }
            hienthidata();
        }

        private void sua_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                var q = db.SanPhams.SingleOrDefault(t => t.MaSp == int.Parse(txtMa.Text));
                if (q != null)
                {
                    if (check())
                    {
                       
                       
                        q.TenSp = txtTen.Text;
                        var b = db.LoaiSanPhams.SingleOrDefault(t => t.TenLoai.Equals(cmb.SelectedItem));
                        q.MaLoai = b.MaLoai;
                        q.DonGia = double.Parse(txtDon.Text);
                        q.SoLuong = int.Parse(txtSo.Text);
                       
                        db.SaveChanges();
                    }
                }
                else
                {
                    MessageBox.Show("không tìm thấy sản phẩm để sửa ");
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("có lỗi " + x.Message);
            }
            hienthidata();
        }

        private void xoa_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                var q = db.SanPhams.SingleOrDefault(t => t.MaSp == int.Parse(txtMa.Text));
                if (q != null)
                {
                    MessageBoxResult result = MessageBox.Show("bạn có muôn xoá không ", "thong bao", MessageBoxButton.YesNo);
                    if (result==MessageBoxResult.Yes)
                    {
                        db.SanPhams.Remove(q);
                        db.SaveChanges();

                        hienthidata();
                    }
                }
                else
                {
                    MessageBox.Show("không tìm thấy sản phẩm để xoá");
                }

            }
            catch (Exception x)
            {
                MessageBox.Show("có lỗi " + x.Message);
            }
          
        }

        private void tim_btn(object sender, RoutedEventArgs e)
        {
            var q = from sp in db.SanPhams join l in db.LoaiSanPhams on sp.MaLoai equals l.MaLoai select new { sp.MaSp, sp.TenSp, l.TenLoai, sp.DonGia, thanhtien = sp.DonGia * sp.SoLuong };
            Window1 w = new Window1();
            w.datagrid.ItemsSource = q.ToList();
            w.Show();
        }

        private void select_row(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                Type t = datagrid.SelectedItem.GetType();
                PropertyInfo[] p = t.GetProperties();
                txtMa.Text = p[0].GetValue(datagrid.SelectedValue).ToString();
                txtTen.Text = p[1].GetValue(datagrid.SelectedValue).ToString();
                var q = db.LoaiSanPhams.SingleOrDefault(t => t.MaLoai.Equals(p[2].GetValue(datagrid.SelectedValue).ToString()));
                cmb.SelectedValue = q.TenLoai;
                txtDon.Text = p[3].GetValue(datagrid.SelectedValue).ToString();
                txtSo.Text = p[4].GetValue(datagrid.SelectedValue).ToString();

            }
            catch(Exception x)
            {
                MessageBox.Show(""+ x);
            }
        }
    }
}
