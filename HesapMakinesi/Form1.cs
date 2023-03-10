using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double y;
        string islem;

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            islem = "Öylesine Değer";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                textBox1.Text = "0";
                label1.Text = "";
            }
            
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "-1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                textBox1.Text = "0";
                label1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "-2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                textBox1.Text = "0";
                label1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "-3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                textBox1.Text = "0";
                label1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "-4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                textBox1.Text = "0";
                label1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "-5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                textBox1.Text = "0";
                label1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "-6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                textBox1.Text = "0";
                label1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "-7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                textBox1.Text = "0";
                label1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "-8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                textBox1.Text = "0";
                label1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "-9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //eşittirden sonra işlemlerre devam edilebilmesi için !!!BAŞLANGIÇ!!!
            if (label1.Text.Contains("="))
            {
                label1.Text = "";
            }
            //eşittirden sonra işlemlerre devam edilebilmesi için !!!BİTİŞ!!!

            //yeni
            if (islem == "+")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "+" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "+";
            }
            else if (islem == "-")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "-" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "+";
            }
            else if (islem == "*")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "*" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "+";
            }
            else if (islem == "/")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "/" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "+";
            }
            // yeni bitimi

            if (label1.Text == "")
            {
                label1.Text = textBox1.Text + "+";
            }

            textBox1.Text = "0";
            islem = "+";

        }

        private void button14_Click(object sender, EventArgs e)
        {
            //eşittirden sonra işlemlerre devam edilebilmesi için !!!BAŞLANGIÇ!!!
            if (label1.Text.Contains("="))
            {
                label1.Text = "";
            }
            //eşittirden sonra işlemlerre devam edilebilmesi için !!!BİTİŞ!!!

            //yeni
            if (islem == "+")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "+" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "-";
            }
            else if (islem == "-")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "-" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "-";
            }
            else if (islem == "*")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "*" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "-";
            }
            else if (islem == "/")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "/" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "-";
            }
            // yeni bitimi

            if (label1.Text == "")
            {
                label1.Text = textBox1.Text + "-";
            }

            islem = "-";
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //eşittirden sonra işlemlerre devam edilebilmesi için !!!BAŞLANGIÇ!!!
            if (label1.Text.Contains("="))
            {
                label1.Text = "";
            }
            //eşittirden sonra işlemlerre devam edilebilmesi için !!!BİTİŞ!!!



            //yeni
            if (islem == "+")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "+" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "*";
            }
            else if (islem == "-")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "-" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "*";
            }
            else if (islem == "*")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "*" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "*";
            }
            else if (islem == "/")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "/" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "*";
            }
            // yeni bitimi

            
            if (label1.Text == "")
            {
                label1.Text = textBox1.Text + "*";
            }

            islem = "*";
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //eşittirden sonra işlemlerre devam edilebilmesi için !!!BAŞLANGIÇ!!!
            if (label1.Text.Contains("="))
            {
                label1.Text = "";
            }
            //eşittirden sonra işlemlerre devam edilebilmesi için !!!BİTİŞ!!!

            //yeni
            if (islem == "+")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "+" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "/";
            }
            else if (islem == "-")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "-" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "/";
            }
            else if (islem == "*")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "*" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "/";
            }
            else if (islem == "/")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                string textsayi = textBox1.Text;
                textBox1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(y + "/" + textsayi + "=" + textBox1.Text);
                label1.Text = textBox1.Text + "/";
            }
            // yeni bitimi

            
            if (label1.Text == "")
            {
                label1.Text = textBox1.Text + "/";
            }
            
            islem = "/";
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            bool varmi = textBox1.Text.Contains(",");
            if (!varmi)
            {
                textBox1.Text += ",";
            }  
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("-"))
            {
                textBox1.Text = "-" + textBox1.Text;
            }
            else
            {
                textBox1.Text = textBox1.Text.Remove(0, 1);  
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (button20.Text == "Geçmişi Göster")
            {
                groupBox1.Visible = true;
                this.Size = new Size(680,462);
                button20.Text = "Geçmişi Gizle";
            }
            else if (button20.Text == "Geçmişi Gizle")
            {
                groupBox1.Visible = false;
                this.Size = new Size(400, 462);
                button20.Text = "Geçmişi Göster";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(label1.Text + textBox1.Text);
                
            }
            else if (islem == "-")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(label1.Text + textBox1.Text);
            }
            else if (islem == "*")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(label1.Text + textBox1.Text);
            }
            else if (islem == "/")
            {
                y = Convert.ToDouble(label1.Text.Remove(label1.Text.Length - 1, 1));
                label1.Text += textBox1.Text + "="; 
                textBox1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
                listBox1.Items.Add(label1.Text + textBox1.Text);
            }
            islem = "Öylesine Değer";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label1.Text.Contains("="))
            {
                textBox1.Text = "0";
                label1.Text = "";
            }

            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
            }
            else if (textBox1.Text == "-0")
            {
                textBox1.Text = "-0";
            }
            else
            {
                textBox1.Text += "0";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);

                if (textBox1.Text.Length == 0)
                {
                    textBox1.Text = "0";
                }
            }
        }
    }
}
