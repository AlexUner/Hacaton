﻿
namespace Hacaton
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Выработка в час");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Снижение багов 20%");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Повышение производительности", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Производство", new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.общиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьясВМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.общиеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вернутьсяВМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.управлениеУзламиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьУзелToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьВыделенныйToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.соединитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.разъеденитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общиеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(3, 3);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(786, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // общиеToolStripMenuItem
            // 
            this.общиеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьясВМенюToolStripMenuItem});
            this.общиеToolStripMenuItem.Name = "общиеToolStripMenuItem";
            this.общиеToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.общиеToolStripMenuItem.Text = "Общие";
            // 
            // вернутьясВМенюToolStripMenuItem
            // 
            this.вернутьясВМенюToolStripMenuItem.Name = "вернутьясВМенюToolStripMenuItem";
            this.вернутьясВМенюToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.вернутьясВМенюToolStripMenuItem.Text = "Вернутьяс в меню";
            this.вернутьясВМенюToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяВМенюToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.menuStrip1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Формулировка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(19, 247);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox2.Size = new System.Drawing.Size(750, 157);
            this.richTextBox2.TabIndex = 5;
            this.richTextBox2.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 231);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Видение проекта";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Миссия проекта";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(19, 55);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox1.Size = new System.Drawing.Size(750, 157);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Controls.Add(this.menuStrip2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Дерево целей";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 27);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node8";
            treeNode1.Text = "Выработка в час";
            treeNode2.Name = "Node11";
            treeNode2.Text = "Снижение багов 20%";
            treeNode3.Name = "Node7";
            treeNode3.Text = "Повышение производительности";
            treeNode4.Name = "Node6";
            treeNode4.Text = "Производство";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4});
            this.treeView1.Size = new System.Drawing.Size(786, 394);
            this.treeView1.TabIndex = 1;
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.общиеToolStripMenuItem1,
            this.управлениеУзламиToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(786, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // общиеToolStripMenuItem1
            // 
            this.общиеToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вернутьсяВМенюToolStripMenuItem});
            this.общиеToolStripMenuItem1.Name = "общиеToolStripMenuItem1";
            this.общиеToolStripMenuItem1.Size = new System.Drawing.Size(59, 20);
            this.общиеToolStripMenuItem1.Text = "Общие";
            // 
            // вернутьсяВМенюToolStripMenuItem
            // 
            this.вернутьсяВМенюToolStripMenuItem.Name = "вернутьсяВМенюToolStripMenuItem";
            this.вернутьсяВМенюToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.вернутьсяВМенюToolStripMenuItem.Text = "Вернуться в меню";
            this.вернутьсяВМенюToolStripMenuItem.Click += new System.EventHandler(this.вернутьсяВМенюToolStripMenuItem_Click);
            // 
            // управлениеУзламиToolStripMenuItem
            // 
            this.управлениеУзламиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьУзелToolStripMenuItem,
            this.удалитьВыделенныйToolStripMenuItem,
            this.соединитьToolStripMenuItem,
            this.разъеденитьToolStripMenuItem});
            this.управлениеУзламиToolStripMenuItem.Name = "управлениеУзламиToolStripMenuItem";
            this.управлениеУзламиToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.управлениеУзламиToolStripMenuItem.Text = " Управление узлами";
            // 
            // создатьУзелToolStripMenuItem
            // 
            this.создатьУзелToolStripMenuItem.Name = "создатьУзелToolStripMenuItem";
            this.создатьУзелToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.создатьУзелToolStripMenuItem.Text = "Создать узел";
            this.создатьУзелToolStripMenuItem.Click += new System.EventHandler(this.создатьУзелToolStripMenuItem_Click);
            // 
            // удалитьВыделенныйToolStripMenuItem
            // 
            this.удалитьВыделенныйToolStripMenuItem.Name = "удалитьВыделенныйToolStripMenuItem";
            this.удалитьВыделенныйToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.удалитьВыделенныйToolStripMenuItem.Text = "Удалить выделенный";
            // 
            // соединитьToolStripMenuItem
            // 
            this.соединитьToolStripMenuItem.Name = "соединитьToolStripMenuItem";
            this.соединитьToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.соединитьToolStripMenuItem.Text = "Соединить";
            // 
            // разъеденитьToolStripMenuItem
            // 
            this.разъеденитьToolStripMenuItem.Name = "разъеденитьToolStripMenuItem";
            this.разъеденитьToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.разъеденитьToolStripMenuItem.Text = "Разъеденить";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.richTextBox3);
            this.panel1.Location = new System.Drawing.Point(275, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 130);
            this.panel1.TabIndex = 2;
            this.panel1.Visible = false;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(3, 26);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(192, 34);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Имя узла";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(102, 66);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.Text = "Задача";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(45, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Узел";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Location = new System.Drawing.Point(3, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 10;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button2.Location = new System.Drawing.Point(102, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 33);
            this.button2.TabIndex = 11;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metrix - ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form3_FormClosed);
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem общиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вернутьясВМенюToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem общиеToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вернутьсяВМенюToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripMenuItem управлениеУзламиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьУзелToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьВыделенныйToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem соединитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem разъеденитьToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}