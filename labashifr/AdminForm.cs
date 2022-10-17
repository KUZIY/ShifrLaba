using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labashifr
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            FillDataGrid();
        }
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.DarkRed;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.FromArgb(192, 47, 17);
        }
        private void AboutProgrammButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ИДБ - 19 - 01 Кузьмин Никита Романович\nВариант 11.\nНаличие латинских букв, символов кириллицы и знаков препинания.");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point LastPoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void TopMainLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void TopMainLabel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            FormCollection forms = Application.OpenForms;
            forms[0].Visible = true;
            this.Close();
        }

        private void PassChangeButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            PassChangeForm PassChangeForm = new PassChangeForm();
            PassChangeForm.Show();
        }

        private void NewUserButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm RegisterForm = new RegisterForm();
            RegisterForm.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                foreach (var x in Program.Controller._listUsers)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == x.UserName)
                    {
                        x.Block = (bool)dataGridView1.Rows[i].Cells[1].Value;
                        x.Limit = (bool)dataGridView1.Rows[i].Cells[2].Value;
                    }
                }
            }
            Program.Controller.SaveData();
        }



        private void FillDataGrid()
        {
            dataGridView1.Rows.Clear();
            foreach (var x in Program.Controller._listUsers)
            {
                //if  (x.UserName != LoginForm.Login)
                if (x.UserName != "admin")
                {
                    dataGridView1.Rows.Add(x.UserName, x.Block, x.Limit);
                }
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            FillDataGrid();
        }
    }
}
