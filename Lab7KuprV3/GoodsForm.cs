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
    public partial class GoodsForm : Form
    {
        public GoodsForm()
        {
            InitializeComponent();
        }

        private void bt_Last_Click(object sender, EventArgs e)
        {
            goodsBindingSource.MoveLast();

        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            goodsBindingSource.RemoveCurrent();

        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            goodsBindingSource.AddNew();

        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            goodsBindingSource.MoveNext();

        }

        private void bt_Previous_Click(object sender, EventArgs e)
        {
            goodsBindingSource.MovePrevious();

        }

        private void bt_First_Click(object sender, EventArgs e)
        {
            goodsBindingSource.MoveFirst();

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            goodsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(courseWorkFor7LabDataSet);
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseWorkFor7LabDataSet);

        }

        private void GoodsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.courseWorkFor7LabDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.courseWorkFor7LabDataSet.Goods);

        }

        private void bt_Table_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ManufacturerInfo manufacturerInfo = new ManufacturerInfo();
            manufacturerInfo.ShowDialog();
        }
        Form5 f5;
        private void bt_Report_Click(object sender, EventArgs e)
        {
            //this.Dispose();
            //GoodsReportV2 goodsReport = new GoodsReportV2();
            //goodsReport.Owner = this;
            //goodsReport.ShowDialog();
            if (f5 == null || f5.IsDisposed) //Если Форма отсутствует или не определена,
                f5 = new Form5();  //то создать форму
            f5.ShowDialog(this);

        }
    }
}
