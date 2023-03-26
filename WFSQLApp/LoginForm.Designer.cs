namespace WFSQLApp
{
    partial class LoginForm
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
            this.MainPanal = new System.Windows.Forms.Panel();
            this.passField = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Label();
            this.Autorisation = new System.Windows.Forms.Label();
            this.LoginBut = new System.Windows.Forms.Button();
            this.MainPanal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanal
            // 
            this.MainPanal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(49)))), ((int)(((byte)(84)))));
            this.MainPanal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MainPanal.Controls.Add(this.passField);
            this.MainPanal.Controls.Add(this.textBox2);
            this.MainPanal.Controls.Add(this.pictureBox2);
            this.MainPanal.Controls.Add(this.loginField);
            this.MainPanal.Controls.Add(this.pictureBox1);
            this.MainPanal.Controls.Add(this.panel2);
            this.MainPanal.Controls.Add(this.LoginBut);
            this.MainPanal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanal.Location = new System.Drawing.Point(0, 0);
            this.MainPanal.Margin = new System.Windows.Forms.Padding(2);
            this.MainPanal.Name = "MainPanal";
            this.MainPanal.Size = new System.Drawing.Size(343, 427);
            this.MainPanal.TabIndex = 0;
            this.MainPanal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanal_MouseDown);
            this.MainPanal.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanal_MouseMove);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.passField.Location = new System.Drawing.Point(80, 198);
            this.passField.Name = "passField";
            this.passField.Size = new System.Drawing.Size(247, 53);
            this.passField.TabIndex = 4;
            this.passField.UseSystemPasswordChar = true;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.textBox2.Location = new System.Drawing.Point(80, 198);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(247, 64);
            this.textBox2.TabIndex = 4;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::WFSQLApp.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(10, 198);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.loginField.Location = new System.Drawing.Point(80, 99);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(247, 64);
            this.loginField.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFSQLApp.Properties.Resources.man;
            this.pictureBox1.Location = new System.Drawing.Point(10, 99);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
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
            this.panel2.Size = new System.Drawing.Size(339, 73);
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
            this.closeButton.Location = new System.Drawing.Point(306, 7);
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
            this.Autorisation.Size = new System.Drawing.Size(339, 73);
            this.Autorisation.TabIndex = 0;
            this.Autorisation.Text = "Autorisation";
            this.Autorisation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Autorisation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Autorisation_MouseDown);
            this.Autorisation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Autorisation_MouseMove);
            // 
            // LoginBut
            // 
            this.LoginBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(19)))), ((int)(((byte)(12)))));
            this.LoginBut.FlatAppearance.BorderSize = 0;
            this.LoginBut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.LoginBut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.LoginBut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.LoginBut.Font = new System.Drawing.Font("Broadway", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.LoginBut.ForeColor = System.Drawing.Color.Firebrick;
            this.LoginBut.Location = new System.Drawing.Point(10, 332);
            this.LoginBut.Name = "LoginBut";
            this.LoginBut.Size = new System.Drawing.Size(317, 64);
            this.LoginBut.TabIndex = 5;
            this.LoginBut.Text = "Login";
            this.LoginBut.UseVisualStyleBackColor = false;
            this.LoginBut.Click += new System.EventHandler(this.LoginBut_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 427);
            this.Controls.Add(this.MainPanal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.MainPanal.ResumeLayout(false);
            this.MainPanal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Autorisation;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button LoginBut;
        private System.Windows.Forms.TextBox passField;
    }
}