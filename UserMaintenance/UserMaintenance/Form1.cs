using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserMaintenance.Entities;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {

        BindingList<User> users = new BindingList<User>();
        public Form1()
        {
            InitializeComponent();
            lblFullName.Text = Resource1.FullName;
            btnAdd.Text = Resource1.Add;
            btnWrite.Text = Resource1.WriteToFile;
            btnDelete.Text = Resource1.Delete;

            listUsers.DataSource = users;
            listUsers.ValueMember = "ID";
            listUsers.DisplayMember = "FullName";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User u = new User();
            u.FullName = txtFullName.Text;
            users.Add(u);
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            StreamWriter sw = null;
            string filter = "CSV file (*.csv)|*.csv| All Files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filter = sfd.FileName;
                sw = new StreamWriter(filter);

                foreach (var u in users)
                {
                    sw.Write(u.ID);
                    sw.Write(",");
                    sw.WriteLine(u.FullName);
                }
                sw.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var itemToDel = (User)listUsers.SelectedItem;
                users.Remove(itemToDel);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
