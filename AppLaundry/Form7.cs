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
    public partial class Form7 : Form
    {
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Mapel Kelas 11\KK3\Database\Mydatabase1.accdb");

        public Form7()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Insert into DataHarga  (Nama_Layanan, Durasi, Harga, Min_Order, Satuan) values ('" + txt_layanan.Text + "', '" + txt_durasi.Text + "', '" + txt_harga.Text + "', '" + txt_minorder.Text + "', '" + txt_satuan.Text + "')";
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Tersimpan");
            ShowData();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Update DataHarga set Durasi='" + txt_durasi.Text + "', Harga='" + txt_harga.Text + "', Min_Order='" + txt_minorder.Text + "', Satuan='" + txt_satuan.Text + "' where Nama_Layanan='" + txt_layanan.Text + "'";
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil di update");
            ShowData();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Delete from DataHarga where ID=" + txt_id.Text;
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("data terhapus");
            ShowData();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            ShowData();
        }

        void ShowData()
        {
            koneksi.Open();
            string query = "select * from DataHarga";
            OleDbDataAdapter da = new OleDbDataAdapter(query, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "select * from DataHarga where Nama_Layanan='" + txt_search.Text + "'";
            OleDbDataAdapter da = new OleDbDataAdapter(perintah, koneksi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            koneksi.Close();
            
        }

        private void btn_transaksi_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void btn_daftarcustomer_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void btn_daftarkariawan_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ShowData();
        }
    }
}
