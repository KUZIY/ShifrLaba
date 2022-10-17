
using labashifr.Data;
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
    public partial class LoginForm : Form
    {
        public int Errors = 0;
        public bool flag = false;
        public static string Login;
        public LoginForm()
        {
            InitializeComponent();
            this.PasswordBox.AutoSize = false;
            this.PasswordBox.Size = new Size(this.LoginBox.Size.Width, this.LoginBox.Size.Height);
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

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            String LoginUser = LoginBox.Text;
            String PassUser = PasswordBox.Text;
            if ((LoginUser != "") && (LoginUser != null))
            {
                foreach (var x in Program.Controller._listUsers)
                {
                    flag = false;
                    if (x.UserName == LoginUser)
                    {
                        if ((x.UserName == "admin") && (x.Password == PassUser))
                        {
                            if (x.Password == "" || (x.Limit == true) && !(PassLim.CheckLimit(x.Password)))
                            {
                                if (x.Password == "")
                                    MessageBox.Show("Ваш пароль пуст. Срочного смените его");
                                if ((x.Limit == true) && !(PassLim.CheckLimit(x.Password)))
                                    MessageBox.Show("Ваш пароль не соответствует ограничениям. Срочного смените его");
                                this.Hide();
                                PassChangeForm passChangeForm = new PassChangeForm();
                                passChangeForm.Show();
                                Errors = 0;
                                flag = true;
                                Login = LoginUser;
                                PasswordBox.Text = "";
                                LoginBox.Text = "";
                                //break;
                                return;
                            }
                            else
                            {
                                this.Hide();
                                AdminForm AdminForm = new AdminForm();
                                AdminForm.Show();
                                Errors = 0;
                                flag = true;
                                Login = LoginUser;
                                PasswordBox.Text = "";
                                LoginBox.Text = "";
                                //break;
                                return;
                            }
                        }
                        else
                        {
                            if (x.Password != PassUser)
                            {
                                MessageBox.Show("Пароль не верный");
                                Errors = Errors + 1;
                                flag = true;
                                if (Errors > 2)
                                {
                                    this.Close();
                                }
                                //break;
                                return;
                            }
                            else
                            {
                                if (x.Block == true)
                                {
                                    MessageBox.Show("Пользователь с таким Логином заблокирован. Обратитесь к Администратору.");
                                    Errors = 0;
                                    flag = true;
                                    this.Close();
                                    //break;
                                    return;
                                }
                                else
                                {
                                    if (x.Password == "" ||(x.Limit == true)&& !(PassLim.CheckLimit(x.Password)))
                                    {
                                        if (x.Password == "")
                                            MessageBox.Show("Ваш пароль пуст. Срочного смените его");
                                        if ((x.Limit == true) && !(PassLim.CheckLimit(x.Password)))
                                            MessageBox.Show("Ваш пароль не соответствует ограничениям. Срочного смените его");
                                        this.Hide();
                                        PassChangeForm passChangeForm = new PassChangeForm();
                                        passChangeForm.Show();
                                        Errors = 0;
                                        flag = true;
                                        Login = LoginUser;
                                        PasswordBox.Text = "";
                                        LoginBox.Text = "";
                                        //break;
                                        return;
                                    }
                                    else
                                    {
                                        this.Hide();
                                        UserForm userForm = new UserForm();
                                        userForm.Show();
                                        Errors = 0;
                                        flag = true;
                                        Login = LoginUser;
                                        PasswordBox.Text = "";
                                        LoginBox.Text = "";
                                        //break;
                                        return;
                                    }
 //                                   if (x.Limit == true)
 //                                   {
 //                                       if (PassLim.CheckLimit(x.Password))
 //                                       {
 //                                           MessageBox.Show("Ваш пароль не соответствует ограничениям. Срочного смените его");
 //                                       }
 //                                           MessageBox.Show("Ваш пароль не соответствует ограничениям. Срочного смените его");
 //                                   }
                                }
                            }
                        }
                    }
                }
                if (flag == false)
                {
                    MessageBox.Show("Пользователь с таким Логином не найден");
                }
            }
            else
            {
                MessageBox.Show("Поле логин не может быть пустым");
            }

        }
    }
}
