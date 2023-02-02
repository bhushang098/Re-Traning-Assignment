using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Greetng_Form_HelloWorld
{
    public partial class frmGreeting : Form
    {
        public frmGreeting()
        {
            InitializeComponent();
        }

        private void btn_hi_Click(object sender, EventArgs e)
        {
            Control c = sender as Control;
            MessageBox.Show("Hii..."+tb_name.Text+ "You clicked" + c.Name);
        }

        private void btn_hello_Click(object sender, EventArgs e)
        {
            Control c = (Control) sender;

            MessageBox.Show("Hellow..." + tb_name.Text+"You Clicked"+c.Name);
        }
    }
}
