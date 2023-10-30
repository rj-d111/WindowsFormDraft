using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class respForm : Form
    {
        public respForm()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void respForm_Load(object sender, EventArgs e)
        {
            label3.Text = DateTime.Now.ToString("MMMM dd, yyyy");
        }
    }
}
