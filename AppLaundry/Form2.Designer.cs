namespace AppLaundry
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.txt_item = new System.Windows.Forms.TextBox();
            this.txt_biaya = new System.Windows.Forms.TextBox();
            this.txt_notelp = new System.Windows.Forms.TextBox();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.txt_save = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_daftarharga = new System.Windows.Forms.Button();
            this.btn_daftarcustomer = new System.Windows.Forms.Button();
            this.btn_daftarkariawan = new System.Windows.Forms.Button();
            this.btn_transaksi = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_edit = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_status = new System.Windows.Forms.ComboBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_tgltransaksi = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(133, 20);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(194, 20);
            this.txt_nama.TabIndex = 0;
            // 
            // txt_item
            // 
            this.txt_item.Location = new System.Drawing.Point(133, 72);
            this.txt_item.Name = "txt_item";
            this.txt_item.Size = new System.Drawing.Size(194, 20);
            this.txt_item.TabIndex = 2;
            // 
            // txt_biaya
            // 
            this.txt_biaya.Location = new System.Drawing.Point(133, 98);
            this.txt_biaya.Name = "txt_biaya";
            this.txt_biaya.Size = new System.Drawing.Size(194, 20);
            this.txt_biaya.TabIndex = 3;
            // 
            // txt_notelp
            // 
            this.txt_notelp.Location = new System.Drawing.Point(444, 20);
            this.txt_notelp.Name = "txt_notelp";
            this.txt_notelp.Size = new System.Drawing.Size(201, 20);
            this.txt_notelp.TabIndex = 6;
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(444, 46);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(201, 20);
            this.txt_alamat.TabIndex = 7;
            // 
            // txt_save
            // 
            this.txt_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_save.Location = new System.Drawing.Point(360, 189);
            this.txt_save.Name = "txt_save";
            this.txt_save.Size = new System.Drawing.Size(99, 33);
            this.txt_save.TabIndex = 8;
            this.txt_save.Text = "Save";
            this.txt_save.UseVisualStyleBackColor = false;
            this.txt_save.Click += new System.EventHandler(this.txt_save_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(561, 189);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(84, 33);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_daftarharga);
            this.panel1.Controls.Add(this.btn_daftarcustomer);
            this.panel1.Controls.Add(this.btn_daftarkariawan);
            this.panel1.Controls.Add(this.btn_transaksi);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 109);
            this.panel1.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(12, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(425, 43);
            this.label9.TabIndex = 35;
            this.label9.Text = "Selamat Datang di Lulu n Wash";
            // 
            // btn_daftarharga
            // 
            this.btn_daftarharga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_daftarharga.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_daftarharga.Location = new System.Drawing.Point(524, 63);
            this.btn_daftarharga.Name = "btn_daftarharga";
            this.btn_daftarharga.Size = new System.Drawing.Size(152, 35);
            this.btn_daftarharga.TabIndex = 3;
            this.btn_daftarharga.Text = "Daftar Harga";
            this.btn_daftarharga.UseVisualStyleBackColor = false;
            this.btn_daftarharga.Click += new System.EventHandler(this.btn_daftarharga_Click);
            // 
            // btn_daftarcustomer
            // 
            this.btn_daftarcustomer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_daftarcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_daftarcustomer.Location = new System.Drawing.Point(180, 63);
            this.btn_daftarcustomer.Name = "btn_daftarcustomer";
            this.btn_daftarcustomer.Size = new System.Drawing.Size(159, 35);
            this.btn_daftarcustomer.TabIndex = 2;
            this.btn_daftarcustomer.Text = "Daftar Customer";
            this.btn_daftarcustomer.UseVisualStyleBackColor = false;
            this.btn_daftarcustomer.Click += new System.EventHandler(this.btn_daftarcustomer_Click);
            // 
            // btn_daftarkariawan
            // 
            this.btn_daftarkariawan.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_daftarkariawan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_daftarkariawan.Location = new System.Drawing.Point(350, 63);
            this.btn_daftarkariawan.Name = "btn_daftarkariawan";
            this.btn_daftarkariawan.Size = new System.Drawing.Size(162, 35);
            this.btn_daftarkariawan.TabIndex = 1;
            this.btn_daftarkariawan.Text = "Daftar Kariawan";
            this.btn_daftarkariawan.UseVisualStyleBackColor = false;
            this.btn_daftarkariawan.Click += new System.EventHandler(this.btn_daftarkariawan_Click);
            // 
            // btn_transaksi
            // 
            this.btn_transaksi.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_transaksi.Location = new System.Drawing.Point(12, 63);
            this.btn_transaksi.Name = "btn_transaksi";
            this.btn_transaksi.Size = new System.Drawing.Size(159, 35);
            this.btn_transaksi.TabIndex = 0;
            this.btn_transaksi.Text = "Transaksi";
            this.btn_transaksi.UseVisualStyleBackColor = false;
            this.btn_transaksi.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txt_edit);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_status);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.txt_tgltransaksi);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.txt_save);
            this.panel2.Controls.Add(this.txt_alamat);
            this.panel2.Controls.Add(this.txt_notelp);
            this.panel2.Controls.Add(this.txt_biaya);
            this.panel2.Controls.Add(this.txt_item);
            this.panel2.Controls.Add(this.txt_nama);
            this.panel2.Location = new System.Drawing.Point(12, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 240);
            this.panel2.TabIndex = 11;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txt_edit
            // 
            this.txt_edit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_edit.Location = new System.Drawing.Point(465, 189);
            this.txt_edit.Name = "txt_edit";
            this.txt_edit.Size = new System.Drawing.Size(90, 33);
            this.txt_edit.TabIndex = 12;
            this.txt_edit.Text = "Edit";
            this.txt_edit.UseVisualStyleBackColor = false;
            this.txt_edit.Click += new System.EventHandler(this.txt_edit_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(376, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 39;
            this.label6.Text = "ID";
            // 
            // txt_status
            // 
            this.txt_status.FormattingEnabled = true;
            this.txt_status.Items.AddRange(new object[] {
            "Dibayar",
            "Belum Dibayar"});
            this.txt_status.Location = new System.Drawing.Point(133, 127);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(194, 21);
            this.txt_status.TabIndex = 19;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(444, 72);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(201, 20);
            this.txt_id.TabIndex = 38;
            // 
            // txt_tgltransaksi
            // 
            this.txt_tgltransaksi.Location = new System.Drawing.Point(133, 46);
            this.txt_tgltransaksi.Name = "txt_tgltransaksi";
            this.txt_tgltransaksi.Size = new System.Drawing.Size(194, 20);
            this.txt_tgltransaksi.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(376, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "No Telp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Total Biaya";
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Item";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tanggal Transaksi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nama";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(688, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Transaksi";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.TextBox txt_item;
        private System.Windows.Forms.TextBox txt_biaya;
        private System.Windows.Forms.TextBox txt_notelp;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.Button txt_save;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_daftarharga;
        private System.Windows.Forms.Button btn_daftarcustomer;
        private System.Windows.Forms.Button btn_daftarkariawan;
        private System.Windows.Forms.Button btn_transaksi;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker txt_tgltransaksi;
        private System.Windows.Forms.ComboBox txt_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button txt_edit;
        private System.Windows.Forms.Label label9;
    }
}