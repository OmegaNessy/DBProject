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
    public partial class BuyingGoodsForm : Form
    {
        public BuyingGoodsForm()
        {
            InitializeComponent();
        }

        private void buying_GoodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.buying_GoodsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseWorkFor7LabDataSet);

        }

        private void BuyingGoodsForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.courseWorkFor7LabDataSet.Delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.courseWorkFor7LabDataSet.Provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.courseWorkFor7LabDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.courseWorkFor7LabDataSet.Goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Buying_Goods". При необходимости она может быть перемещена или удалена.
            this.buying_GoodsTableAdapter.Fill(this.courseWorkFor7LabDataSet.Buying_Goods);
        }

        private void bt_First_Click(object sender, EventArgs e)
        {
            buying_GoodsBindingSource.MoveFirst();

        }

        private void bt_Delete_Click(object sender, EventArgs e)
        {
            buying_GoodsBindingSource.RemoveCurrent();

        }

        private void bt_Add_Click(object sender, EventArgs e)
        {
            buying_GoodsBindingSource.AddNew();
            totalPriceTextBox.Hide();

        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            buying_GoodsBindingSource.MoveNext();

        }

        private void bt_Previous_Click(object sender, EventArgs e)
        {
            buying_GoodsBindingSource.MovePrevious();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            buying_GoodsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(courseWorkFor7LabDataSet);
            totalPriceTextBox.Show();
        }

        private void bt_Last_Click(object sender, EventArgs e)
        {
            buying_GoodsBindingSource.MoveLast();

        }

        private void bt_Tovar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            GoodsInfo goodsInfo = new GoodsInfo();
            goodsInfo.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            ProviderInfo providerInfo = new ProviderInfo();
            providerInfo.ShowDialog();
        }

        private void bt_Postavka_Click(object sender, EventArgs e)
        {
            this.Dispose();
            DeliveryInfo deliveryInfo = new DeliveryInfo();
            deliveryInfo.ShowDialog();
        }

        private void bt_Report_Click(object sender, EventArgs e)
        {
            this.Dispose();
            buyingReport bReport = new buyingReport();
            bReport.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            BuyingTable buyingTable = new BuyingTable();
            buyingTable.ShowDialog();
        }
    }
}
