using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUI
{
    public partial class Dashboard : Form
    {
        List<Company> company = new List<Company>();

        public Dashboard()
        {
            InitializeComponent();

            UpdateBinding();
        }

        private void UpdateBinding()
        {
            tickerListBox.DataSource = company;
            tickerListBox.DisplayMember = "CompanyFullInfo";
        }

        private void getTickerButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            company = db.GetCompany(tickerSearchBox.Text);

            UpdateBinding();
        }

        private void addCompanyButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            int volumeToInt = 0;
            int.TryParse(volumeAddText.Text, out volumeToInt);

            bool isOptionable = false;
            isOptionable = optionableAddCheckBox.Checked;

            db.AddCompany(tickerAddText.Text, companyNameAddText.Text, volumeToInt, optionableAddCheckBox.Checked, websiteAddText.Text);
            
            tickerAddText.Text = "";
            companyNameAddText.Text = "";
            volumeAddText.Text = "";
            optionableAddCheckBox.Checked = false;
            websiteAddText.Text = "";
        }
    }
}
