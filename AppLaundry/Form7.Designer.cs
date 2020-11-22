namespace AppLaundry
{
    partial class Form7
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_daftarharga = new System.Windows.Forms.Button();
            this.btn_daftarcustomer = new System.Windows.Forms.Button();
            this.btn_daftarkariawan = new System.Windows.Forms.Button();
            this.btn_transaksi = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_harga = new System.Windows.Forms.TextBox();
            this.txt_minorder = new System.Windows.Forms.TextBox();
            this.txt_layanan = new System.Windows.Forms.TextBox();
            this.txt_durasi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_satuan = new System.Windows.Forms.ComboBox();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_daftarharga);
            this.panel1.Controls.Add(this.btn_daftarcustomer);
            this.panel1.Controls.Add(this.btn_daftarkariawan);
            this.panel1.Controls.Add(this.btn_transaksi);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 109);
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
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(327, 204);
            this.dataGridView1.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Search";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(67, 120);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(243, 20);
            this.txt_search.TabIndex = 37;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(578, 324);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(96, 30);
            this.btn_delete.TabIndex = 41;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Location = new System.Drawing.Point(481, 324);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(91, 30);
            this.btn_edit.TabIndex = 40;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_create.Location = new System.Drawing.Point(372, 324);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(103, 30);
            this.btn_create.TabIndex = 39;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(368, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 13);
            this.label2.TabIndex = 42;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Nama Layanan";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(368, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Durasi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Harga";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 46;
            this.label6.Text = "Min Order";
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(477, 150);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(197, 20);
            this.txt_id.TabIndex = 47;
            // 
            // txt_harga
            // 
            this.txt_harga.Location = new System.Drawing.Point(477, 228);
            this.txt_harga.Name = "txt_harga";
            this.txt_harga.Size = new System.Drawing.Size(197, 20);
            this.txt_harga.TabIndex = 48;
            // 
            // txt_minorder
            // 
            this.txt_minorder.Location = new System.Drawing.Point(477, 254);
            this.txt_minorder.Name = "txt_minorder";
            this.txt_minorder.Size = new System.Drawing.Size(197, 20);
            this.txt_minorder.TabIndex = 49;
            // 
            // txt_layanan
            // 
            this.txt_layanan.Location = new System.Drawing.Point(477, 176);
            this.txt_layanan.Name = "txt_layanan";
            this.txt_layanan.Size = new System.Drawing.Size(197, 20);
            this.txt_layanan.TabIndex = 50;
            // 
            // txt_durasi
            // 
            this.txt_durasi.Location = new System.Drawing.Point(477, 202);
            this.txt_durasi.Name = "txt_durasi";
            this.txt_durasi.Size = new System.Drawing.Size(197, 20);
            this.txt_durasi.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Satuan";
            // 
            // txt_satuan
            // 
            this.txt_satuan.FormattingEnabled = true;
            this.txt_satuan.Items.AddRange(new object[] {
            "PCS",
            "KG"});
            this.txt_satuan.Location = new System.Drawing.Point(477, 280);
            this.txt_satuan.Name = "txt_satuan";
            this.txt_satuan.Size = new System.Drawing.Size(197, 21);
            this.txt_satuan.TabIndex = 54;
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(316, 120);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(21, 20);
            this.btn_refresh.TabIndex = 55;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(688, 366);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.txt_satuan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_durasi);
            this.Controls.Add(this.txt_layanan);
            this.Controls.Add(this.txt_minorder);
            this.Controls.Add(this.txt_harga);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "Form7";
            this.Text = "Daftar Harga";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_daftarharga;
        private System.Windows.Forms.Button btn_daftarcustomer;
        private System.Windows.Forms.Button btn_daftarkariawan;
        private System.Windows.Forms.Button btn_transaksi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_harga;
        private System.Windows.Forms.TextBox txt_minorder;
        private System.Windows.Forms.TextBox txt_layanan;
        private System.Windows.Forms.TextBox txt_durasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox txt_satuan;
        private System.Windows.Forms.Button btn_refresh;
    }
}