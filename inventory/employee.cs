using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;
using System.Data.Odbc;



namespace inventory
{
    public partial class employee : MetroForm
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        private string name;
        private string mobile_no;
        private float salary;
        private int deduction;
        private static int uniqueID;
        private static bool select = false;
        // OracleConnection con;
        //oracleDBconn.Connection_Query db = new oracleDBconn.Connection_Query();
        //string ConnectionString = "Data Source=localhost:1521/XE; User ID=admin; Password=admin";
        public employee()
        {
            
            //db.OpenConection();
            InitializeComponent();
        }

        private void employee_Load(object sender, EventArgs e)
        {
        }

  


        private void entryInfo_Click(object sender, EventArgs e)
        {
            string name;
            string phone;
            float salary= 0.0f;
            string mobile;
            idShow.Visible = false;
            Employee ef = new Employee();
            try
            {
                if (select == true)
                {
                    MessageBox.Show("this information already exits");
                    goto last;
                }
                name = nameField.Text;
                phone = contactField.Text;
                salary = float.Parse(salaryField.Text);
                mobile = contactField.Text;
                if(mobile.Length == 11) {
                    if(mobile[0] != '0' || mobile[1] != '1') {
                        MessageBox.Show("valid contact please");
                        goto last;
                    }
                } else {
                    MessageBox.Show("valid contact please");
                    goto last;
                }


                ef.Emp_name = name;
                ef.Emp_phone = phone;
                ef.Emp_salary = salary;
                db.Employees.InsertOnSubmit(ef);
                db.SubmitChanges();
                MessageBox.Show("Data Inseretd Succesfully");
            }
            catch(Exception ex) { MessageBox.Show("Fill up all field correctly"); }
            last:
            {

            }

        }

        private void dedection_Click(object sender,EventArgs e) {
            Employee ef = new Employee();
            int id;
            float amount=0.0f;
            try {
                id = int.Parse(deducID.Text);
                try {
                    amount = float.Parse(deducField.Text);
                    if(amount < 0.0f) {
                        MessageBox.Show("Amount should be positive");
                    } else {
                        var em = from emp in db.Employees
                                 select emp;
                        foreach(var emp in em) {
                            if(id == emp.Emp_id) {
                                emp.Emp_deduction += amount;
                                db.SubmitChanges();
                                MessageBox.Show("Deducation Successfully");
                                goto last;
                            }
                        }
                        MessageBox.Show("ID not found");
                    }
                } catch(System.Exception ex) {
                    MessageBox.Show("Amount should be real number");
                }
                 
            } catch(System.Exception ex) {
                MessageBox.Show("ID missedmatch");
            }
        last:
            {

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var q = db.Employees.ToList();
            dataGridView1.DataSource = q.ToList();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //id = idField.Text;
        }

        private void nameField_TextChanged(object sender, EventArgs e)
        {
            //name = nameField.Text;
        }

        private void contactField_TextChanged(object sender, EventArgs e)
        {
            //mobile_no = contactField.Text;
        }

        private void salaryField_TextChanged(object sender, EventArgs e)
        {
            //salary = float.Parse(salaryField.Text);
        }

        private void deducField_TextChanged(object sender, EventArgs e)
        {
            // = Convert.ToInt32(deducField.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                int id = int.Parse(textBox1.Text);
                Employee dd = db.Employees.SingleOrDefault(x => x.Emp_id == id);
                db.Employees.DeleteOnSubmit(dd);
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
            try
            {
                DataClasses1DataContext db = new DataClasses1DataContext();
                int id =int.Parse(textBox1.Text);
                uniqueID = id;
                Employee dd = db.Employees.SingleOrDefault(x => x.Emp_id == id);
                if (dd != null) {
                    idShow.Visible = true;
                    idShow.Text =Convert.ToString(id); 
                    nameField.Text = dd.Emp_name;
                    salaryField.Text = dd.Emp_salary.ToString();
                    contactField.Text = dd.Emp_phone;
                    deducField.Text = dd.Emp_deduction.ToString();
                    select = true;
                }
                else
                    MessageBox.Show("data not found");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the id then Edit In the textbox Thank You");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name;
            string phone;
            string mobile;
            float salary=0.0f;
            try
            {
                int id = int.Parse(textBox1.Text);
                Employee dd = db.Employees.SingleOrDefault(x => x.Emp_id == id);
                phone = contactField.Text;
                name = nameField.Text;
                salary =float.Parse(salaryField.Text);
                mobile = contactField.Text;
                if(mobile.Length == 11) {
                    if(mobile[0] != '0' || mobile[1] != '1') {
                        MessageBox.Show("valid contact please");
                        goto last;
                    }
                } else {
                    MessageBox.Show("valid contact please");
                    goto last;
                }

                //dd.Emp_id = int.Parse(idField.Text);
                //dd.Emp_name = nameField.Text;
                //dd.Emp_salary = Convert.ToInt32(this.salaryField.Text);
                //dd.Emp_phone = contactField.Text;
                dd.Emp_name = name;
                dd.Emp_phone = phone;
                dd.Emp_salary = salary;
                db.SubmitChanges();
                MessageBox.Show("data updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Select the id then Edit In the textbox Thank You");
            }
        last:
            {

            }
        }
    }
}
