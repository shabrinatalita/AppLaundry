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
    public partial class Form2 : Form
    {
        OleDbConnection koneksi = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Mapel Kelas 11\KK3\Database\Mydatabase1.accdb");
        
        public Form2()
        {
            InitializeComponent();
        }

        private void txt_save_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Insert into DataCustomer (Nama, Tanggal_Transaksi, Item, Total_Biaya, No_Telp, Alamat, Status) values ('" + txt_nama.Text + "', '" + txt_tgltransaksi.Text + "', '" + txt_item.Text + "', '" + txt_biaya.Text + "', '" + txt_notelp.Text + "', '" + txt_alamat.Text + "', '" + txt_status.Text + "')";
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data Tersimpan");
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Delete from DataCustomer where ID=" + txt_id.Text;
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("data terhapus");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_daftarcustomer_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_edit_Click(object sender, EventArgs e)
        {
            koneksi.Open();
            string perintah = "Update DataCustomer set Tanggal_Transaksi='" + txt_tgltransaksi.Text + "', Item='" + txt_item.Text + "', Total_Biaya='" + txt_biaya.Text + "', No_Telp='" + txt_notelp.Text + "', Alamat='" + txt_alamat.Text + "', Status='" + txt_status.Text + "' where Nama='" + txt_nama.Text + "'";
            OleDbCommand cmd = new OleDbCommand(perintah, koneksi);
            cmd.ExecuteNonQuery();
            koneksi.Close();
            MessageBox.Show("Data berhasil di update");
        }

        private void btn_daftarkariawan_Click(object sender, EventArgs e)
        {
            koneksi.Close();
            koneksi.Dispose();
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
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
