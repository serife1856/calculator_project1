﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }
        double ilksayi;
        string islem;
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" && textBox1.Text!=null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text= textBox1.Text+"3";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" && textBox1.Text!=null) 
            { textBox1.Text = "2"; 
            }
            else
                textBox1.Text= textBox1.Text +"2";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="0" && textBox1.Text!=null) 
            {  textBox1.Text = "1"; }
            else
            {
                textBox1.Text=textBox1.Text +"1";
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if(textBox1.Text=="0" && textBox1.Text!=null) 
            { textBox1.Text = "4"; }
            else
            {
                textBox1.Text=textBox1.Text+"4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0" && textBox1.Text!=null)
            { textBox1.Text = "5"; }
            else
            {
                textBox1.Text=textBox1.Text+"5";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0" && textBox1.Text!=null)
            { textBox1.Text = "6"; }
            else
            {
                textBox1.Text=textBox1.Text+"6";
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0" && textBox1.Text!=null)
            { textBox1.Text = "7"; }
            else
            {
                textBox1.Text=textBox1.Text+"7";
            }

        }
        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0" && textBox1.Text!=null)
            { textBox1.Text = "8"; }
            else
            {
                textBox1.Text=textBox1.Text+"8";
            }

        }
        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0" && textBox1.Text!=null)
            { textBox1.Text = "9"; }
            else
            {
                textBox1.Text=textBox1.Text+"9";
            }

        }
        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="0" && textBox1.Text!=null)
            { textBox1.Text = "0"; }
            else
            {
                textBox1.Text=textBox1.Text+"0";
            }
        }
       

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (textBox1.TextLength==11)
            {
                textBox1.Font= new Font("Microsoft Sans Serif", 30);
            }
            else if (textBox1.TextLength >=12)
            {
                textBox1.Font = new Font("Microsoft Sans Serif", 15);
            }
        }
        
        private void btnTop_Click(object sender, EventArgs e)
        {
            ilksayi=Convert.ToDouble(textBox1.Text);
            textBox1.Text="";
            islem="+";
        }

        private void btncık_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text="";
            islem="-";
        }

        private void btncarp_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text="";
            islem="*";

        }
        private void button4_Click(object sender, EventArgs e)
        {
            ilksayi = Convert.ToDouble(textBox1.Text);
            textBox1.Text="";
            islem="/";

        }

        private void btnCln_Click(object sender, EventArgs e)
        {
            textBox1.Text="0";
        }
      

        private void btnEs_Click(object sender, EventArgs e)
        {
            double ikincisayi;
            double sonuc;
            ikincisayi = Convert.ToDouble(textBox1.Text);
            if (islem == "+")
            {
                sonuc = ilksayi + ikincisayi;
                textBox1.Text=Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem == "-") { 
              sonuc = ilksayi - ikincisayi; 
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem=="*")
            {
                sonuc = ilksayi * ikincisayi;
                textBox1.Text = Convert.ToString(sonuc);
                ilksayi = sonuc;
            }
            if (islem=="/")
            {
                if (ikincisayi==0)
                {
                    MessageBox.Show("Hatalı işlem 0 bölen olmaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    sonuc = ilksayi / ikincisayi;
                    textBox1.Text = Convert.ToString(sonuc);
                    ilksayi = sonuc;
                }
            }

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }
    }
}
