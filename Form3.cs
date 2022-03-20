using System;
using System.Windows.Forms;
using System.Collections.Generic;

using System.IO;
using System.Runtime.Serialization.Formatters.Soap;

using IronPython.Hosting;
using Microsoft.Scripting.Hosting;

namespace Hacaton
{
    public partial class Form3 : Form
    {
        string Struct_type;

        List<Panel> pokemony = new List<Panel>();

        Dictionary<TreeNode, bool> nodeDict = new Dictionary<TreeNode, bool>();
        public Form3(string Str)
        {
            InitializeComponent();
            Struct_type = Str;
        }

        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            string FileName = Struct_type + ".txt";
            using (StreamWriter sw = File.CreateText(Application.StartupPath + @"\" + FileName))
            {
                sw.WriteLine(Struct_type);
                sw.WriteLine("%-separator-%");
                sw.WriteLine(richTextBox1.Text);
                sw.WriteLine("%-separator-%"); 
                sw.WriteLine(richTextBox2.Text);
                sw.WriteLine("%-separator-%");
            }

            TreeNode[] tempNodes = new TreeNode[treeView1.Nodes.Count];
            for (int i = 0; i < treeView1.Nodes.Count; i++)
                tempNodes[i] = treeView1.Nodes[i];
            FileStream fs = new FileStream(Struct_type + ".xml", FileMode.Create);
            SoapFormatter sf = new SoapFormatter();
            sf.Serialize(fs, tempNodes);
            fs.Close();

            Owner.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            string FileName = Struct_type+".txt";
            if (File.Exists(Application.StartupPath + @"\" + FileName))
            {
                string[] text = string.Join("\n", File.ReadAllLines(Application.StartupPath + @"\" + FileName)).Split(new string[] { "%-separator-%" }, StringSplitOptions.RemoveEmptyEntries);

                richTextBox1.Text = text[1].Trim('\r').Trim('\n');
                richTextBox2.Text = text[2].Trim('\r').Trim('\n');
            }
            else
            {
                FileStream fs = new FileStream(Application.StartupPath + @"\" + FileName, FileMode.Create);
                fs.Close();
            }

            //if (File.Exists(Application.StartupPath + @"\" + Struct_type + ".xml"))
            //{
            //    TreeNode[] tempNodes;
            //    FileStream fs = new FileStream(Struct_type + ".xml", FileMode.Open);
            //    SoapFormatter sf = new SoapFormatter();
            //    tempNodes = (TreeNode[])sf.Deserialize(fs);
            //    treeView1.Nodes.AddRange(tempNodes);
            //    fs.Close();
            //}
            //else
            //{                
            //    FileStream fs = new FileStream(Struct_type + ".xml", FileMode.Create);
            //    fs.Close();
            //}

            //if (File.Exists(Application.StartupPath + @"\" + Struct_type + "_Nodes.txt"))
            //{
            //    List<string> text = new List<string>(File.ReadAllLines(Application.StartupPath + @"\" + Struct_type + "_Nodes.txt"));

            //}
            //else
            //{
            //    FileStream fs = new FileStream(Struct_type + "_Nodes.txt", FileMode.Create);
            //    fs.Close();
            //}
        }

        private void вернутьсяВМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
                label3.Text = "Имя узла";
            else
                label3.Text = "Имя задачи";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            richTextBox3.Clear();
        }

        private void создатьУзелToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Location = new System.Drawing.Point(275,60);

            panel1.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //TreeNode n = treeView1.SelectedNode;
            //if (n == null)
            //{
            //    n = new TreeNode(richTextBox1.Text);
            //    treeView1.Nodes.Add(n);
            //    nodeDict[n] = radioButton1.Checked;
            //}
            //else
            //{
            //    //TreeNode n1 = new TreeNode(richTextBox1.Text);
            //    //Console.WriteLine(treeView1.Nodes.[treeView1.Nodes.IndexOfKey(n.Text)]);
            //    //nodeDict[n1] = radioButton1.Checked;
            //}

            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();

            Dictionary<dynamic, List<dynamic>> dish1 = new Dictionary<dynamic, List<dynamic>>();

            dish1["path"] = new List<dynamic>() { 0 };
            dish1["zadacha_parametrs"] = new List<dynamic>() { 1, 2, 4 };

            engine.ExecuteFile("tree.py", scope);
            dynamic funk = scope.GetVariable("funk");
            dynamic result = funk(dish1);

            //treeView1.Nodes.Add(new TreeNode(richTextBox3.Text));
            //button1_Click(sender, e);
        }
        bool isDown;
        System.Drawing.Point shift;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            isDown = true;
            shift.X = this.PointToClient(Control.MousePosition).X - panel1.Location.X;
            shift.Y = this.PointToClient(Control.MousePosition).Y - panel1.Location.Y;
            Console.WriteLine(shift.X);
            Console.WriteLine(shift.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {            
            if (isDown)
            {
                Control c = sender as Control;
                System.Drawing.Point p = this.PointToClient(Control.MousePosition);
                
                p.X -= shift.X; 
                p.Y -= shift.Y;
                Console.WriteLine(p.X);
                Console.WriteLine(p.Y);
                c.Location = p;
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            isDown = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            pokemony.Add(new Panel());
            int i = pokemony.Count - 1;
            pokemony[i].Parent = this;
            pokemony[i].Width = panel2.Width;
            pokemony[i].Height = panel2.Height;
            pokemony[i].Visible = true;
            pokemony[i].Left = 10;
            pokemony[i].Top = panel2.Height * i + 20;
            foreach (Control c in panel2.Controls)
            {
                pokemony[i].Controls.Add(c);
            }
            //pokemony[i].Controls.AddRange(panel2.Controls);   
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Owner.Visible = false;
        }
    }
}
