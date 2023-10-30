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
    public partial class ImageSlideshow : UserControl
    {
        public ImageSlideshow()
        {
            InitializeComponent();
        }
        private int count = 0;

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
      
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void imageTimer_Tick(object sender, EventArgs e)
        {
            count = (count + 1) % imageList1.Images.Count;
            label2.Text = count.ToString();
            pictureBox1.Image = imageList1.Images[count];
        }

        private void btn_Next2_Click(object sender, EventArgs e)
        {
            count = (count + 1) % imageList1.Images.Count;
            label2.Text = count.ToString();
            pictureBox1.Image = imageList1.Images[count];
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            count = (count - 1 + imageList1.Images.Count) % imageList1.Images.Count;
            label2.Text = count.ToString();
            pictureBox1.Image = imageList1.Images[count];
        }
    }
}
