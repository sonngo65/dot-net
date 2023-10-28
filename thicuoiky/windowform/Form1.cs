using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Net.Configuration;

namespace windowform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void loadCombobox()
        {
            string link = "http://localhost/qlsp/api/danhmuc";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse  response= request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(DanhMuc[]));
            object data = js.ReadObject(response.GetResponseStream());
            DanhMuc[] list = data as DanhMuc[];
            comboBox1.DataSource = list;
            comboBox1.ValueMember= "MaDanhMuc";
            comboBox1.DisplayMember = "TenDanhMuc";
        }
        public void loadDataGrid()
        {
            string link = "http://localhost/qlsp/api/sanpham";
            HttpWebRequest request = WebRequest.CreateHttp(link);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(response.GetResponseStream());
            SanPham[] list = data as SanPham[];
            dataGridView1.DataSource = list;
        }
        public void hienthi()
        {
            loadCombobox();
            loadDataGrid();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}",txtMa.Text,txtTen.Text,txtGia.Text,comboBox1.SelectedValue);
            string link = "http://localhost/qlsp/api/sanpham/" + postString;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "POST";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] byteArr = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = byteArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArr,0, byteArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq)
            {
                loadDataGrid();
                MessageBox.Show("Thêm thành công ");
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string postString = string.Format("?ma={0}&ten={1}&gia={2}&madm={3}",txtMa.Text,txtTen.Text,txtGia.Text,comboBox1.SelectedValue);
            string link = "http://localhost/qlsp/api/sanpham/" + postString;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            request.Method = "PUT";
            request.ContentType = "application/json;charset=UTF-8";
            byte[] dataArr = Encoding.UTF8.GetBytes(postString);
            request.ContentLength = dataArr.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(dataArr,0,dataArr.Length);
            dataStream.Close();
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            bool kq = (bool)data;
            if (kq) {
                MessageBox.Show("Sửa thành công");
                loadDataGrid();
            }
            else
            {
                MessageBox.Show("thất bại");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMa.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtGia.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            comboBox1.SelectedValue = dataGridView1.Rows[i].Cells[3].Value;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            DialogResult re = MessageBox.Show("Bạn có muốn xoá không ", "Thông báo", MessageBoxButtons.YesNo);
            if (re == DialogResult.Yes)
            {
                string masp = row.Cells[0].Value.ToString();
                string postDelete = string.Format("?ma={0}", masp);
                string link = "http://localhost/qlsp/api/sanpham/" + postDelete;
                HttpWebRequest request = WebRequest.CreateHttp(link);
                request.Method = "DELETE";
                request.ContentType = "application/json;charset=UTF-8";
                byte[] dataArr = Encoding.UTF8.GetBytes(postDelete);
                request.ContentLength = dataArr.Length;
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(dataArr, 0, dataArr.Length);
                dataStream.Close();
                DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(bool));
                object data = js.ReadObject(request.GetResponse().GetResponseStream());
                bool kq = (bool)data;
                if (kq)
                {

                    MessageBox.Show("xoá thành công");
                    loadDataGrid();

                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string getString = string.Format("?bd={0}&kt={1}", txtBd.Text, txtKt.Text);
            string link = "http://localhost/qlsp/api/sanpham/"+getString;
            HttpWebRequest request = WebRequest.CreateHttp(link);
            DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(SanPham[]));
            object data = js.ReadObject(request.GetResponse().GetResponseStream());
            SanPham[] list = data as SanPham[];
            dataGridView1.DataSource = list;
        }
    }
}
