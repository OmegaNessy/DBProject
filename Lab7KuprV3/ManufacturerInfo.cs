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
    public partial class ManufacturerInfo : Form
    {
        public ManufacturerInfo()
        {
            InitializeComponent();
        }

        private void manufacturerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.manufacturerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseWorkFor7LabDataSet);

        }

        private void ManufacturerInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.courseWorkFor7LabDataSet.Manufacturer);

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            manufacturerBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(courseWorkFor7LabDataSet);
            this.Dispose();
            GoodsForm goodsForm = new GoodsForm();
            goodsForm.ShowDialog();
        }
    }
}
