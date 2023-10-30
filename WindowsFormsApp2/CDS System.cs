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
    public partial class CDS_System : Form
    {
        public CDS_System()
        {
            InitializeComponent();
             
            SidePanel.Height = homePanel.Height;
            SidePanel.Top = homePanel.Top;
            firstUserControl11.BringToFront();
        }

        private void ResetColorAll()
        {
           //SidePanel.Visible = false;
            btn_Home.BackColor = Color.FromArgb(240, 240, 240);
            btn_Orders.BackColor = Color.FromArgb(240, 240, 240);
            btn_Pictures.BackColor = Color.FromArgb(240, 240, 240);
            btn4.BackColor = Color.FromArgb(240, 240, 240);
            btn5.BackColor = Color.FromArgb(240, 240, 240);

        }
        private void AdjustSidePanel(Panel panel, Button button)
        {
            SidePanel.Height = panel.Height;
            SidePanel.Top = panel.Top;
            button.BackColor = Color.LightGray;
        }

        private void CDS_System_Load(object sender, EventArgs e)
        {
            btn_Home.BackColor = Color.LightGray;

        }
        private void btn_Home_Click(object sender, EventArgs e)
        {
            this.ResetColorAll();
            firstUserControl11.BringToFront();
            this.AdjustSidePanel(homePanel, btn_Home);
           
        }

        private void btn_Orders_Click(object sender, EventArgs e)
        {
            this.ResetColorAll();
            buyNow1.BringToFront();
            this.AdjustSidePanel(orderspanel, btn_Orders);
        }

        private void MoveSidePanelToButtons(Button b)
        {
            Point currentPosition = SidePanel.Location;

            int btnX = b.Location.X;
            int btnY = b.Location.Y;

            SidePanel.Location = new Point(btnX, btnY);

        }

        private void btn_Chat_Click(object sender, EventArgs e)
        {
            this.ResetColorAll();
            imageSlideshow1.BringToFront();
            this.AdjustSidePanel(picPanel, btn_Pictures);
        }
    }
}
