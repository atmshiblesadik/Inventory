using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace inventory
{
    public partial class login : MetroForm
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public login()
        {
            InitializeComponent();
        }

        private void metroTextBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void metroTextBox2_Click_1(object sender, EventArgs e)
        {

        }

        //login button click
        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            /*
            adminPanel ap = new adminPanel();
            ap.getForm = this;
            this.Hide();
           // Hide();
            ap.ShowDialog();
            Close();
            */
            try {
                bool ok = false;
                if(username.Text == string.Empty) {
                    MessageBox.Show("Please Fill username");

                } else if(password.Text == string.Empty) {
                    MessageBox.Show("Please give password");
                } else {
                    string user = username.Text;
                    string pass = password.Text;
                    var a = from s in db.LoginTables
                            select s;
                    foreach(var s in a) {
                        if(user.Equals(s.username) && pass.Equals(s.password)) {
                            ok = true;
                            adminPanel ap = new adminPanel();
                            ap.getForm = this;
                            this.Hide();
                            // Hide();
                            ap.ShowDialog();
                           // MessageBox.Show("Please Fill All cells");
                           Close();

                        }
                    }
                    if(!ok) {
                        MessageBox.Show("username or password incorrect");
                    }
                }
            } catch(System.Exception ex) {
                MessageBox.Show("Database Not Connected");
            }
        }

        private void login_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
             
        }
    }
}
