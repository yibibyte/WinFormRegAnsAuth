using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ModelData;

namespace WindowsFormsApp1.Forms
{
    public partial class Autorization : Form
    {

        public Autorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Model1 model1 = new Model1();
            if (String.IsNullOrWhiteSpace(textBoxLOgin.Text)
                || String.IsNullOrWhiteSpace(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;

            }

            User user;
            foreach (User useritem in model1.User)
            {
                if (useritem.Login == textBoxLOgin.Text && useritem.Password == textBoxPassword.Text)
                {
                    user = useritem;
                    break;
                }
               // user = null;
            }
            user = model1.User.FirstOrDefault(useritem => useritem.Login == textBoxLOgin.Text && useritem.Password == textBoxPassword.Text);
            if (user == null)
            {
                MessageBox.Show("Не найден!");
                return;
            }
            switch (user.Role)
            {
                case 1:
                    Administrator administrator = new Administrator();
                    administrator.Show();
                    Hide();
                    break;
                case 2:
                    UserForm userf = new UserForm();
                    userf.Show();
                    Hide();
                    break;
            }
        }
    }
}
