namespace AppLaundry
{
    partial class Form5
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_delete = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_create = new System.Windows.Forms.Button();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_daftarharga = new System.Windows.Forms.Button();
            this.btn_daftarcustomer = new System.Windows.Forms.Button();
            this.btn_daftarkariawan = new System.Windows.Forms.Button();
            this.btn_transaksi = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btn_refresh);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.btn_delete);
            this.panel2.Controls.Add(this.btn_edit);
            this.panel2.Controls.Add(this.btn_create);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Location = new System.Drawing.Point(-2, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(693, 256);
            this.panel2.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 204);
            this.dataGridView1.TabIndex = 24;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Location = new System.Drawing.Point(577, 3);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(102, 30);
            this.btn_delete.TabIndex = 23;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_edit.Location = new System.Drawing.Point(469, 3);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(102, 30);
            this.btn_edit.TabIndex = 22;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = false;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_create
            // 
            this.btn_create.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btn_create.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_create.Location = new System.Drawing.Point(361, 3);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(102, 30);
            this.btn_create.TabIndex = 21;
            this.btn_create.Text = "Create";
            this.btn_create.UseVisualStyleBackColor = false;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(64, 8);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(171, 20);
            this.txt_search.TabIndex = 20;
            this.txt_search.TextChanged += new System.EventHandler(this.txt_search_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_daftarharga);
            this.panel1.Controls.Add(this.btn_daftarcustomer);
            this.panel1.Controls.Add(this.btn_daftarkariawan);
            this.panel1.Controls.Add(this.btn_transaksi);
            this.panel1.Location = new System.Drawing.Point(-2, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 109);
            this.panel1.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DarkBlue;
            this.label9.Location = new System.Drawing.Point(14, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(425, 43);
            this.label9.TabIndex = 35;
            this.label9.Text = "Selamat Datang di Lulu n Wash";
            // 
            // btn_daftarharga
            // 
            this.btn_daftarharga.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_daftarharga.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.btn_daftarcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.btn_daftarkariawan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
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
            this.btn_transaksi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_transaksi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_transaksi.Location = new System.Drawing.Point(12, 63);
            this.btn_transaksi.Name = "btn_transaksi";
            this.btn_transaksi.Size = new System.Drawing.Size(159, 35);
            this.btn_transaksi.TabIndex = 0;
            this.btn_transaksi.Text = "Transaksi";
            this.btn_transaksi.UseVisualStyleBackColor = false;
            this.btn_transaksi.Click += new System.EventHandler(this.btn_transaksi_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Location = new System.Drawing.Point(241, 8);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(21, 20);
            this.btn_refresh.TabIndex = 27;
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(688, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form5";
            this.Text = "Daftar Kariawan";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_create;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_daftarharga;
        private System.Windows.Forms.Button btn_daftarcustomer;
        private System.Windows.Forms.Button btn_daftarkariawan;
        private System.Windows.Forms.Button btn_transaksi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_refresh;
    }
}