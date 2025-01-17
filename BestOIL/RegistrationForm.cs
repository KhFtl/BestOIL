using BestOIL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOIL
{
    public partial class RegistrationForm : Form
    {
        LoginForm loginForm = new LoginForm();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            loginForm.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User();
            try
            {
                user.RegisterUser(txt_userName.Text, txt_password.Text);
                MessageBox.Show($"Користувач {txt_userName.Text} зареєстровано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginForm.Show();
        }
    }
}
