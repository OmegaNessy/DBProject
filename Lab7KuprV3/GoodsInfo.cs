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
    public partial class GoodsInfo : Form
    {
        public GoodsInfo()
        {
            InitializeComponent();
        }

        private void goodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.goodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseWorkFor7LabDataSet);

        }

        private void GoodsInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.courseWorkFor7LabDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.courseWorkFor7LabDataSet.Goods);

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            goodsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(courseWorkFor7LabDataSet);
            this.Dispose();
            BuyingGoodsForm buyinggoodsForm = new BuyingGoodsForm();
            buyinggoodsForm.ShowDialog();
        }
    }
}
