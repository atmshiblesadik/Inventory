using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace inventory
{
    public partial class dailyConsumption : MetroForm
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private static int ss;
        private static bool select = false;
        public dailyConsumption()
        {
            InitializeComponent();
        }

        private void dailyConsumption_Load(object sender, EventArgs e)
        {

        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Daily_consumption s = new Daily_consumption();
                s.Description = description.Text;
                s.Ammount = Convert.ToInt32(this.ammount.Text);
                s.Dates = dateTimePicker1.Value;
                db.Daily_consumptions.InsertOnSubmit(s);
                db.SubmitChanges();
                MessageBox.Show("Data Inseretd Succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fill all field correctly");
            }
        */

        private void button1_Click_1(object sender, EventArgs e)
        {
            int serial;
            int ammounts;
            string descriptions;
            DateTime date;
            Daily_consumption s = new Daily_consumption();
            try
            {
                serial = int.Parse(textBox2.Text);
                var se = from a in db.Daily_consumptions
                         select a;

                foreach(var a in se){
                    if(a.Serial_No == serial) {
                        MessageBox.Show("serial number already exits");
                        goto last;
                    }
                }
                descriptions = description.Text;
                ammounts = Convert.ToInt32(this.ammount.Text);
                date = dateTimePicker1.Value;

                s.Serial_No = serial;
                s.Description = descriptions;
                s.Ammount = ammounts;
                s.Dates = date;
                db.Daily_consumptions.InsertOnSubmit(s);
                db.SubmitChanges();
                MessageBox.Show("Data Inseretd Succesfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Fill Up The Cells Thank You");
            }
            last:
            {
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var q = db.Daily_consumptions.ToList();
            dataGridView1.DataSource = q.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                int id = int.Parse(textBox1.Text);
                Daily_consumption dd = db.Daily_consumptions.SingleOrDefault(x => x.Serial_No == id);
                if (dd != null)
                {
                    textBox2.Text = Convert.ToString(dd.Serial_No);
                    description.Text = dd.Description;
                    ammount.Text = dd.Ammount.ToString();
                    dateTimePicker1.Text = dd.Dates.ToString();
                }
                else
                    MessageBox.Show("data not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select The Id Then Edit In the textbox Thank You");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string descriptions;
            int ammounts;
            DateTime date;
            try
            {
                int id = int.Parse(textBox1.Text);
                Daily_consumption dd = db.Daily_consumptions.SingleOrDefault(x => x.Serial_No == id);
                descriptions = description.Text;
                ammounts = Convert.ToInt32(this.ammount.Text);
                date = dateTimePicker1.Value;


                dd.Description = descriptions;
                dd.Ammount = ammounts;
                dd.Dates = date;
                db.SubmitChanges();
                MessageBox.Show("data updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select The Id Then Edit In the textbox Thank You");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                int id = int.Parse(textBox1.Text);
                Daily_consumption prod = db.Daily_consumptions.SingleOrDefault(x => x.Serial_No == id);
                db.Daily_consumptions.DeleteOnSubmit(prod);
                db.SubmitChanges();
                MessageBox.Show("data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select The Id Then Edit In the textbox Thank You");

            }
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
