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
    public partial class dailySell : MetroForm
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public dailySell()
        {
            InitializeComponent();
        }

        private void dailySell_Load(object sender, EventArgs e)
        {

        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            try{
                Daily_sell ds = new Daily_sell();
                ds.Receipt_no = receiptno.Text;
                ds.Ammount = Convert.ToInt32(this.ammount.Text);
                ds.Type = type.Text;
                ds.Date = dateTimePicker1.Value;
                db.Daily_sells.InsertOnSubmit(ds);
                db.SubmitChanges();
                MessageBox.Show("Data Inseretd Succesfully");
            }catch(Exception ex){
                MessageBox.Show("fill all field correctly");
            }

        }*/

        private void button1_Click_1(object sender, EventArgs e)
        {
            string reciept;
            string types;
            int ammounts;
            string serial;
            DateTime date;
            Daily_sell ds = new Daily_sell();
            try
            {
                serial = (receiptno.Text);
                var se = from a in db.Daily_sells
                         select a;

                foreach(var a in se) {
                    if(a.Receipt_no.Equals(serial)) {
                        MessageBox.Show("receiptno already exits");
                        goto last;
                    }
                }
                reciept = receiptno.Text;
                types = type.Text;
                ammounts = Convert.ToInt32(this.ammount.Text);
                date = dateTimePicker1.Value;

                ds.Receipt_no = reciept;
                ds.Type = types;
                ds.Ammount = ammounts;
                ds.Date = date;
                db.Daily_sells.InsertOnSubmit(ds);
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
            try
            {
                string reciept;
                string types;
                int ammounts;
                DateTime date;

                reciept = receiptno.Text;
                types = type.Text;
                ammounts = Convert.ToInt32(this.ammount.Text);
                date = dateTimePicker1.Value;
                String id = textBox1.Text;
                Daily_sell dd = db.Daily_sells.SingleOrDefault(x => x.Receipt_no == id);
                /*dd.Receipt_no = receiptno.Text;
                dd.Type = type.Text;
                dd.Ammount = Convert.ToInt32(this.ammount.Text);
                dd.Date = dateTimePicker1.Value;*/
                dd.Receipt_no = reciept;
                dd.Type = types;
                dd.Ammount = ammounts;
                dd.Date = date;
                db.SubmitChanges();
                MessageBox.Show("data updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the id then Edit In the textbox Thank You");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String id = textBox1.Text;
                Daily_sell dd = db.Daily_sells.SingleOrDefault(x => x.Receipt_no == id);
                if (dd != null)
                {
                    receiptno.Text = dd.Receipt_no;
                    type.Text = dd.Type;
                    ammount.Text = dd.Ammount.ToString();
                    dateTimePicker1.Text = dd.Date.ToString();
                }
                else
                    MessageBox.Show("data not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the id then Edit In the textbox Thank You");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                String id = textBox1.Text;
                Daily_sell ds = db.Daily_sells.SingleOrDefault(x => x.Receipt_no == id);
                db.Daily_sells.DeleteOnSubmit(ds);
                db.SubmitChanges();
                MessageBox.Show("data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the id then Edit In the textbox Thank You");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var q = db.Daily_sells.ToList();
            dataGridView1.DataSource = q.ToList();
        }
    }
}
