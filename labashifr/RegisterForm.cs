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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.DarkRed;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.FromArgb(192, 47, 17);
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
            forms[1].Visible = true;
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            bool flag = true;
            if (LoginBox.Text != "")
            {
                String LoginUser = LoginBox.Text;
                foreach (var x in Program.Controller._listUsers)
                {
                    if (x.UserName == LoginUser)
                        flag = false;
                }
                if (flag)
                {
                    Program.Controller._listUsers.Add(new Data.UsersDB { UserName = LoginUser, Password = "", Block = false, Limit = false });
                    Program.Controller.SaveData();
                    LoginBox.Text = "";
                    MessageBox.Show("Пользователь успешно добавлен");
                }
                else
                {
                    MessageBox.Show("Такой логин уже существует");
                }
            }
            else
            {
                MessageBox.Show("Логин не должен быть пустым");
            }
        }
    }
}

