using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab2q1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Open";
            ofd.Filter="Text Document(*.txt)*|.txt|All Files(*.*)|*.*";
            ofd.ShowDialog();
            textbox.LoadFile(ofd.FileName);
            String fname = ofd.FileName;
            StreamReader sr = new StreamReader(fname);
            textbox.Text = sr.ReadToEnd();
            sr.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog1.ShowDialog();
            String fname=SaveFileDialog1.FileName;
            StreamWriter sw-new StreamWriter(fname);
            sw.Write(textbox.Text);
            sw.Flush();
            sw.Close();

 
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.Undo();  
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.Copy();
            change_Pest();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textbox.Paste();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.Font = textbox.SelectionFont();
            fd.Color = textbox.SelectionColor();
            if (fd.ShowDialog() == DialogResult.OK)
            {
                textbox.SelectionFont = fd.Font;
                textbox.SelectionColor = fd.Color;
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog fd = new ColorDialog();
            fd.Color=textbox.selectionColor;
            if(fd.ShowDialog()==DialogResult.OK)
            textbox.SelectionColor=fd.color;

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }  
    }
}
