using DAO_Project.DAO;
using MySqlConnector;
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
                Surname = textBoxSurname.Text,
                Number = textBoxNumber.Text
            };
            user = userDao.Save(user);
            ShowMessages(user.ToString());
        }

        private void bttnConcl_Click(object sender, EventArgs e)
        {
            int Id = 0;
            if (Int32.TryParse(userId.Text, out Id))
            {
                User user = userDao.FindById(Id);
                if (user != null)
                {
                    ShowMessages(user.ToString());
                }
                else { ShowMessages($"User with ID={Id} not found"); }
            }
        }

        private void bttnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                User user = new User()
                {
                    Id = Convert.ToInt32(userId.Text),
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text,
                    Number = textBoxNumber.Text
                };

                user = userDao.Update(user);

                ShowMessages(user.ToString());
            }
            catch (Exception Ex)
            {
                MessageBox.Show (Ex.Message, "Smth went wrong: ",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void bttnRemove_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(userId.Text);
            userDao.Remove(userDao.FindById(Id));
        }

        private void ShowMessages(string message)
        {
            textBoxConclusion.Text = message;
        }
    }
}
