using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                    }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void rakamOlay(object sender, EventArgs e)
        {
            if(textBox1.Text == "0" || opertDrm)
            {
                textBox1.Clear();
            }
            opertDrm = false;
            Button btn = (Button)sender;
            textBox1.Text += btn.Text;
        }
        bool opertDrm = false;
        double sonuc = 0;
        string opert = "";
        private void islemOlay(object sender, EventArgs e)
        {
            opertDrm = true;
            Button btn = (Button)sender;
            string yeniOpr = btn.Text;

            label1.Text = label1.Text + " " + textBox1.Text + " " + yeniOpr;

            switch (opert)
            {
                case "+":textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString();break;
                case "-":textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString();break;
                case "*":textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString();break;
                case "/":textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString();break;
            }
            sonuc = Double.Parse(textBox1.Text);
            textBox1.Text = sonuc.ToString();
            opert = yeniOpr;
        }

        private void C(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            
        }

        private void CE(object sender, EventArgs e)
        {
            label1.Text = "Sonuç:";
            textBox1.Text = "0";
            opert = "";
            sonuc = 0;
            opertDrm = false;
        }

        private void esit(object sender, EventArgs e)
        {
            label1.Text = "Sonuç:";
            opertDrm = true;

            switch (opert)
            {
                case "+": textBox1.Text = (sonuc + Double.Parse(textBox1.Text)).ToString(); break;
                case "-": textBox1.Text = (sonuc - Double.Parse(textBox1.Text)).ToString(); break;
                case "*": textBox1.Text = (sonuc * Double.Parse(textBox1.Text)).ToString(); break;
                case "/": textBox1.Text = (sonuc / Double.Parse(textBox1.Text)).ToString(); break;
            }
            label1.Text = "Sonuç: " + textBox1.Text + opert + sonuc;

        }

        private void nokta(object sender, EventArgs e)
        {
            if(textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ",";
            }
        }
    }
}
