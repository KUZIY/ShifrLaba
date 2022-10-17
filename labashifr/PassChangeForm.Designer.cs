namespace labashifr
{
    partial class PassChangeForm
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
            this.TopMainLabel = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.PassChangeButton = new System.Windows.Forms.Button();
            this.NewPass1Box = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OldPassBox = new System.Windows.Forms.TextBox();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopMainLabel
            // 
            this.TopMainLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopMainLabel.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopMainLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.TopMainLabel.Location = new System.Drawing.Point(0, 0);
            this.TopMainLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopMainLabel.Name = "TopMainLabel";
            this.TopMainLabel.Size = new System.Drawing.Size(500, 134);
            this.TopMainLabel.TabIndex = 0;
            this.TopMainLabel.Text = "Смена пароля";
            this.TopMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopMainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMainLabel_MouseDown);
            this.TopMainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopMainLabel_MouseMove);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(71)))), ((int)(((byte)(61)))));
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.OldPassBox);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.NewPassBox);
            this.MainPanel.Controls.Add(this.BackButton);
            this.MainPanel.Controls.Add(this.PassChangeButton);
            this.MainPanel.Controls.Add(this.NewPass1Box);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.SystemColors.Info;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(500, 554);
            this.MainPanel.TabIndex = 1;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(7, 367);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(226, 38);
            this.label2.TabIndex = 10;
            this.label2.Text = "Подтверждение";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(7, 260);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 38);
            this.label1.TabIndex = 9;
            this.label1.Text = "Новый пароль";
            // 
            // NewPassBox
            // 
            this.NewPassBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPassBox.Location = new System.Drawing.Point(14, 302);
            this.NewPassBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.Size = new System.Drawing.Size(451, 61);
            this.NewPassBox.TabIndex = 8;
            this.NewPassBox.UseSystemPasswordChar = true;
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(14, 489);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(153, 52);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Вернуться";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // PassChangeButton
            // 
            this.PassChangeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.PassChangeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PassChangeButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.PassChangeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PassChangeButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PassChangeButton.Location = new System.Drawing.Point(224, 489);
            this.PassChangeButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PassChangeButton.Name = "PassChangeButton";
            this.PassChangeButton.Size = new System.Drawing.Size(240, 52);
            this.PassChangeButton.TabIndex = 5;
            this.PassChangeButton.Text = "Сменить пароль";
            this.PassChangeButton.UseVisualStyleBackColor = false;
            this.PassChangeButton.Click += new System.EventHandler(this.PassChangeButton_Click);
            // 
            // NewPass1Box
            // 
            this.NewPass1Box.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewPass1Box.Location = new System.Drawing.Point(14, 409);
            this.NewPass1Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NewPass1Box.Name = "NewPass1Box";
            this.NewPass1Box.Size = new System.Drawing.Size(451, 61);
            this.NewPass1Box.TabIndex = 4;
            this.NewPass1Box.UseSystemPasswordChar = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(34)))), ((int)(((byte)(12)))));
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.TopMainLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(500, 134);
            this.panel2.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(47)))), ((int)(((byte)(17)))));
            this.ExitButton.Location = new System.Drawing.Point(459, 0);
            this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(37, 36);
            this.ExitButton.TabIndex = 1;
            this.ExitButton.Text = "X";
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseEnter += new System.EventHandler(this.ExitButton_MouseEnter);
            this.ExitButton.MouseLeave += new System.EventHandler(this.ExitButton_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 153);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 38);
            this.label3.TabIndex = 12;
            this.label3.Text = "Старый пароль";
            // 
            // OldPassBox
            // 
            this.OldPassBox.Font = new System.Drawing.Font("Times New Roman", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OldPassBox.Location = new System.Drawing.Point(14, 195);
            this.OldPassBox.Margin = new System.Windows.Forms.Padding(4);
            this.OldPassBox.Name = "OldPassBox";
            this.OldPassBox.Size = new System.Drawing.Size(451, 61);
            this.OldPassBox.TabIndex = 11;
            this.OldPassBox.UseSystemPasswordChar = true;
            // 
            // PassChangeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 554);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PassChangeForm";
            this.Text = "PassChangeForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TopMainLabel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button PassChangeButton;
        private System.Windows.Forms.TextBox NewPass1Box;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OldPassBox;
    }
}