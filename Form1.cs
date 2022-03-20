using System;
using System.Collections.Generic;
using System.Windows.Forms;

using System.IO;

//using IronPython.Hosting;
//using Microsoft.Scripting.Hosting;

namespace Hacaton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Owner = this;
            newForm.Show();
            Hide();
        }

        public string listBox
        {
            get { return listBox1.Items[0].ToString(); }
            set { listBox1.Items.Add(value); }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Dictionary<string, double> dish1, dish2;
            //List<string> list1;

            //dish1 = new Dictionary<string, double>() { { "x", 30 }, { "y", 10 }, { "z", 15 } };
            //dish2 = new Dictionary<string, double>() { { "x", 5 }, { "y", 4 }, { "z", 7 } };
            //list1 = new List<string>() { "( x-1 + y-2 * z-1 ) * x-1", "x-1 * x-1 + x-2 - z-2", "y-1 + z-2 * x-1 + 5" };

            //ScriptEngine engine = Python.CreateEngine();
            //ScriptScope scope = engine.CreateScope();

            //engine.ExecuteFile("get_result_formules.py", scope);
            //dynamic funk = scope.GetVariable("get_result_formules");
            //dynamic result = funk(dish1, dish2, list1);
            //var dList = new List<dynamic>(result);
            //foreach (double l in dList)
            //{
            //    listBox1.Items.Add(l);
            //}

            Form3 newForm = new Form3(listBox1.SelectedItem.ToString());
            newForm.Owner = this;
            newForm.Text += listBox1.SelectedItem;
            newForm.Show();
            Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string FileName = "StartUpForm.txt";
            if (File.Exists(Application.StartupPath + @"\" + FileName))
            {
                List<string> text = new List<string>(File.ReadAllLines(Application.StartupPath + @"\" + FileName));
                foreach (string str in text)
                    listBox1.Items.Add(str);
            }
            else
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\" + FileName, FileMode.Create);
                fs.Close();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string FileName = "StartUpForm.txt";
            using (StreamWriter sw = File.CreateText(Application.StartupPath + @"\" + FileName))
            {
                foreach(string str in listBox1.Items)
                sw.WriteLine(str);
            }
        }
    }
}
