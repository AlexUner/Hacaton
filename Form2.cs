using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.IO;

namespace Hacaton
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owner.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {
                Form1 form = (Form1)Owner;
                form.listBox = textBox1.Text;

                Dictionary<string, List<string>> dish = new Dictionary<string, List<string>>();
                List<string> par = new List<string>(){ richTextBox1.Text, richTextBox2.Text };
                dish.Add(textBox1.Text, par);

                string FileName = textBox1.Text+".txt";
                using (StreamWriter sw = File.CreateText(Application.StartupPath + @"\" + FileName))
                {
                    foreach(var k in dish)
                    {
                        sw.WriteLine(k.Key);
                        sw.WriteLine("%-separator-%");
                        foreach (var s in dish[k.Key])
                        {
                            sw.WriteLine(s);
                            sw.WriteLine("%-separator-%");
                        }
                    }
                }
            }
            Close();
        }
    }
}
