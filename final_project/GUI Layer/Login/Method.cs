using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Layer.Login
{
    public partial class Method : Form
    {
        public Method()
        {
            InitializeComponent();
        }
        protected void HandleMouesUpActions(object sender, MouseEventArgs e, Guna2TextBox txt, string placeholderText)
        {
            if (txt.Text == placeholderText)
                return;

            if (e.Button == MouseButtons.Left)
            {
                Control hidden = (Control)sender;
                txt.UseSystemPasswordChar = true;
                hidden.BringToFront();
            }
        }
        //Mouse down
        protected void HandleMouseDownActions(object sender, MouseEventArgs e, Guna2TextBox txt, string placeholderText)
        {
            if (txt.Text == placeholderText)
                return;
            if (e.Button == MouseButtons.Left)
            {
                Control hidden = (Control)sender;
                hidden.SendToBack();
                txt.UseSystemPasswordChar = false;
            }
        }
        protected bool CheckNullOrWhiteSpace(Guna2TextBox txt, Label lb, string value1)
        {
            if (string.IsNullOrWhiteSpace(txt.Text))
            {
                lb.Visible = true;
                lb.Text = "* Please enter " + value1;
                txt.Focus();
                return true;
            }
            else return false;
        }
    }
}
