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

        double x, y;
        string yazi,islem,teyitislem;

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text += "2";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text += "3";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text += "4";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            //yeni
            if (islem == "+")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text = textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "+";
                //textBox1.Text = "0";



            }
            else if (islem == "-")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "+";
            }
            else if (islem == "*")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "+";
            }
            else if (islem == "/")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "+";

            }
            // yeni bitimi



            islem = "+";
            if (label1.Text == "")
            {
                label1.Text = "0";
                yazi = label1.Text;
                y = Convert.ToDouble(yazi);
                label1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                label1.Text = label1.Text + "+";

            }
            //else if (label1.Text != "0")
            //{
            //    yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
            //    y = Convert.ToDouble(yazi);
            //    label1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
            //    label1.Text = label1.Text + "+";
            //}
            else
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);

                label1.Text = label1.Text + "+";
            }

            textBox1.Text = "0";
            islem = "+";


        }

        private void button14_Click(object sender, EventArgs e)
        {
            //yeni
            if (islem == "+")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text = textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "-";
                //textBox1.Text = "0";



            }
            else if (islem == "-")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "-";
            }
            else if (islem == "*")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "-";
            }
            else if (islem == "/")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "-";

            }
            // yeni bitimi

            if (label1.Text == "")
            {



                label1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text));
                label1.Text = label1.Text + "-";

            }


            //else if (label1.Text != "0")
            //{
            //    yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
            //    y = Convert.ToDouble(yazi);
            //    label1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
            //    label1.Text = label1.Text + "-";
            //}

            else
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);

                label1.Text = label1.Text + "-";
            }
            


            islem = "-";
            textBox1.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //yeni
            if (islem == "+")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text = textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "*";
                //textBox1.Text = "0";



            }
            else if (islem == "-")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "*";
            }
            else if (islem == "*")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "*";
            }
            else if (islem == "/")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "*";

            }
            // yeni bitimi


            
            if (label1.Text == "")
            {
                label1.Text = "1";
                yazi = label1.Text;
                y = Convert.ToDouble(yazi);
                label1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
                label1.Text = label1.Text + "*";

            }
            //else if (label1.Text != "0")
            //{
            //    yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
            //    y = Convert.ToDouble(yazi);
            //    label1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
            //    label1.Text = label1.Text + "*";
            //}
            else
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);

                label1.Text = label1.Text + "*";
            }



            islem = "*";
            textBox1.Text = "0";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //yeni
            if (islem == "+")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text = textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "/";
                //textBox1.Text = "0";
                
                

            }
            else if (islem == "-")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "/";
            }
            else if (islem == "*")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "/";
            }
            else if (islem == "/")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                //label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
                label1.Text = textBox1.Text + "/";

            }
            // yeni bitimi

            
            if (label1.Text == "")
            {
                
                
                
                label1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text));
                label1.Text = label1.Text + "/";

            }
            //else if (label1.Text != "0")
            //{
                
            //    if (!(islem =="+" || islem == "-" || islem == "*" || islem == "/"))
            //    {
            //        yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
            //        y = Convert.ToDouble(yazi);
            //        label1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
            //        label1.Text = label1.Text + "/";
            //    }

                
            //}
            else
            {
                label1.Text = label1.Text.Remove(label1.Text.Length - 1, 1);
                
                label1.Text = label1.Text + "/";
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

        private void button15_Click(object sender, EventArgs e)
        {
            if (islem == "+")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y + Convert.ToDouble(textBox1.Text));
                
            }
            else if (islem == "-")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y - Convert.ToDouble(textBox1.Text));
            }
            else if (islem == "*")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                label1.Text += textBox1.Text + "=";
                textBox1.Text = Convert.ToString(y * Convert.ToDouble(textBox1.Text));
            }
            else if (islem == "/")
            {
                yazi = label1.Text.Remove(label1.Text.Length - 1, 1);
                y = Convert.ToDouble(yazi);
                label1.Text += textBox1.Text + "="; 
                textBox1.Text = Convert.ToString(y / Convert.ToDouble(textBox1.Text));
                
            }
            islem = "Shortingen Triloji Cortiii";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "0";
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
