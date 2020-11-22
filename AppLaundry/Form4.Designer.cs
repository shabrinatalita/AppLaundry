namespace AppLaundry
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_save = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_alamat = new System.Windows.Forms.TextBox();
            this.txt_notelp = new System.Windows.Forms.TextBox();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txt_edit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_daftarharga = new System.Windows.Forms.Button();
            this.btn_daftarcustomer = new System.Windows.Forms.Button();
            this.btn_daftarkariawan = new System.Windows.Forms.Button();
            this.btn_transaksi = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_save);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txt_id);
            this.panel2.Controls.Add(this.txt_status);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txt_alamat);
            this.panel2.Controls.Add(this.txt_notelp);
            this.panel2.Controls.Add(this.txt_nama);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.txt_edit);
            this.panel2.Location = new System.Drawing.Point(12, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(663, 240);
            this.panel2.TabIndex = 13;
            // 
            // txt_save
            // 
            this.txt_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_save.Location = new System.Drawing.Point(361, 189);
            this.txt_save.Name = "txt_save";
            this.txt_save.Size = new System.Drawing.Size(93, 33);
            this.txt_save.TabIndex = 39;
            this.txt_save.Text = "Save";
            this.txt_save.UseVisualStyleBackColor = false;
            this.txt_save.Click += new System.EventHandler(this.txt_save_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(435, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 133);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "ID";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(126, 47);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(201, 20);
            this.txt_id.TabIndex = 36;
            // 
            // txt_status
            // 
            this.txt_status.FormattingEnabled = true;
            this.txt_status.Items.AddRange(new object[] {
            "Kariawan",
            "Kurir"});
            this.txt_status.Location = new System.Drawing.Point(126, 130);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(201, 21);
            this.txt_status.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 105);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "No Telp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Status";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Nama";
            // 
            // txt_alamat
            // 
            this.txt_alamat.Location = new System.Drawing.Point(126, 102);
            this.txt_alamat.Name = "txt_alamat";
            this.txt_alamat.Size = new System.Drawing.Size(201, 20);
            this.txt_alamat.TabIndex = 25;
            // 
            // txt_notelp
            // 
            this.txt_notelp.Location = new System.Drawing.Point(126, 74);
            this.txt_notelp.Name = "txt_notelp";
            this.txt_notelp.Size = new System.Drawing.Size(201, 20);
            this.txt_notelp.TabIndex = 24;
            // 
            // txt_nama
            // 
            this.txt_nama.Location = new System.Drawing.Point(126, 18);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(201, 20);
            this.txt_nama.TabIndex = 18;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(563, 189);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(82, 33);
            this.btn_delete.TabIndex = 9;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // txt_edit
            // 
            this.txt_edit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.txt_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txt_edit.Location = new System.Drawing.Point(460, 189);
            this.txt_edit.Name = "txt_edit";
            this.txt_edit.Size = new System.Drawing.Size(97, 33);
            this.txt_edit.TabIndex = 8;
            this.txt_edit.Text = "Edit";
            this.txt_edit.UseVisualStyleBackColor = false;
            this.txt_edit.Click += new System.EventHandler(this.txt_edit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_daftarharga);
            this.panel1.Controls.Add(this.btn_daftarcustomer);
            this.panel1.Controls.Add(this.btn_daftarkariawan);
            this.panel1.Controls.Add(this.btn_transaksi);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 109);
            this.panel1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(425, 43);
            this.label9.TabIndex = 34;
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
            this.btn_transaksi.Click += new System.EventHandler(this.btn_transaksi_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(688, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "CRUD Kariawan";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button txt_edit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_daftarharga;
        private System.Windows.Forms.Button btn_daftarcustomer;
        private System.Windows.Forms.Button btn_daftarkariawan;
        private System.Windows.Forms.Button btn_transaksi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_alamat;
        private System.Windows.Forms.TextBox txt_notelp;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txt_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button txt_save;
    }
}