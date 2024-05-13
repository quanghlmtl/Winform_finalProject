using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GUI_Layer.Login
{
    public partial class frmLogin : Method
    {
        public frmLogin()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar = true;
        }
        //sql
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            if (CheckNullOrWhiteSpace(txtUser, lblMess, "username")) return;
            else if (CheckNullOrWhiteSpace(txtPassword, lblMess, "password")) return;
            string connString = "Data Source=.;Initial Catalog=QLKho;Integrated Security=True";
            SqlConnection connect = null;
            try
            {
                //ket noi csdl
                connect = new SqlConnection(connString);
                connect.Open();
                //Xử lý truy van
                #region Xu ly du lieu
                string sql = "select * from login where username like '" + txtUser.Text + "' and password like '" + txtPassword.Text + "' and status = 1";
                SqlCommand command = new SqlCommand();
                command.Connection = connect;
                command.CommandText = sql;
                command.CommandType = CommandType.Text;
                object data = command.ExecuteScalar();

                if (data == null)
                {
                    this.lblMess.Text = "* Incorrect username or password. \n" +
                                        "  Please try again!";
                    this.lblMess.Visible = true;
                }
                else
                {
                   frmMain frm = new frmMain();
                    frm.Show();
                    this.Hide();
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connection: " + ex.Message);
            }
            finally
            {
                connect.Close();
            }
        }

        //event
        private void hidden_MouseDown(object sender, MouseEventArgs e)
        {
            HandleMouseDownActions(sender, e, txtPassword, "ex: TheLight@26122003!");
        }

        private void hidden_MouseUp(object sender, MouseEventArgs e)
        {
            HandleMouesUpActions(sender, e, txtPassword, "ex: TheLight@26122003!");
        }      
    }
}
