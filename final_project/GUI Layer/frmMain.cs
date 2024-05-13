using GUI_Layer.Home;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Layer
{
    public partial class frmMain : Form
    {
        private ucHome home;
        public frmMain()
        {
            InitializeComponent();
            home = new ucHome();
            home.Dock = DockStyle.Fill;
            pnMain.Controls.Add(home);
            home.BringToFront();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(home) == false)
            {
                home = new ucHome();
                home.Dock = DockStyle.Fill;
                pnMain.Controls.Add(home);
                home.BringToFront();
            }

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(home) == false)
            {
                home = new ucHome();
                home.Dock = DockStyle.Fill;
                pnMain.Controls.Add(home);
                home.BringToFront();
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(home) == false)
            {
                home = new ucHome();
                home.Dock = DockStyle.Fill;
                pnMain.Controls.Add(home);
                home.BringToFront();
            }
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(home) == false)
            {
                home = new ucHome();
                home.Dock = DockStyle.Fill;
                pnMain.Controls.Add(home);
                home.BringToFront();
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            if (pnMain.Controls.Contains(home) == false)
            {
                home = new ucHome();
                home.Dock = DockStyle.Fill;
                pnMain.Controls.Add(home);
                home.BringToFront();
            }
        }
    }
}
