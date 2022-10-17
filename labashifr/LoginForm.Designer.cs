namespace labashifr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.LoginButton = new System.Windows.Forms.Button();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.TopMainLabel = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(71)))), ((int)(((byte)(61)))));
            this.MainPanel.Controls.Add(this.LoginButton);
            this.MainPanel.Controls.Add(this.PasswordBox);
            this.MainPanel.Controls.Add(this.LoginBox);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.SystemColors.Info;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(375, 423);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginButton.Location = new System.Drawing.Point(240, 369);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(98, 42);
            this.LoginButton.TabIndex = 5;
            this.LoginButton.Text = "Войти";
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // PasswordBox
            // 
            this.PasswordBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordBox.Location = new System.Drawing.Point(82, 266);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.Size = new System.Drawing.Size(256, 50);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(82, 161);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(256, 64);
            this.LoginBox.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 266);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 161);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(34)))), ((int)(((byte)(12)))));
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.TopMainLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(375, 109);
            this.panel2.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(47)))), ((int)(((byte)(17)))));
            this.ExitButton.Location = new System.Drawing.Point(344, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(31, 29);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // TopMainLabel
            // 
            this.TopMainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopMainLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopMainLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.TopMainLabel.Location = new System.Drawing.Point(0, 0);
            this.TopMainLabel.Name = "TopMainLabel";
            this.TopMainLabel.Size = new System.Drawing.Size(375, 109);
            this.TopMainLabel.TabIndex = 0;
            this.TopMainLabel.Text = "Авторизация";
            this.TopMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopMainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMainLabel_MouseDown);
            this.TopMainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopMainLabel_MouseMove);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 423);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label TopMainLabel;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button LoginButton;
    }
}