using MySql.Data.MySqlClient;
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


            Login.Text = "Login";
            name.Text = "FirstName";
            surname.Text = "LastName";
            if (Login.Text.Length < 0)
                Login.ForeColor = Color.Black;
            if (name.Text.Length < 0)
                name.ForeColor = Color.Black;
            if (surname.Text.Length < 0)
                surname.ForeColor = Color.Black;

        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        Point lastPoint;
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.ForeColor = Color.White;
        }

        private void MainPanal_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void MainPanal_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void Autorisation_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Autorisation_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e)
        {
            if (Login.Text == "Login")
                Login.Text = "";
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (Login.Text == "")
            {
                Login.Text = "Login";
                Login.ForeColor = Color.Gray;
            }
        }

        private void userNameFieldTwo_Enter(object sender, EventArgs e)
        {
            if (name.Text == "FirstName")
                name.Text = "";
        }

        private void userNameFieldTwo_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "FirstName";
                name.ForeColor = Color.Gray;
            }
        }
        private void surname_Enter(object sender, EventArgs e)
        {
            if (surname.Text == "LastName")
                surname.Text = "";
        }

        private void surname_Leave(object sender, EventArgs e)
        {
            if (surname.Text == "")
            {
                surname.Text = "LastName";
                surname.ForeColor = Color.Gray;

            }
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (name.Text == "FirstName")
            {
                MessageBox.Show("write a FirstName");
                return;
            }

            if (surname.Text == "LastName")
            {
                MessageBox.Show("write a LastName");
                return;
            }

            if (isUserExist())
                return;

            DB db = new DB();
            MySqlCommand command;
            command = new MySqlCommand("INSERT INTO `users` (`id` ,`login`, `pass`, `name`, `surname`) VALUES (NULL, @login, @pass, @name, @surname)", db.getConnection());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login.Text;
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = password.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = surname.Text;

            db.openConection();

            if (command.ExecuteNonQuery() == 1)
                MessageBox.Show($"Welcome dear: {name.Text}");
            else
                MessageBox.Show("Somthing was wrong");

            db.closeConection();


        }

        public Boolean isUserExist()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = name.Text;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = password.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Login was be created before");
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
