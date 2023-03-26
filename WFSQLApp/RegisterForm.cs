using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFSQLApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.ForeColor = Color.White;
        }

    }
}
