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
using MetroFramework;

namespace inventory
{
    public partial class adminPanel : MetroForm
    {
        private Form adminForm = new Form();
        public adminPanel()
        {
            InitializeComponent();
        }

        private void adminPanel_Load(object sender, EventArgs e)
        {

        }
        public Form getForm
        {
            get { return adminForm; }
            set { adminForm = value; }
        }

        private void metroUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            orderPanel ord = new orderPanel();
            ord.ShowDialog();
        }

        private void buttonAccounnt_Click(object sender, EventArgs e)
        {
            totalAmmountPanel ammount = new totalAmmountPanel();
            ammount.ShowDialog();
        }

        private void buttonInformation_Click(object sender, EventArgs e)
        {
            info one = new info();
            one.ShowDialog();
        }

        private void buttonDailySell_Click(object sender, EventArgs e)
        {
            dailySell dsell = new dailySell();
            dsell.ShowDialog();
        }

        private void buttonWorkers_Click(object sender, EventArgs e)
        {
            employee emp = new employee();
            emp.ShowDialog();
        }

        private void buttonDailyConsumption_Click(object sender, EventArgs e)
        {
            dailyConsumption dc = new dailyConsumption();
            dc.ShowDialog();
        }

        private void metroUserControl1_Load_1(object sender, EventArgs e)
        {

        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }
    }
}
