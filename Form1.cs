using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_Sederhana_Biodata_Mahasiswa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void btn_proses_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(txt_nama.Text);
            if (rb_lk.Checked == true)
                listBox1.Items.Add(rb_lk.Text);
            else if (rb_pr.Checked == true)
                listBox1.Items.Add(rb_pr.Text);
            listBox1.Items.Add(cmb_jur.Text);
        }

        private void btn_bersih_Click(object sender, EventArgs e)
        {
            txt_nama.Text = "";
            rb_lk.Checked = false;
            rb_pr.Checked = false;
            cmb_jur.Text = "Pilih Jurusan";
            listBox1.Items.Clear();
            txt_nama.Focus();
        }

        private void btn_keluar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
