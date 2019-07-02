
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
    public partial class orderPanel : MetroForm
    {

        DataClasses1DataContext db = new DataClasses1DataContext();
        public orderPanel()
        {
            InitializeComponent();
            //Hide
            this.typeOne.Hide();
            this.typeTwo.Hide();
            this.typeThree.Hide();
            this.metroLabel7.Hide();
            this.descriptionBox.Hide();
            //
        }

        private void orderPanel_Load(object sender, EventArgs e)
        {
            //descriptionBox.Visible = false;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void orderToggle_CheckedChanged_1(object sender, EventArgs e)
        {
            if(orderToggle.Checked==true) {
                this.loginButton.Location=new System.Drawing.Point(243,475);
                this.typeOne.Show();
                this.typeTwo.Show();
                this.typeThree.Show();
                if(typeThree.Checked == true) {
                    descriptionBox.Visible = true;
                    descriptionBox.Show();
                    metroLabel7.Show();
                } else {
                    descriptionBox.Hide();
                    metroLabel7.Hide();
                    typeThree.Checked = false;
                }
            } else {
                this.loginButton.Location=new System.Drawing.Point(243,345);
                this.typeOne.Hide();
                this.typeTwo.Hide();
                this.typeThree.Hide();
                this.metroLabel7.Hide();
                descriptionBox.Visible = false;
                this.descriptionBox.Hide();
            }
        }

        private void descriptionBox_Click(object sender, EventArgs e)
        {

        }

        private void typeThree_CheckedChanged(object sender, EventArgs e)
        {
            if(typeThree.Checked == false) { descriptionBox.Visible = false; metroLabel7.Hide(); typeThree.Checked = false; }
            else if(typeThree.Checked == true) { descriptionBox.Visible = true; metroLabel7.Show(); }
        }

        private void loginButton_Click(object sender,EventArgs e) {
            Multiple_order table = new Multiple_order();
            if(orderToggle.Checked == true) {
                try {
                    int amount;
                    int ad, due;
                    string ordrNo;
                    string des="";
                    string mobile;
                    ordrNo = (orderNoBox.Text);
                    if(typeOne.Checked==false && typeThree.Checked==false && typeTwo.Checked == false) {
                        MessageBox.Show("Select your type");
                        goto last;
                    }
                    if(typeOne.Checked==true) {
                        des += "typeOne ";
                    }
                    if(typeTwo.Checked == true) {
                        des += "typeTwo ";
                    }
                    if(typeThree.Checked == true) {
                        des = "";
                        des = descriptionBox.Text;
                    }
                    amount = int.Parse(totalBox.Text);
                    ad = int.Parse(advanceBox.Text);
                    due = int.Parse(dueBox.Text);
                    mobile = contactBox.Text;
                    if(mobile.Length == 11) {
                        if(mobile[0]!='0' || mobile[1] != '1') {
                            MessageBox.Show("valid contact please");
                            goto last;
                        }
                    }else {
                        MessageBox.Show("valid contact please");
                        goto last;
                    }
                    if(mobile.Equals("") || ordrNo.Equals("") || amount <= 0) {
                        MessageBox.Show("Fill all field correctly");
                        goto last;
                    }
                    table.Ammount = amount;
                    table.Advanced = ad;
                    table.Due = due;
                    table.Description = des;
                    table.Mobile = mobile;
                    table.Order_no = ordrNo;
                    table.Date = dateTimePicker1.Value;
                    db.Multiple_orders.InsertOnSubmit(table);
                    db.SubmitChanges();
                    MessageBox.Show("Order create successfully");
                }catch(Exception ex) {
                    MessageBox.Show("Fill all field correctly");
                }
            }else {
                try {
                    int amount;
                    int ad, due;
                    string ordrNo;
                    string mobile;
                    ordrNo = (orderNoBox.Text);
                    amount = int.Parse(totalBox.Text);
                    ad = int.Parse(advanceBox.Text);
                    due = int.Parse(dueBox.Text);
                    mobile = contactBox.Text;
                    if(mobile.Length == 11) {
                        if(mobile[0] != '0' || mobile[1] != '1') {
                            MessageBox.Show("valid contact please");
                            goto last;
                        }
                    } else {
                        MessageBox.Show("valid contact please");
                        goto last;
                    }
                    if(mobile.Equals("") || ordrNo.Equals("") || amount<=0) {
                        MessageBox.Show("Fill all field correctly");
                        goto last;
                    }
                    table.Ammount = amount;
                    table.Advanced = ad;
                    table.Due = due;
                    table.Mobile = mobile;
                    table.Order_no = ordrNo;
                    table.Date = dateTimePicker1.Value;
                    db.Multiple_orders.InsertOnSubmit(table);
                    db.SubmitChanges();
                    MessageBox.Show("Order create successfully");
                } catch(Exception ex) {
                    MessageBox.Show("Fill all field correctly");
                }
            }
            last:
            {

            }
        }

        private void advanceBox_Click(object sender,EventArgs e) {

        }
        private void advanceBox_Leave(object sender,EventArgs e) {
            try {
                int amount = int.Parse(totalBox.Text);
                int ad = int.Parse(advanceBox.Text);
                dueBox.Text = (amount - ad).ToString();
            }catch(Exception ex) {

            }
        }
        private void totalBox_Leave(object sender,EventArgs e) {
            advanceBox.Text = 0.ToString();
            dueBox.Text = totalBox.Text;

        }
        private void orderNoBox_Leave(Object sender, EventArgs e)
        {
            float amount = 0.0f;
            float ad = 0.0f;
            string no;
            if (orderNoBox.Text.ToString().Equals(""))
            {
            }
            else
            {
                no = (orderNoBox.Text);
                var ordr = from a in db.Multiple_orders
                           where a.Order_no == no
                           select a;

                foreach (var table in ordr)
                {
                    amount += table.Ammount;
                    ad += table.Advanced;
                }
                totalBox.Text = amount.ToString();
                advanceBox.Text = ad.ToString();
                dueBox.Text = (amount - ad).ToString();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            var q = db.Multiple_orders.ToList();
            dataGridView1.DataSource = q.ToList();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            typeOne.Checked = false;
            typeTwo.Checked = false;
            typeThree.Checked = true;
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                int id = int.Parse(metroTextBox1.Text);
                Multiple_order ee = db.Multiple_orders.SingleOrDefault(x => x.Id == id);
                if (ee != null)
                {
                    orderNoBox.Text = ee.Order_no;
                    descriptionBox.Text = ee.Description;
                    totalBox.Text =Convert.ToString(ee.Ammount);
                    advanceBox.Text = Convert.ToString(ee.Advanced);
                    contactBox.Text = ee.Mobile;
                    dueBox.Text = Convert.ToString(ee.Due);
                    dateTimePicker1.Text = ee.Date.ToString();
                }
                else
                    MessageBox.Show("data not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the id then Edit In the textbox Thank You");
            }
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int amount;
            int ad, due;
            string ordrNo;
            string des = "";
            string mobile;
            ordrNo = (orderNoBox.Text);
            try
            {
                int id = int.Parse(metroTextBox1.Text);
                Multiple_order ee = db.Multiple_orders.SingleOrDefault(x => x.Id == id);
                ordrNo = orderNoBox.Text;
                amount = Convert.ToInt32(totalBox.Text);
                ad = Convert.ToInt32(advanceBox.Text);
                due = Convert.ToInt32(dueBox.Text);
                mobile = contactBox.Text;
                if(typeOne.Checked == false && typeThree.Checked == false && typeTwo.Checked == false) {
                    MessageBox.Show("Select your type");
                    goto last;
                }
                if(typeOne.Checked == true) {
                    des += "typeOne ";
                }
                if(typeTwo.Checked == true) {
                    des += "typeTwo ";
                }
                if(typeThree.Checked == true) {
                    des = "";
                    des = descriptionBox.Text;
                }
                if(mobile.Length == 11) {
                    if(mobile[0] != '0' || mobile[1] != '1') {
                        MessageBox.Show("valid contact please");
                        goto last;
                    }
                } else {
                    MessageBox.Show("valid contact please");
                    goto last;
                }

                ee.Advanced = ad;
                ee.Due = due;
                ee.Description = des;
                ee.Mobile = mobile;
                ee.Ammount = amount;
                db.SubmitChanges();
                MessageBox.Show("Data update successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the id then Edit In the textbox Thank You");
            }
        last:
            {

            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(metroTextBox1.Text);
                Multiple_order ee = db.Multiple_orders.SingleOrDefault(x => x.Id == id);
                db.Multiple_orders.DeleteOnSubmit(ee);
                db.SubmitChanges();
                MessageBox.Show("data deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the id then Edit In the textbox Thank You");
            }
        }
    }
    }
