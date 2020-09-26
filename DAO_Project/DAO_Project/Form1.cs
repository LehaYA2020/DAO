using DAO_Project.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAO_Project
{
    public partial class Form1 : Form
    {
        UserDao userDao = new UserDao();
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            var user = new User()
            {
                Name = textBoxName.Text,
                Surname = textBoxSurname.Text
            };
            userDao.Save(user);
            textBoxConclusion.Text = $"Id = {user.Id}, Name = {user.Name}, Surname = {user.Surname}";
        }

        private void bttnConcl_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(userId.Text);//TODO TryParse
            User user = userDao.FindById(Id);
            if (user != null)
            {
                textBoxConclusion.Text = $"Id = {user.Id}, Name = {user.Name}, Surname = {user.Surname}";//В метод все сообщения(printUser, Errors)
            }
            else { textBoxConclusion.Text = $"User with ID={Id} not found"; }
        }
    }
}
