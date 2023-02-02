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

namespace Fle_Read_Wrte_Append
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr;
            int fileChar;
            txt_read.Text = String.Empty;

           sr = File.OpenText("C:\\Users\\labuser\\Documents\\" + tb_fileName.Text + ".txt");

            while((fileChar = sr.Read()) !=-1)
            {
                txt_read.Text += Convert.ToChar(fileChar);
                
            }
            sr.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               // Console.WriteLine("File NAme");
                FileInfo fo = new FileInfo("C:\\Users\\labuser\\Documents\\" + tb_fileName.Text + ".txt");
                StreamWriter sw = fo.CreateText();
                sw.WriteLine(txt_write.Text);
                txt_write.Text = String.Empty;
                sw.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
               //FileStream fs = new FileStream("C:\\Users\\labuser\\Documents\\" + tb_fileName.Text + ".txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                StreamWriter sr = File.AppendText("C:\\Users\\labuser\\Documents\\" + tb_fileName.Text + ".txt");

                sr.WriteLine(txt_Append.Text);
                txt_Append.Text = string.Empty;
                sr.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            


        }
    }
}
