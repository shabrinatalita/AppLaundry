using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AppLaundry
{
    public partial class Form3 : Form
    {
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Mapel Kelas 11\KK3\Database\Mydatabase1.accdb");

        public Form3()
        {
            InitializeComponent();
        }     

        private void btn_edit_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }       

        private void btn_transaksi_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            koneksi.Close();
            MessageBox.Show("Cukup isikan ID yang ingin dihapus!");
            koneksi.Dispose();
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btn_daftarcustomer_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_daftarkariawan_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            koneksi.Open();
            string query = "select * from DataCustomer";
            OleDbDataAdapter da = new OleDbDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "select * from DataCustomer where Nama='" + txt_search.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(perintah, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
            
        }

        private void btn_daftarharga_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
