using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; // Veritabanı Kütüphanesi

namespace personelTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0;Data Source=personel.accdb");

        public static string tcno, adi, soyadi, yetki;

        private void button1_Click(object sender, EventArgs e)
        {
            if (hak != 0)
            {
                baglantim.Open();
                OleDbCommand selectSorgu = new OleDbCommand("Select * from kullanici", baglantim);
                OleDbDataReader kayitOkuma = selectSorgu.ExecuteReader();
                while (kayitOkuma.Read())
                {
                    if (radioButton1.Checked == true)
                    {
                        if (kayitOkuma["kullanici"].ToString()==textBox1.Text && kayitOkuma["parola"].ToString()==textBox2.Text && kayitOkuma["yetki"].ToString() == "Yönetici")
                        {
                            durum = true;

                            tcno = kayitOkuma.GetValue(1).ToString();
                            adi = kayitOkuma.GetValue(2).ToString();
                            soyadi = kayitOkuma.GetValue(3).ToString();
                            yetki = kayitOkuma.GetValue(4).ToString();
                            this.Hide();
                            Form2 frm2 = new Form2();
                            frm2.Show();
                            break;
                        }
                    }
                    if (radioButton2.Checked == true)
                    {
                        if (kayitOkuma["kullanici"].ToString() == textBox1.Text && kayitOkuma["parola"].ToString() == textBox2.Text && kayitOkuma["yetki"].ToString() == "Kullanıcı")
                        {
                            durum = true;
                            tcno = kayitOkuma.GetValue(0).ToString();
                            adi = kayitOkuma.GetValue(1).ToString();
                            soyadi = kayitOkuma.GetValue(2).ToString();
                            yetki = kayitOkuma.GetValue(3).ToString();
                            this.Hide();
                            Form3 frm3 = new Form3();
                            frm3.Show();
                            break;
                        }
                    }
                }
                if (durum == false)
                    hak--;
                baglantim.Close();
            }
            label5.Text = Convert.ToString(hak);
            if(hak == 0)
            {
                button1.Enabled = false;
                MessageBox.Show("Giriş Hakkı Kalmadı!", "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        int hak = 3; bool durum = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Text = "Kullanıcı Girişi";
            this.AcceptButton = button1;
            this.CancelButton = button2;
            radioButton1.Checked = true;
            label5.Text = Convert.ToString(hak);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
    }
}
