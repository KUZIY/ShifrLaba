namespace labashifr
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.BackButton = new System.Windows.Forms.Button();
            this.PassChangeButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExitButton = new System.Windows.Forms.Label();
            this.TopMainLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NewUserButton = new System.Windows.Forms.Button();
            this.AboutProgrammButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.LoginColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlockColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.LimitColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RefreshButton = new System.Windows.Forms.Button();
            this.MainPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(71)))), ((int)(((byte)(61)))));
            this.MainPanel.Controls.Add(this.RefreshButton);
            this.MainPanel.Controls.Add(this.SaveButton);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.AboutProgrammButton);
            this.MainPanel.Controls.Add(this.NewUserButton);
            this.MainPanel.Controls.Add(this.dataGridView1);
            this.MainPanel.Controls.Add(this.BackButton);
            this.MainPanel.Controls.Add(this.PassChangeButton);
            this.MainPanel.Controls.Add(this.panel2);
            this.MainPanel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.ForeColor = System.Drawing.SystemColors.Info;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseDown);
            this.MainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPanel_MouseMove);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BackButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BackButton.Location = new System.Drawing.Point(12, 399);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(143, 39);
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
            this.PassChangeButton.Location = new System.Drawing.Point(12, 309);
            this.PassChangeButton.Name = "PassChangeButton";
            this.PassChangeButton.Size = new System.Drawing.Size(265, 39);
            this.PassChangeButton.TabIndex = 5;
            this.PassChangeButton.Text = "Сменить пароль";
            this.PassChangeButton.UseVisualStyleBackColor = false;
            this.PassChangeButton.Click += new System.EventHandler(this.PassChangeButton_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(34)))), ((int)(((byte)(12)))));
            this.panel2.Controls.Add(this.ExitButton);
            this.panel2.Controls.Add(this.TopMainLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 73);
            this.panel2.TabIndex = 0;
            // 
            // ExitButton
            // 
            this.ExitButton.AutoSize = true;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(47)))), ((int)(((byte)(17)))));
            this.ExitButton.Location = new System.Drawing.Point(769, 0);
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
            this.TopMainLabel.Size = new System.Drawing.Size(800, 73);
            this.TopMainLabel.TabIndex = 0;
            this.TopMainLabel.Text = "Список пользователей";
            this.TopMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopMainLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMainLabel_MouseDown);
            this.TopMainLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopMainLabel_MouseMove);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(71)))), ((int)(((byte)(61)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoginColumn,
            this.BlockColumn,
            this.LimitColumn});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.InfoText;
            this.dataGridView1.Location = new System.Drawing.Point(283, 79);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(505, 359);
            this.dataGridView1.TabIndex = 11;
            // 
            // NewUserButton
            // 
            this.NewUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.NewUserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewUserButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.NewUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewUserButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NewUserButton.Location = new System.Drawing.Point(12, 264);
            this.NewUserButton.Name = "NewUserButton";
            this.NewUserButton.Size = new System.Drawing.Size(265, 39);
            this.NewUserButton.TabIndex = 12;
            this.NewUserButton.Text = "Добавить пользователя";
            this.NewUserButton.UseVisualStyleBackColor = false;
            this.NewUserButton.Click += new System.EventHandler(this.NewUserButton_Click);
            // 
            // AboutProgrammButton
            // 
            this.AboutProgrammButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.AboutProgrammButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutProgrammButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.AboutProgrammButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutProgrammButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutProgrammButton.Location = new System.Drawing.Point(12, 354);
            this.AboutProgrammButton.Name = "AboutProgrammButton";
            this.AboutProgrammButton.Size = new System.Drawing.Size(143, 39);
            this.AboutProgrammButton.TabIndex = 13;
            this.AboutProgrammButton.Text = "О программе";
            this.AboutProgrammButton.UseVisualStyleBackColor = false;
            this.AboutProgrammButton.Click += new System.EventHandler(this.AboutProgrammButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(265, 179);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveButton.Location = new System.Drawing.Point(161, 354);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(116, 39);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = false;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // LoginColumn
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.LoginColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.LoginColumn.HeaderText = "Логин";
            this.LoginColumn.Name = "LoginColumn";
            this.LoginColumn.ReadOnly = true;
            this.LoginColumn.Width = 312;
            // 
            // BlockColumn
            // 
            this.BlockColumn.HeaderText = "Блокировка";
            this.BlockColumn.Name = "BlockColumn";
            this.BlockColumn.Width = 75;
            // 
            // LimitColumn
            // 
            this.LimitColumn.HeaderText = "Ограничения";
            this.LimitColumn.Name = "LimitColumn";
            this.LimitColumn.Width = 75;
            // 
            // RefreshButton
            // 
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.RefreshButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Info;
            this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshButton.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RefreshButton.Location = new System.Drawing.Point(161, 399);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(116, 39);
            this.RefreshButton.TabIndex = 16;
            this.RefreshButton.Text = "Обновить";
            this.RefreshButton.UseVisualStyleBackColor = false;
            this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.MainPanel.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button PassChangeButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ExitButton;
        private System.Windows.Forms.Label TopMainLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AboutProgrammButton;
        private System.Windows.Forms.Button NewUserButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoginColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn BlockColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn LimitColumn;
        private System.Windows.Forms.Button RefreshButton;
    }
}