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
    public partial class PassChangeForm : Form
    {
        public PassChangeForm()
        {
            InitializeComponent();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.DarkRed;
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.ForeColor = Color.FromArgb(192, 47, 17);
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
            BackFun();
        }

        private void PassChangeButton_Click(object sender, EventArgs e)
        {
            String NewPass = NewPassBox.Text;
            String NewPass1 = NewPass1Box.Text;
            String OldPass = OldPassBox.Text;

            if ((NewPass == NewPass1) && (NewPass != "") && (NewPass != OldPass))
            {

                foreach (var x in Program.Controller._listUsers)
                {
                    if (x.UserName == LoginForm.Login)
                    {
                        if (x.Password == OldPass)
                        {
                            if (((x.Limit == true) && (PassLim.CheckLimit(NewPass))) || (x.Limit == false))
                            {
                                x.Password = NewPass;
                                Program.Controller.SaveData();
                                MessageBox.Show("Пароль успешно изменён");
                                NewPassBox.Text = "";
                                NewPass1Box.Text = "";
                                OldPassBox.Text = "";
                                BackFun();
                            }
                            else
                            {
                                MessageBox.Show("Пароль не соответсвует ограничениям");
                                return;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Старый пароль указан не верно");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Пароли не совпадают, не могут быть пустыми");
            }
        }

        private void BackFun ()
        {
            FormCollection forms = Application.OpenForms;
            if (forms.Count == 3)
            {
                forms[1].Visible = true;
                this.Close();
            }
            else
            {
                forms[0].Visible = true;
                this.Close();
            }
        }
    }
}
