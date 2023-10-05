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
using System.Text.RegularExpressions;
using System.IO;

namespace personelTakip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        OleDbConnection baglantim = new OleDbConnection("Provider=Microsoft.Ace.OleDb.12.0; Data Source=personel.accdb");

        private void kullaniciListesi()
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter kullanici_listesi = new OleDbDataAdapter("Select tcno AS[TC NUMARASI],ad AS[ADI],soyad AS [SOYADI],yetki AS [TETKİSİ],kullanici AS [KULLANICI],parola AS[PAROLA] from kullanici Order By ad ASC", baglantim);
                DataSet dshafiza = new DataSet();
                kullanici_listesi.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglantim.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantim.Close() ;
            }
        }
        private void personelListesi()
        {
            try
            {
                baglantim.Open();
                OleDbDataAdapter personel_listesi = new OleDbDataAdapter("Select tcno AS[TC Numarası],ad AS[Adı],soyad AS [Soyadı],cinsiyet AS [Cinsiyet],doguntarihi AS[Doğum Tarihi],gorevi AS[Görevi] from personeller Order By ad ASC", baglantim);
                DataSet dshafiza = new DataSet();
                personel_listesi.Fill(dshafiza);
                dataGridView2.DataSource = dshafiza.Tables[0];
                baglantim.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantim.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            kullaniciListesi();
            personelListesi();

            pictureBox1.Height = 150;
            pictureBox2.Width = 150;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

            try
            {
                //Oğuzhanın stringi :)
                string a =$"{ Application.StartupPath}\\kullaniciresimleri\\{Form1.tcno}.png";
                pictureBox1.Image = Image.FromFile(a);          
            }
            catch 
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimleri\\resimsiz.jpeg");
            }

            //Kullanıcı İşlemleri

            this.Text = "YÖNETİCİ İŞLEMLERİ";
            label9.ForeColor = Color.Red;
            label9.Text = Form1.adi + " " + Form1.soyadi;
            textBox1.MaxLength = 11;
            textBox4.MaxLength = 8;
            toolTip1.SetToolTip(this.textBox1, "TC Kimlik Numarası 11 Karakter İçermelidir!");
            radioButton1.Checked = true;
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox3.CharacterCasing = CharacterCasing.Upper;
            textBox5.MaxLength = 10;
            textBox6.MaxLength = 10;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            kullaniciListesi();

            //Personel İşlemleri

            pictureBox2.SizeMode = PictureBoxSizeMode .StretchImage;
            pictureBox2.Width = 100; pictureBox2.Height = 100;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox2.Mask = "LL????????????";
            maskedTextBox3.Mask = "LL????????????";
            maskedTextBox4.Mask = "00000";
            maskedTextBox2.Text.ToUpper();
            maskedTextBox3.Text.ToUpper();
            radioButton3.Checked = true;
            comboBox1.Items.Add("Lisans");
            comboBox1.Items.Add("Yüksek Lisans");
            comboBox1.Items.Add("Doktora");
            comboBox2.Items.Add("İnsan Kaynakları");
            comboBox2.Items.Add("Muhasebe");
            comboBox2.Items.Add("Halkla İlişkiler");

            DateTime zaman = DateTime.Now;
            int yil = int.Parse(zaman.ToString("yyyy"));
            int ay = int.Parse(zaman.ToString("MM"));
            int gun = int.Parse(zaman.ToString("dd"));

            dateTimePicker1.MinDate = new DateTime(1975, 1, 1);
            dateTimePicker1.MaxDate = new DateTime(yil-18,ay,gun);
            dateTimePicker1.Format = DateTimePickerFormat.Short;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 11)
                errorProvider1.SetError(textBox1, "TC Kimlik Numarası 11 Karakter Olmalıdır!");
            else
                errorProvider1.Clear();
        }

        private void textbox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((int)e.KeyChar >=48 && (int)e.KeyChar <=57 || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled= true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) == true||char.IsControl(e.KeyChar)==true || char.IsSeparator(e.KeyChar)==true)
                e.Handled = false;
            else
                e.Handled= true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length != 8)
                errorProvider1.SetError(textBox4, "Kullanıcı adı 8 karakterden oluşmalıdır");
            else
                errorProvider1.Clear();
        }

        int parola_skoru = 0;
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            string parola_seviyesi = "";
            int kucuk_harf = 0, buyuk_harf = 0, rakam = 0, sembol = 0;

            string sifre = textBox5.Text;
            string duzeltilmis_sifre = "";

            duzeltilmis_sifre = sifre;
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('İ', 'I');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ı', 'i');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ç', 'c');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ş', 's');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ü', 'u');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ğ', 'g');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ü', 'U');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ö', 'O');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ö', 'o');

            if(sifre != duzeltilmis_sifre)
            {
                sifre = duzeltilmis_sifre;
                textBox5.Text = sifre;
                MessageBox.Show("Paroladaki Türkçe Karakterler Dönüştürüldü.");
            }
            int az_karakter_sayisi = sifre.Length - Regex.Replace(sifre, "[a-z]", "").Length;
            kucuk_harf = Math.Min(2, az_karakter_sayisi) * 10;

            int AZ_karakter_sayisi = sifre.Length - Regex.Replace(sifre, "[A-Z]", "").Length;
            buyuk_harf = Math.Min(2, AZ_karakter_sayisi) * 10;

            int rakam_sayisi = sifre.Length - Regex.Replace(sifre, "[0-9]", "").Length;
            rakam = Math.Min(2, rakam_sayisi) * 10;

            int sembol_sayisi = sifre.Length - az_karakter_sayisi - AZ_karakter_sayisi - rakam_sayisi;
            sembol = Math.Min(2, sembol_sayisi) * 10;

            parola_skoru = kucuk_harf + buyuk_harf + rakam + sembol;

            if (sifre.Length == 9)
                parola_skoru += 10;
            else if (sifre.Length == 11)
                parola_skoru += 10;
            if (parola_skoru <= 60)
                parola_seviyesi = "Parola Seviyesi Düşük";
            else if (parola_skoru >= 61 || parola_skoru >= 85)
                parola_seviyesi = "Güçlü";
            else if (parola_skoru >= 86 || parola_skoru >= 100)
                parola_seviyesi = "Çok Güçlü";

            label19.Text = "%" + Convert.ToString(parola_skoru);
            label21.Text = parola_seviyesi;
            progressBar1.Value = parola_skoru;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (textBox6.Text != textBox5.Text)
                errorProvider1.SetError(textBox6, "Parola Eşleşmedi");
            else
                errorProvider1.Clear();
        }

        private void topPage1_clear()
        {
            textBox1.Clear();textBox2.Clear();textBox3.Clear();textBox4.Clear();textBox5.Clear();textBox6.Clear();
        }

        private void topPage2_clear()
        {
            pictureBox1.Image = null; maskedTextBox1.Clear();maskedTextBox2.Clear();maskedTextBox3.Clear();maskedTextBox4.Clear();comboBox1.SelectedIndex = -1;comboBox2.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string yetki = "";
            bool kayitkontrol = false;
            baglantim.Open();

            OleDbCommand selectSorgu = new OleDbCommand("Select * from kullanici where tcno='"+textBox1.Text+"'",baglantim);
            OleDbDataReader kayitokuma = selectSorgu.ExecuteReader();

            while (kayitokuma.Read())
            {
                kayitkontrol =true;
                break;
            }
            baglantim.Close();

            if(kayitkontrol == false) {
            if(textBox1.Text.Length <11 || textBox1.Text =="")
                label1.ForeColor = Color.Red;
            else
                label1.ForeColor = Color.Black;
            if (textBox2.Text.Length < 2 || textBox2.Text == "")
                label2.ForeColor = Color.Red;
            else
                label2.ForeColor = Color.Black;
            if (textBox3.Text.Length < 2 || textBox3.Text == "")
                label3.ForeColor = Color.Red;
            else
                label3.ForeColor = Color.Black;
            if (textBox4.Text.Length !=8 || textBox4.Text == "")
                label5.ForeColor = Color.Red;
            else
                label5.ForeColor = Color.Black;
            if (parola_skoru<65 || textBox5.Text == "")
                label6.ForeColor = Color.Red;
            else
                label6.ForeColor = Color.Black;
            if (textBox6.Text != textBox5.Text || textBox5.Text == "")
                label7.ForeColor = Color.Red;
            else
                label7.ForeColor = Color.Black;

            if(textBox1.Text.Length == 11 && textBox1.Text != ""&&textBox2.Text.Length>1&&textBox2.Text != ""&&textBox3.Text.Length>1 && textBox3.Text!=""&&textBox4.Text != ""&&textBox5.Text!=""&&textBox6.Text!=""&&textBox5.Text ==textBox6.Text && parola_skoru >= 65)
            {
                if (radioButton1.Checked == true)
                    yetki = "Yönetici";
                else if (radioButton2.Checked == true)
                    yetki = "Kullanıcı";

                try
                {
                    baglantim.Open();
                    OleDbCommand eklekomutu = new OleDbCommand("insert into kullanici values('"+textBox1.Text+"','"+textBox2.Text+"','" + textBox3.Text+"','" +yetki+"','" + textBox4.Text+"','" + textBox5.Text+"')",baglantim);
                    eklekomutu.ExecuteNonQuery();
                    baglantim.Close();
                    MessageBox.Show("Kullanıcı başarılı bir şekilde kayıt edildi!", "Kayıt Gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     topPage1_clear();
                     kullaniciListesi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex. Message);
                    baglantim.Close();
                }
                }
                else
                {
                    MessageBox.Show("Uyarı verilen alanları gözden geçir!", "Kayıt Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bu TC Kimlik Numarasına Ait Bir Kullanıcı Var!", "Kayıt Kontrol", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool kayit_durum = false;
            if (textBox1.Text.Length == 11)
            {
                baglantim.Open();
                OleDbCommand cmd = new OleDbCommand("select * from kullanici where tcno='" + textBox1.Text + "'", baglantim);
                OleDbDataReader kayitokuma = cmd.ExecuteReader();

                while (kayitokuma.Read())
                {

                    kayit_durum = true;
                    textBox2.Text = kayitokuma.GetValue(1).ToString();
                    textBox3.Text = kayitokuma.GetValue(2).ToString();
                    if (kayitokuma.GetValue(3).ToString() == "Yönetici")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                    textBox4.Text = kayitokuma.GetValue(4).ToString();
                    textBox5.Text = kayitokuma.GetValue(5).ToString();
                    break;
                }
                if (kayit_durum == false)
                    MessageBox.Show("Bu Tc Kimlik Numarasına Ait Kullanıcı Bulunamadı.", "Personel Arama", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                baglantim.Close();
            }
            else
                MessageBox.Show("Lütfen 11 haneli bir TC kimlik numarası giriniz.", "Personel Arama", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string yetki = "";
           
                if (textBox1.Text.Length < 11 || textBox1.Text == "")
                    label1.ForeColor = Color.Red;
                else
                    label1.ForeColor = Color.Black;
                if (textBox2.Text.Length < 2 || textBox2.Text == "")
                    label2.ForeColor = Color.Red;
                else
                    label2.ForeColor = Color.Black;
                if (textBox3.Text.Length < 2 || textBox3.Text == "")
                    label3.ForeColor = Color.Red;
                else
                    label3.ForeColor = Color.Black;
                if (textBox4.Text.Length != 8 || textBox4.Text == "")
                    label5.ForeColor = Color.Red;
                else
                    label5.ForeColor = Color.Black;
                if (parola_skoru < 65 || textBox5.Text == "")
                    label6.ForeColor = Color.Red;
                else
                    label6.ForeColor = Color.Black;
                if (textBox6.Text != textBox5.Text || textBox5.Text == "")
                    label7.ForeColor = Color.Red;
                else
                    label7.ForeColor = Color.Black;

                if (textBox1.Text.Length == 11 && textBox1.Text != "" && textBox2.Text.Length > 1 && textBox2.Text != "" && textBox3.Text.Length > 1 && textBox3.Text != "" && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "" && textBox5.Text == textBox6.Text && parola_skoru >= 65)
                {
                    if (radioButton1.Checked == true)
                        yetki = "Yönetici";
                    else if (radioButton2.Checked == true)
                        yetki = "Kullanıcı";

                    try
                    {
                        baglantim.Open();
                        OleDbCommand guncellekomutu = new OleDbCommand("update kullanici set ad='"+textBox2.Text+"',soyad='"+textBox3.Text+"',yetki ='"+yetki+"',kullanici='"+textBox4.Text+"',parola='"+textBox5.Text+"' where tcno='"+textBox1.Text+"'",baglantim);
                    guncellekomutu.ExecuteNonQuery();
                        baglantim.Close();
                        MessageBox.Show("Kullanıcı başarılı bir şekilde güncellendi!", "Kayıt Gerçekleşti", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        topPage1_clear();
                        kullaniciListesi();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        baglantim.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Uyarı verilen alanları gözden geçir!", "Kayıt Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        private void button10_Click(object sender, EventArgs e)
        {
            topPage1_clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length == 11)
            {
                bool kayıt_durum = false;baglantim.Open();
                OleDbCommand selectsorugu = new OleDbCommand("select * from kullanici where tcno='" + textBox1.Text + "'", baglantim);
                OleDbDataReader kayitokuma= selectsorugu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    kayıt_durum =true;
                    OleDbCommand deletesorgu = new OleDbCommand("delete from kullanici where tcno='"+textBox1.Text+ "'", baglantim);
                    deletesorgu.ExecuteNonQuery();
                    MessageBox.Show("Kullanıcı başarılı bir şekilde silindi.", "Personel Silme", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    baglantim.Close() ;
                    kullaniciListesi();
                    topPage1_clear();
                    break;
                }
                if(kayıt_durum==false)
                    MessageBox.Show("Silinecek kayıt bulunamadı", "Personel Silme", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantim.Close();
                topPage1_clear();
            }else
                MessageBox.Show("Lütfen 11 haneli bir TC Kimlik Numarası Girin", "Personel Silme", MessageBoxButtons.OK, MessageBoxIcon.Error);
            baglantim.Close();
            topPage1_clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "JPG Dosyalar (*.jpg) | *.jpg";
            image.Title = "Personel Resmi Seçin";
            image.Multiselect = false;
            if(image.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.Image = new Bitmap(image.OpenFile());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
            bool kayitKontrol = false;

            baglantim.Open();

            OleDbCommand selectSorgu = new OleDbCommand("select * from personeller where tcno='"+maskedTextBox1.Text+"'",baglantim);
            OleDbDataReader kayitOkuma = selectSorgu.ExecuteReader();
            while (kayitOkuma.Read())
            {
                kayitKontrol = true;
                break;
            }
            baglantim.Close();
            if (kayitKontrol == false)
            {
                if (pictureBox2.Image == null)
                    button5.ForeColor = Color.Red;
                else
                    button5.ForeColor = Color.Black;
                if (maskedTextBox1.MaskCompleted == false)
                    label10.ForeColor = Color.Red;
                else
                    label10.ForeColor = Color.Black;
                if (maskedTextBox2.MaskCompleted == false)
                    label11.ForeColor = Color.Red;
                else
                    label11.ForeColor = Color.Black;
                if (maskedTextBox3.MaskCompleted == false)
                    label12.ForeColor = Color.Red;
                else
                    label12.ForeColor = Color.Black;
                if (maskedTextBox4.MaskCompleted == false)
                    label17.ForeColor = Color.Red;
                else
                    label17.ForeColor = Color.Black;
                if (comboBox1.Text == "")
                    label15.ForeColor = Color.Red;
                else
                    label15.ForeColor = Color.Black;
                if (comboBox2.Text == "")
                    label16.ForeColor = Color.Red;
                else
                    label16.ForeColor = Color.Black;

                if(pictureBox2.Image != null && maskedTextBox1.MaskCompleted !=false && maskedTextBox2.MaskCompleted != false && maskedTextBox3.MaskCompleted != false && maskedTextBox4.MaskCompleted != false && comboBox1.Text != "" && comboBox2.Text != "")
                {
                    if(radioButton3.Checked == true)
                    {
                        cinsiyet = "Bay";
                    }
                    else if(radioButton4.Checked == true)
                    {
                        cinsiyet = "Bayan";
                    }
                    try
                    {
                        baglantim.Open();
                        OleDbCommand eklekomutu = new OleDbCommand("insert into personeller values('"+maskedTextBox1.Text+"','"+maskedTextBox2.Text+"','"+maskedTextBox3.Text+"','"+cinsiyet+"','"+dateTimePicker1.Text+"','"+comboBox1.Text+"','"+comboBox2.Text+"','"+maskedTextBox4.Text+"')",baglantim);
                        eklekomutu.ExecuteNonQuery();
                        baglantim.Close();
                        if (!Directory.Exists(Application.StartupPath + "\\personelresimleri"))
                            Directory.CreateDirectory(Application.StartupPath + "\\personelresimleri");
                        pictureBox2.Image.Save(Application.StartupPath + "\\personelresimleri\\" + maskedTextBox1.Text + ".jpg");

                        MessageBox.Show("Yeni Personel Oluşturuldu!", "Personel Kayıt Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        personelListesi();
                        topPage2_clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message,"Personel Kayıt Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Yazı rengi kırmızı olan alanları kontrol ediniz!", "Personel Kayıt Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            bool kayit_arama_durumu = false;

            if (maskedTextBox1.Text.Length == 11)
            {
                baglantim.Open();
                OleDbCommand selectSorgu = new OleDbCommand("select * from personeller where tcno='" + maskedTextBox1.Text + "'", baglantim);
                OleDbDataReader kayitOkuma = selectSorgu.ExecuteReader();
                while (kayitOkuma.Read())
                {
                    kayit_arama_durumu = true;
                    try
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\personelresimleri\\" + kayitOkuma.GetValue(0).ToString() + ".jpg");

                    }
                    catch (Exception)
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\personelresimleri\\resimsiz.jpg");
                    }
                    maskedTextBox2.Text = kayitOkuma.GetValue(1).ToString();
                    maskedTextBox3.Text = kayitOkuma.GetValue(2).ToString();
                    maskedTextBox4.Text = kayitOkuma.GetValue(7).ToString();
                    if (kayitOkuma.GetValue(3).ToString() == "Bay")
                        radioButton3.Checked = true;
                    else
                        radioButton4.Checked = true;
                    dateTimePicker1.Text = kayitOkuma.GetValue(4).ToString();
                    comboBox1.Text = kayitOkuma.GetValue(5).ToString();
                    comboBox2.Text = kayitOkuma.GetValue(6).ToString();
                    break;
                }
                if (kayit_arama_durumu == false)
                    MessageBox.Show("Aranan kullanıcı kayıtlı değildir!", "Personel Arama", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglantim.Close();
            }
            else
            {
                MessageBox.Show("Lütfen 11 haneli bir TC kimlik numarası giriniz!", "Personel Arama", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";
            
                if (pictureBox2.Image == null)
                    button5.ForeColor = Color.Red;
                else
                    button5.ForeColor = Color.Black;
                if (maskedTextBox1.MaskCompleted == false)
                    label10.ForeColor = Color.Red;
                else
                    label10.ForeColor = Color.Black;
                if (maskedTextBox2.MaskCompleted == false)
                    label11.ForeColor = Color.Red;
                else
                    label11.ForeColor = Color.Black;
                if (maskedTextBox3.MaskCompleted == false)
                    label12.ForeColor = Color.Red;
                else
                    label12.ForeColor = Color.Black;
                if (maskedTextBox4.MaskCompleted == false)
                    label17.ForeColor = Color.Red;
                else
                    label17.ForeColor = Color.Black;
                if (comboBox1.Text == "")
                    label15.ForeColor = Color.Red;
                else
                    label15.ForeColor = Color.Black;
                if (comboBox2.Text == "")
                    label16.ForeColor = Color.Red;
                else
                    label16.ForeColor = Color.Black;

                if (pictureBox2.Image != null && maskedTextBox1.MaskCompleted != false && maskedTextBox2.MaskCompleted != false && maskedTextBox3.MaskCompleted != false && maskedTextBox4.MaskCompleted != false && comboBox1.Text != "" && comboBox2.Text != "")
                {
                    if (radioButton3.Checked == true)
                    {
                        cinsiyet = "Bay";
                    }
                    else if (radioButton4.Checked == true)
                    {
                        cinsiyet = "Bayan";
                    }
                    try
                    {
                        baglantim.Open();
                        OleDbCommand guncellemeKomutu = new OleDbCommand("update personeller set ad='" + maskedTextBox2.Text + "',soyad='" + maskedTextBox3.Text + "',cinsiyet='" + cinsiyet + "',doguntarihi='" + dateTimePicker1.Text + "',gorevi='" + comboBox1.Text + "',gorevyeri='" + comboBox2.Text + "',maasi='" + maskedTextBox4.Text + "' where tcno='"+maskedTextBox1.Text+"'", baglantim);
                         guncellemeKomutu.ExecuteNonQuery();
                        baglantim.Close();                       
                        MessageBox.Show("Personel Güncellendi!", "Personel Kayıt Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        personelListesi();
                        topPage2_clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Personel Güncelle Sistemi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        private void button9_Click(object sender, EventArgs e)
        {
            if(maskedTextBox1.MaskCompleted == true)
            {
                bool kayit_arama_durum = false;
                baglantim.Open();
                OleDbCommand selectSorgu = new OleDbCommand("select * from personeller where tcno ='" + maskedTextBox1.Text + "'", baglantim);
                OleDbDataReader kayitArama = selectSorgu.ExecuteReader();
                while (kayitArama.Read())
                {
                    kayit_arama_durum = true;
                    OleDbCommand deleteSorgu = new OleDbCommand("delete from personeller where tcno='"+maskedTextBox1.Text+ "'", baglantim);
                    deleteSorgu.ExecuteNonQuery();
                    break;
                }
                if(kayit_arama_durum == false)
                {
                    MessageBox.Show("Silinecek personel bulunmamadı","Personel Silme Ekranı",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                baglantim.Close();
                personelListesi();
                topPage2_clear();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir TC kimlik numarası giriniz!", "Personel Silme Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    }


