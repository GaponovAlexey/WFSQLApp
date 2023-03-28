namespace WFSQLApp
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Autorisation = new System.Windows.Forms.Label();
            this.MainPanal = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.password = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.TextBox();
            this.surname = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.linkToLogin = new System.Windows.Forms.Label();
            this.MainPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Autorisation
            // 
            this.Autorisation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(12)))));
            this.Autorisation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Autorisation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Autorisation.Font = new System.Drawing.Font("Broadway", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Autorisation.ForeColor = System.Drawing.Color.Firebrick;
            this.Autorisation.Location = new System.Drawing.Point(0, 0);
            this.Autorisation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Autorisation.Name = "Autorisation";
            this.Autorisation.Size = new System.Drawing.Size(375, 73);
            this.Autorisation.TabIndex = 0;
            this.Autorisation.Text = "Registration";
            this.Autorisation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Autorisation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Autorisation_MouseDown);
            this.Autorisation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Autorisation_MouseMove);
            // 
            // MainPanal
            // 
            this.MainPanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.MainPanal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanal.Controls.Add(this.linkToLogin);
            this.MainPanal.Controls.Add(this.pictureBox3);
            this.MainPanal.Controls.Add(this.pictureBox2);
            this.MainPanal.Controls.Add(this.pictureBox1);
            this.MainPanal.Controls.Add(this.password);
            this.MainPanal.Controls.Add(this.textBox3);
            this.MainPanal.Controls.Add(this.pictureBox4);
            this.MainPanal.Controls.Add(this.name);
            this.MainPanal.Controls.Add(this.surname);
            this.MainPanal.Controls.Add(this.Login);
            this.MainPanal.Controls.Add(this.panel2);
            this.MainPanal.Controls.Add(this.registerButton);
            this.MainPanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanal.Location = new System.Drawing.Point(0, 0);
            this.MainPanal.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanal.Name = "MainPanal";
            this.MainPanal.Size = new System.Drawing.Size(379, 646);
            this.MainPanal.TabIndex = 1;
            this.MainPanal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanal_MouseDown);
            this.MainPanal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanal_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::WFSQLApp.Properties.Resources.man;
            this.pictureBox3.Location = new System.Drawing.Point(10, 275);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WFSQLApp.Properties.Resources.man;
            this.pictureBox2.Location = new System.Drawing.Point(10, 187);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFSQLApp.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(10, 106);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // password
            // 
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.password.Location = new System.Drawing.Point(97, 411);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(247, 53);
            this.password.TabIndex = 4;
            this.password.UseSystemPasswordChar = true;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox3.Location = new System.Drawing.Point(97, 411);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(247, 64);
            this.textBox3.TabIndex = 9;
            this.textBox3.UseSystemPasswordChar = true;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::WFSQLApp.Properties.Resources._lock;
            this.pictureBox4.Location = new System.Drawing.Point(10, 411);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 64);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.name.Location = new System.Drawing.Point(97, 187);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(247, 64);
            this.name.TabIndex = 2;
            this.name.Enter += new System.EventHandler(this.userNameFieldTwo_Enter);
            this.name.Leave += new System.EventHandler(this.userNameFieldTwo_Leave);
            // 
            // surname
            // 
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.surname.Location = new System.Drawing.Point(97, 275);
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(247, 64);
            this.surname.TabIndex = 3;
            this.surname.UseSystemPasswordChar = true;
            this.surname.Enter += new System.EventHandler(this.surname_Enter);
            this.surname.Leave += new System.EventHandler(this.surname_Leave);
            // 
            // Login
            // 
            this.Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.Login.Location = new System.Drawing.Point(97, 106);
            this.Login.Multiline = true;
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(247, 64);
            this.Login.TabIndex = 1;
            this.Login.Enter += new System.EventHandler(this.userNameField_Enter);
            this.Login.Leave += new System.EventHandler(this.userNameField_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(49)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.Autorisation);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 73);
            this.panel2.TabIndex = 0;
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(12)))));
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(342, 7);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(26, 25);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.closeButton.UseMnemonic = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            this.closeButton.MouseEnter += new System.EventHandler(this.closeButton_MouseEnter);
            this.closeButton.MouseLeave += new System.EventHandler(this.closeButton_MouseLeave);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(12)))));
            this.registerButton.FlatAppearance.BorderSize = 0;
            this.registerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.registerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.registerButton.Font = new System.Drawing.Font("Broadway", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.registerButton.ForeColor = System.Drawing.Color.Firebrick;
            this.registerButton.Location = new System.Drawing.Point(27, 542);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(317, 64);
            this.registerButton.TabIndex = 5;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // linkToLogin
            // 
            this.linkToLogin.AutoSize = true;
            this.linkToLogin.Font = new System.Drawing.Font("Broadway", 11F);
            this.linkToLogin.ForeColor = System.Drawing.Color.Snow;
            this.linkToLogin.Location = new System.Drawing.Point(164, 618);
            this.linkToLogin.Name = "linkToLogin";
            this.linkToLogin.Size = new System.Drawing.Size(63, 17);
            this.linkToLogin.TabIndex = 14;
            this.linkToLogin.Text = "Sign In";
            this.linkToLogin.Click += new System.EventHandler(this.linkToLogin_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 646);
            this.Controls.Add(this.MainPanal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.MainPanal.ResumeLayout(false);
            this.MainPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Autorisation;
        private System.Windows.Forms.Panel MainPanal;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label linkToLogin;
    }
}