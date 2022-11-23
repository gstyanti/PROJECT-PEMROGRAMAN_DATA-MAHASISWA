namespace Program_Sederhana_Biodata_Mahasiswa
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_nama = new System.Windows.Forms.TextBox();
            this.rb_lk = new System.Windows.Forms.RadioButton();
            this.rb_pr = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_jur = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_proses = new System.Windows.Forms.Button();
            this.btn_bersih = new System.Windows.Forms.Button();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(87, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jenis Kelamin ";
            // 
            // txt_nama
            // 
            this.txt_nama.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nama.Location = new System.Drawing.Point(301, 120);
            this.txt_nama.Name = "txt_nama";
            this.txt_nama.Size = new System.Drawing.Size(202, 38);
            this.txt_nama.TabIndex = 2;
            // 
            // rb_lk
            // 
            this.rb_lk.AutoSize = true;
            this.rb_lk.BackColor = System.Drawing.Color.Transparent;
            this.rb_lk.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_lk.Location = new System.Drawing.Point(301, 170);
            this.rb_lk.Name = "rb_lk";
            this.rb_lk.Size = new System.Drawing.Size(131, 34);
            this.rb_lk.TabIndex = 3;
            this.rb_lk.TabStop = true;
            this.rb_lk.Text = "Laki-Laki";
            this.rb_lk.UseVisualStyleBackColor = false;
            // 
            // rb_pr
            // 
            this.rb_pr.AutoSize = true;
            this.rb_pr.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_pr.Location = new System.Drawing.Point(473, 168);
            this.rb_pr.Name = "rb_pr";
            this.rb_pr.Size = new System.Drawing.Size(146, 34);
            this.rb_pr.TabIndex = 4;
            this.rb_pr.TabStop = true;
            this.rb_pr.Text = "Perempuan";
            this.rb_pr.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(87, 224);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 30);
            this.label3.TabIndex = 5;
            this.label3.Text = "Jurusan ";
            // 
            // cmb_jur
            // 
            this.cmb_jur.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_jur.FormattingEnabled = true;
            this.cmb_jur.Items.AddRange(new object[] {
            "Teknik Informatika",
            "Teknik Komputer",
            "Teknik Sipil",
            "Ilmu Komputer",
            "Sistem Informasi",
            "Hubungan Internasional"});
            this.cmb_jur.Location = new System.Drawing.Point(301, 224);
            this.cmb_jur.Name = "cmb_jur";
            this.cmb_jur.Size = new System.Drawing.Size(282, 38);
            this.cmb_jur.TabIndex = 6;
            this.cmb_jur.Text = "Silahkan Pilih Jurusan";
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 30;
            this.listBox1.Location = new System.Drawing.Point(301, 293);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(282, 154);
            this.listBox1.TabIndex = 7;
            // 
            // btn_proses
            // 
            this.btn_proses.BackColor = System.Drawing.Color.Red;
            this.btn_proses.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_proses.ForeColor = System.Drawing.Color.White;
            this.btn_proses.Location = new System.Drawing.Point(161, 490);
            this.btn_proses.Name = "btn_proses";
            this.btn_proses.Size = new System.Drawing.Size(114, 52);
            this.btn_proses.TabIndex = 8;
            this.btn_proses.Text = "Proses";
            this.btn_proses.UseVisualStyleBackColor = false;
            this.btn_proses.Click += new System.EventHandler(this.btn_proses_Click);
            // 
            // btn_bersih
            // 
            this.btn_bersih.BackColor = System.Drawing.Color.Blue;
            this.btn_bersih.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bersih.ForeColor = System.Drawing.Color.White;
            this.btn_bersih.Location = new System.Drawing.Point(406, 490);
            this.btn_bersih.Name = "btn_bersih";
            this.btn_bersih.Size = new System.Drawing.Size(114, 52);
            this.btn_bersih.TabIndex = 9;
            this.btn_bersih.Text = "Bersih";
            this.btn_bersih.UseVisualStyleBackColor = false;
            this.btn_bersih.Click += new System.EventHandler(this.btn_bersih_Click);
            // 
            // btn_keluar
            // 
            this.btn_keluar.BackColor = System.Drawing.Color.MediumOrchid;
            this.btn_keluar.Font = new System.Drawing.Font("Comic Sans MS", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_keluar.ForeColor = System.Drawing.Color.White;
            this.btn_keluar.Location = new System.Drawing.Point(652, 490);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(114, 52);
            this.btn_keluar.TabIndex = 10;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = false;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Jokerman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 41);
            this.label4.TabIndex = 11;
            this.label4.Text = "Program Sederhana Biodata Mahasiswa";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(911, 654);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.btn_bersih);
            this.Controls.Add(this.btn_proses);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cmb_jur);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb_pr);
            this.Controls.Add(this.rb_lk);
            this.Controls.Add(this.txt_nama);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_nama;
        private System.Windows.Forms.RadioButton rb_lk;
        private System.Windows.Forms.RadioButton rb_pr;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_jur;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_proses;
        private System.Windows.Forms.Button btn_bersih;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Label label4;
    }
}

