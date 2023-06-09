﻿using MySql.Data.MySqlClient;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 64);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            this.closeButton.ForeColor = Color.Red;
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            this.closeButton.ForeColor = Color.White;
        }

        Point lastPoint;
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

        private void LoginBut_Click(object sender, EventArgs e)
        {
            String LoginUser = loginField.Text;
            String PassUser = passField.Text;

            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @uL AND `pass` = @uP", db.getConnection());

            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginUser;
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = PassUser;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                this.Hide();
                MainForm MainForm = new MainForm();
                MainForm.Show();
                MessageBox.Show("Yes Autorisation");
            }
            else
            {
                MessageBox.Show("NOOOO!");

            }
        }

        private void linkRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
        }
    }
}
