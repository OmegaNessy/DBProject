using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7KuprV3
{
    public partial class buyingReport : Form
    {
        private string manufacture;
        private string provider;
        public buyingReport()
        {
            InitializeComponent();
        }

        private void buyingReport_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "CourseWorkFor7LabDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.CourseWorkFor7LabDataSet.Provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "CourseWorkFor7LabDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.CourseWorkFor7LabDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "CourseWorkFor7LabDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.View_1TableAdapter.Fill(this.CourseWorkFor7LabDataSet.View_1);
            dateTimePicker1.Text = "01.01.2000";
            dateTimePicker2.Text = DateTime.Now.ToString();
            this.comboBox1.SelectedIndex = -1;
            this.comboBox2.SelectedIndex = -1;
            this.reportViewer1.RefreshReport();
            

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            string filter = GetFilterString();
            View_1BindingSource.Filter = filter;

            this.reportViewer1.RefreshReport();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            string filter = GetFilterString();
            View_1BindingSource.Filter = filter;

            this.reportViewer1.RefreshReport();
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = GetFilterString();
            View_1BindingSource.Filter = filter;

            this.reportViewer1.RefreshReport();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filter = GetFilterString();
            View_1BindingSource.Filter = filter;

            this.reportViewer1.RefreshReport();
        }
        private string GetFilterString()
        {
            manufacture = comboBox1.Text;
            provider = comboBox2.Text;
            string fromDate = dateTimePicker1.Value.Date.ToLongDateString();
            string toDate = dateTimePicker2.Value.Date.ToLongDateString();

            string filter = $"data_ofRegistration >= '{fromDate}' AND data_ofRegistration <= '{toDate}'";

            if (comboBox1.SelectedIndex != -1)
            {
                filter += $" AND manufacturer = '{manufacture}'";
            }

            if (comboBox2.SelectedIndex != -1)
            {
                filter += $" AND provider_name = '{provider}'";
            }


            return filter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.comboBox1.SelectedIndex = -1;
            this.comboBox2.SelectedIndex = -1;
        }
    }
}
