using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities1;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        
        BindingList<User1> users = new BindingList<User1>();
        public Form1()
        {
            InitializeComponent();
            lblLastName.Text = Resource2.FullName;
            btnAdd.Text = Resource2.Add;
            listBox1.DisplayMember = "FullName";
            List();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User1 user = new User1();
            user.FullName = textBox1.Text;
            users.Add(user);
            List();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users.Remove((User1)listBox1.SelectedItem);
            List();

        }

        private void List()
        {
            listBox1.DataSource = users.ToList();
        }
    }
}
