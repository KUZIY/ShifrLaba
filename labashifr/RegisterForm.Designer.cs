namespace labashifr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.TopMainLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LoginBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMainLabel
            // 
            this.TopMainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopMainLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopMainLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.TopMainLabel.Location = new System.Drawing.Point(0, 0);
            this.TopMainLabel.Name = "TopMainLabel";
            this.TopMainLabel.Size = new System.Drawing.Size(373, 109);
            this.TopMainLabel.TabIndex = 0;
            this.TopMainLabel.Text = " Регистрация";
            this.TopMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopMainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMainLabel_MouseDown);
            this.TopMainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopMainLabel_MouseMove);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(71)))), ((int)(((byte)(61)))));
            this.MainPanel.Controls.Add(this.BackButton);
            this.MainPanel.Controls.Add(this.RegisterButton);
            this.MainPanel.Controls.Add(this.LoginBox);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.SystemColors.Info;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(373, 327);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RegisterButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RegisterButton.Location = new System.Drawing.Point(165, 273);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(184, 42);
            this.RegisterButton.TabIndex = 5;
            this.RegisterButton.Text = "Зарегистрировать";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LoginBox
            // 
            this.LoginBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginBox.Location = new System.Drawing.Point(82, 161);
            this.LoginBox.Multiline = true;
            this.LoginBox.Name = "LoginBox";
            this.LoginBox.Size = new System.Drawing.Size(267, 64);
            this.LoginBox.TabIndex = 3;
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
            this.panel2.Size = new System.Drawing.Size(373, 109);
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
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 273);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(115, 42);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Вернуться";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 327);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TopMainLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.TextBox LoginBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Button BackButton;
    }
}