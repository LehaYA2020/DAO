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
        UserDao Add;
        public Form1()
        {
            InitializeComponent();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            using (var context = new MyDBContext())
            {
                var user = new User()
                {
                    Name = textBoxName.Text,
                    Surname = textBoxSurname.Text
                };

                context.Users.Add(user);
                context.SaveChanges();
                textBoxConclusion.Text = $"Id = {user.Id}, Name = {user.Name}, Surname = {user.Surname}";

            }
        }

        private void bttnConcl_Click(object sender, EventArgs e)
        {
        }
    }
}
