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
    public partial class Form4 : Form
    {
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Mapel Kelas 11\KK3\Database\Mydatabase1.accdb");
        public Form4()
        {
            InitializeComponent();
        }

        private void txt_edit_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Update DataKariawan set No_Telp='" + txt_notelp.Text + "', Alamat='" + txt_alamat.Text + "', Status='" + txt_status.Text + "' where Nama='" + txt_nama.Text + "'";
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil di update");
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

        private void btn_delete_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Delete from DataKariawan where ID=" + txt_id.Text;
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("data terhapus");
        }

        private void btn_daftarkariawan_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void txt_save_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Insert into DataKariawan (Nama, No_Telp, Alamat, Status) values ('" + txt_nama.Text + "', '" + txt_notelp.Text + "', '" + txt_alamat.Text + "', '" + txt_status.Text + "')";
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Tersimpan");
        }

        private void btn_daftarharga_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
