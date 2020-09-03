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
    public partial class DeliveryInfo : Form
    {
        public DeliveryInfo()
        {
            InitializeComponent();
        }

        private void deliveryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.deliveryBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseWorkFor7LabDataSet);

        }

        private void DeliveryInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.courseWorkFor7LabDataSet.Delivery);

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            deliveryBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(courseWorkFor7LabDataSet);
            this.Dispose();
            BuyingGoodsForm buyinggoodsForm = new BuyingGoodsForm();
            buyinggoodsForm.ShowDialog();
        }
    }
}
