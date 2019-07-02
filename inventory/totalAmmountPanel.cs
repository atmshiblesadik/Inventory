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

namespace inventory
{
    public partial class totalAmmountPanel : MetroForm
    {
        DataClasses1DataContext db = new DataClasses1DataContext();
        public totalAmmountPanel()
        {
            InitializeComponent();
        }

        private void totalAmmountPanel_Load(object sender, EventArgs e)
        {

        }

        private void consumptionBox_Click(object sender, EventArgs e)
        {

        }

        private void monthlyButton_Click(object sender, EventArgs e)
        {

            Totalammountpanel t = new Totalammountpanel();
            t.Total_consumption = Convert.ToInt32(consumptionBox.Text);
            t.Total_sell = Convert.ToInt32(sellBox.Text);
            t.Benifit = Convert.ToInt32(benefitBox.Text);
            t.Loss = Convert.ToInt32(lossBox.Text);
            db.Totalammountpanels.InsertOnSubmit(t);
            db.SubmitChanges();
            MessageBox.Show("Data Inseretd Succesfully");
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            try
            {
                float totalsell=0.0f;
                float benifit=0.0f;
                float loss=0.0f;
                float totalexpence=0.0f;
                DateTime st= dateTimePicker1.Value;
                DateTime en= dateTimePicker2.Value;
                var sell = from a in db.Daily_sells
                            select a;
                foreach(var a in sell)
                {
                    if(a.Date>=st && a.Date<=en)totalsell += a.Ammount;
                }
                var ordr = from a in db.Multiple_orders
                           select a;
                foreach(var a in ordr)
                {
                    if (a.Date >= st && a.Date <= en) totalsell += a.Ammount;
                }
                var expence = from a in db.Daily_consumptions
                           select a;
                foreach (var a in expence)
                {
                    if (a.Dates >= st && a.Dates <= en) totalexpence += a.Ammount;
                }
                consumptionBox.Text = totalexpence.ToString();
                sellBox.Text = totalsell.ToString();
                if (totalexpence > totalsell)
                {
                    lossBox.Text = (totalexpence - totalsell).ToString();
                    benefitBox.Text = 0.ToString();
                }
                else
                {
                    benefitBox.Text = (totalsell - totalexpence).ToString();
                    lossBox.Text = 0.ToString();
                }
                DateTime date1 = dateTimePicker1.Value;
                DateTime date2 = dateTimePicker2.Value;
                var daily_con = from p in db.Daily_consumptions
                            where p.Dates >= date1 && p.Dates <= date2
                            select p;
                dataGridView1.DataSource = daily_con.ToList();

                var daily_sel = from p in db.Daily_sells
                            where p.Date >= date1 && p.Date <= date2
                            select p;
                dataGridView2.DataSource = daily_sel.ToList();

                var daily_tmp = from p in db.Multiple_orders
                            where p.Date >= date1 && p.Date <= date2
                            select p;
                dataGridView3.DataSource = daily_tmp.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data not Found");
            }
        }

        private void metroLabel5_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel7_Click_1(object sender, EventArgs e)
        {

        }

        private void metroLabel8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
