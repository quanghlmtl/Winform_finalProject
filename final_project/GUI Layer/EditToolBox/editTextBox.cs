using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI_Layer.EditToolBox
{
    public partial class editTextBox : UserControl
    {
        public editTextBox()
        {
            InitializeComponent();
        }
        [Category("Custom Advance")]
        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }
    }
}
