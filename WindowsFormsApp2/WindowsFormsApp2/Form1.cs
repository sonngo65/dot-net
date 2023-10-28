using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        XmlDocument doc = new XmlDocument();
        string tentep = @"F:\dotNet\WindowsFormsApp2\WindowsFormsApp2\XMLFile1.xml";
        public void hienthi()
        {
            dataGridView1.Rows.Clear();
            doc.Load(tentep);
            XmlNodeList ds = doc.SelectNodes("/ds/nhanvien");
            dataGridView1.Rows.Add();
            int s = 0;
            foreach(XmlNode node in ds)
            {
                dataGridView1.Rows[s].Cells[0].Value = node.SelectSingleNode("@manv").InnerText.ToString();
                dataGridView1.Rows[s].Cells[1].Value = node.SelectSingleNode("hoten").InnerText.ToString();

                dataGridView1.Rows[s].Cells[2].Value = node.SelectSingleNode("gioitinh").InnerText.ToString();

                dataGridView1.Rows[s].Cells[3].Value = node.SelectSingleNode("trinhdo").InnerText.ToString();

                dataGridView1.Rows[s].Cells[4].Value = node.SelectSingleNode("diachi").InnerText.ToString();
                s++;
                dataGridView1.Rows.Add();
            }
            List<string> trinhdo = new List<string>();
            trinhdo.Add("Đại học");
            trinhdo.Add("Tiểu học");
            trinhdo.Add("Trung học");
            comboBox1.DataSource = trinhdo;
            comboBox1.SelectedIndex= 0;
            radioButton1.Checked = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            hienthi();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            XmlNode nhanvien = doc.CreateElement("nhanvien");
            XmlAttribute manv = doc.CreateAttribute("manv");
            manv.InnerText = txtma.Text;
            nhanvien.Attributes.Append(manv);
            XmlNode hoten = doc.CreateElement("hoten");
            hoten.InnerText = txthoten.Text;
            nhanvien.AppendChild(hoten);
            XmlNode gioitinh = doc.CreateElement("gioitinh");
            if (radioButton1.Checked)
            {
                gioitinh.InnerText = radioButton1.Text.ToString();

            }
            else
            {
                gioitinh.InnerText = radioButton2.Text.ToString();
            }
            nhanvien.AppendChild(gioitinh);
            XmlNode trinhdo = doc.CreateElement("trinhdo");
            trinhdo.InnerText = comboBox1.SelectedItem.ToString();
            nhanvien.AppendChild(trinhdo);
            goc.AppendChild(nhanvien);
            XmlNode diachi = doc.CreateElement("diachi");
            diachi.InnerText = txtdiachi.Text;
            nhanvien.AppendChild (diachi);
            doc.Save(tentep);
            hienthi();
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            XmlNode nvcu = doc.SelectSingleNode("/ds/nhanvien[@manv='" + txtma.Text + "']");
            XmlNode nhanvien = doc.CreateElement("nhanvien");
            XmlAttribute manv = doc.CreateAttribute("manv");
            manv.InnerText = txtma.Text;
            nhanvien.Attributes.Append(manv);
            XmlNode hoten = doc.CreateElement("hoten");
            hoten.InnerText = txthoten.Text;
            nhanvien.AppendChild(hoten);
            XmlNode gioitinh = doc.CreateElement("gioitinh");
            if (radioButton1.Checked)
            {
                gioitinh.InnerText = radioButton1.Text.ToString();

            }
            else
            {
                gioitinh.InnerText = radioButton2.Text.ToString();
            }
            nhanvien.AppendChild(gioitinh);
            XmlNode trinhdo = doc.CreateElement("trinhdo");
            trinhdo.InnerText = comboBox1.SelectedItem.ToString();
            nhanvien.AppendChild(trinhdo);
            goc.AppendChild(nhanvien);
            XmlNode diachi = doc.CreateElement("diachi");
            diachi.InnerText = txtdiachi.Text;
            nhanvien.ReplaceChild(nvcu,nhanvien);
            doc.Save(tentep);
            hienthi();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            txtma.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            txthoten.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            if (dataGridView1.Rows[index].Cells[2].Value.ToString().Equals(radioButton1.Text))
            {
                radioButton1.Checked = true;

            }
            else
            {
                radioButton2.Checked = true;
            }
            comboBox1.SelectedItem = dataGridView1.Rows[index].Cells[3].Value;
            txtdiachi.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();

        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            doc.Load(tentep);
            XmlElement goc = doc.DocumentElement;
            XmlNode nv = doc.SelectSingleNode("/ds/nhanvien[@manv='" + txtma.Text + "']");
            goc.RemoveChild(nv);
            doc.Save(tentep);
            hienthi();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            doc.Load(tentep);
            XmlNodeList ds = doc.SelectNodes("/ds/nhanvien[hoten='" + txthoten.Text + "']");
            dataGridView1.Rows.Add();
            int s = 0;
            foreach (XmlNode node in ds)
            {
                dataGridView1.Rows[s].Cells[0].Value = node.SelectSingleNode("@manv").InnerText.ToString();
                dataGridView1.Rows[s].Cells[1].Value = node.SelectSingleNode("hoten").InnerText.ToString();

                dataGridView1.Rows[s].Cells[2].Value = node.SelectSingleNode("gioitinh").InnerText.ToString();

                dataGridView1.Rows[s].Cells[3].Value = node.SelectSingleNode("trinhdo").InnerText.ToString();

                dataGridView1.Rows[s].Cells[4].Value = node.SelectSingleNode("diachi").InnerText.ToString();
                s++;
                dataGridView1.Rows.Add();
            }
            List<string> trinhdo = new List<string>();
            trinhdo.Add("Đại học");
            trinhdo.Add("Tiểu học");
            trinhdo.Add("Trung học");
            comboBox1.DataSource = trinhdo;
            comboBox1.SelectedIndex = 0;
            radioButton1.Checked = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
