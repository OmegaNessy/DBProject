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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "kafedraDBDataSet.employees". При необходимости она может быть перемещена или удалена.
            this.view_2TableAdapter1.Fill(this.courseWorkFor7LabDataSet1.View_2);
            string strFIO;
            string strFIO2;

            GoodsForm main = this.Owner as GoodsForm;
            if (main != null)
            {
                //strFIO=main.txtText.Text;
                strFIO = main.comboBox1.Text;
                strFIO2 = main.good_nameTextBox.Text;

                ReportParameter pFIO = new ReportParameter("pFIO", strFIO);
                ReportParameter pFIO2 = new ReportParameter("pFIO2", strFIO2);

                reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pFIO,pFIO2 });
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
