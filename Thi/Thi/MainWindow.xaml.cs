using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.RightsManagement;
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
using Thi.Models;
namespace Thi
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
        QlSanPham2Context db = new QlSanPham2Context();
       public void hienthi()
        {
            hienthiData();
            hienthiCom();
        }
        public void hienthiData()
        {
            var query = from sp in db.SanPhams join nh in db.NhomHangs on sp.Manhomhang equals nh.Manhomhang orderby sp.Soluongban descending select new { sp.Masp, sp.Tensanpham, sp.Dongia, sp.Soluongban, nh.Tennhomhang,tienban = sp.Dongia * sp.Soluongban};
            datagrid.ItemsSource = query.ToList();

        }
        public void hienthiCom()
        {
            var query = from nh in db.NhomHangs select nh.Tennhomhang;
            cmb.ItemsSource = query.ToList();
            cmb.SelectedIndex = 0;
        }

        private void window_load(object sender, RoutedEventArgs e)
        {
            hienthi();
        }
        public bool check()
        {
            string tb = "";
            if(txtMa.Text=="" || txtTen.Text=="" || txtDon.Text== "" || txtSo.Text=="")
            {
                tb += "\nkhông được để trống ";
            }
            if (!Regex.IsMatch(txtSo.Text, @"\d+"))
            {
                tb += "\nSố lượng nhập phải là số";

            }
            else
            {
                int so = int.Parse(txtSo.Text);
                if (so < 0)
                {
                    tb += "\nSố lượng phải lớn hơn không";
                }
            }
            if (!Regex.IsMatch(txtDon.Text, @"\d+"))
            {
                tb += "\nđơn giá nhập phải là số ";
            }
            else
            {
                float don = float.Parse(txtDon.Text);
                if (don < 0)
                {
                    tb += "\nĐơn giá phải lớn hơn 0";
                }
            }
            if (tb != "")
            {
                MessageBox.Show(tb, "Thong bao", MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btn_them(object sender, RoutedEventArgs e)
        {
            SanPham a = new SanPham();
            var query1 = db.SanPhams.SingleOrDefault(t => t.Masp == int.Parse(txtMa.Text));
            var query = db.NhomHangs.SingleOrDefault(t => t.Tennhomhang.Equals(cmb.SelectedItem));
            NhomHang b = query as NhomHang;
            if (query1 == null) {

                try
                {
                    if (check())
                    {
                        a.Manhomhang = b.Manhomhang;
                        a.Tensanpham = txtTen.Text;
                        a.Dongia = float.Parse(txtDon.Text);
                        a.Soluongban = int.Parse(txtSo.Text);
                        a.Masp = int.Parse(txtMa.Text);
                        db.SanPhams.Add(a);
                        db.SaveChanges();
                    }
                }
                catch (FormatException x)
                {
                    MessageBox.Show("xảy ra lỗi : " + x);
                } 
            
                
              
            }
            else
            {
                MessageBox.Show("Sản phẩm đã tồn tại");
            }
            hienthiData();
        }

        private void select_change(object sender, SelectedCellsChangedEventArgs e)
        {
            try
            {
                Type t = datagrid.SelectedItem.GetType();
                PropertyInfo[] p = t.GetProperties();
                txtMa.Text = p[0].GetValue(datagrid.SelectedValue).ToString();
                txtTen.Text = p[1].GetValue(datagrid.SelectedValue).ToString();
                txtDon.Text = p[2].GetValue(datagrid.SelectedValue).ToString();
                txtSo.Text = p[3].GetValue(datagrid.SelectedValue).ToString();

                
                cmb.SelectedValue = p[4].GetValue(datagrid.SelectedValue).ToString();
            }catch(Exception x)
            {
                MessageBox.Show("Có lỗi : " + x);
            }
        }

        private void xoa_btn(object sender, RoutedEventArgs e)
        {
            var query = db.SanPhams.SingleOrDefault(t => t.Masp == int.Parse(txtMa.Text));
            if(query != null)
            {
                MessageBoxResult result = MessageBox.Show("Bạn có chắc xoá ", "Thông báo", MessageBoxButton.YesNo);
                if (result.Equals(MessageBoxButton.OK)) 
                {
                    db.SanPhams.Remove(query);
                    db.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy sản phẩm để xoá");
            }
            hienthiData();
        }

        private void sua_btn(object sender, RoutedEventArgs e)
        {
            try
            {
                var query = db.SanPhams.SingleOrDefault(t => t.Masp == int.Parse(txtMa.Text));
           
            if(query != null)
            {
                
                    if (check())
                    {
                        query.Tensanpham = txtTen.Text;
                        query.Dongia = float.Parse(txtDon.Text);
                        query.Soluongban = int.Parse(txtSo.Text);
                        var query2 = db.NhomHangs.SingleOrDefault(t => t.Tennhomhang.Equals(cmb.SelectedItem));
                        query.Manhomhang = query2.Manhomhang;
                        db.SaveChanges();
                    }
                

            }
            else
            {
                MessageBox.Show("không tìm thấy sản phẩm cần sửa ");
            }
            }
            catch (Exception x)
            {
                MessageBox.Show("Có lỗi khi thêm " + x.ToString());

            }
        }

        private void tim_btn(object sender, RoutedEventArgs e)
        {
            var query = from sp in db.SanPhams join nh in db.NhomHangs on sp.Manhomhang equals nh.Manhomhang where nh.Manhomhang == 1 select new { sp.Masp, sp.Tensanpham, sp.Dongia, sp.Soluongban, nh.Tennhomhang, tienban = sp.Dongia * sp.Soluongban };
            timWindow tim = new timWindow();
            tim.datagrid.ItemsSource = query.ToList();
            tim.Show();

        }
    }
   
}
