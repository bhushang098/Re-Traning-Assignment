using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fle_Create_Copy_Delete
{
    public partial class FleMenuForm : Form
    {
        public FleMenuForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Create File
            File.CreateText("C:\\Users\\labuser\\Documents\\" + tb_createFile.Text + ".txt");
        }

        private void btn_Copy_Click(object sender, EventArgs e)
        {
            File.Copy("C:\\Users\\labuser\\Documents\\" + tb_createFile.Text + ".txt", "C:\\Users\\labuser\\Documents\\" + tb_CopyFile.Text + ".txt");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            File.Delete("C:\\Users\\labuser\\Documents\\" + tb_Delete.Text + ".txt");
        
        }
    }
}
