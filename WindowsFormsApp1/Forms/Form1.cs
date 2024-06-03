using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Classes;
using WindowsFormsApp1.ModelData;

namespace WindowsFormsApp1.Forms
{
    public partial class Form1 : Form
    {
        private Model1 model = DBContext.model;
        public Form1()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBoxLOgin.Text)
                || String.IsNullOrWhiteSpace(textBoxPassword.Text)
                || String.IsNullOrWhiteSpace(textBoxGender.Text)
                || String.IsNullOrWhiteSpace(textBoxFullNAme.Text))
            {
                MessageBox.Show("Заполните все поля");
                return;

            }
            User user = new User();
           // user.ID = 2;
            user.FullName = textBoxFullNAme.Text;
            user.Login = textBoxLOgin.Text;
            user.Password = textBoxPassword.Text;
            user.Gender = textBoxGender.Text;

            model.User.Add(user);
            model.SaveChanges();
            MessageBox.Show("Пользователь добавлен");
        }
    }
}
