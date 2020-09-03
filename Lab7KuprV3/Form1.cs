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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Goods_Click(object sender, EventArgs e)
        {
            this.Hide();
            GoodsForm goodsForm = new GoodsForm();
            goodsForm.ShowDialog();
            this.Show();
        }

        private void bt_delivery_Click(object sender, EventArgs e)
        {
            this.Hide();
            DeliveryForm deliveryForm = new DeliveryForm();
            deliveryForm.ShowDialog();
            this.Show();
        }

        private void bt_provider_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProviderForm providerForm = new ProviderForm();
            providerForm.ShowDialog();
            this.Show();
        }

        private void bt_manufacturer_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManufacturerForm manufacturerForm = new ManufacturerForm();
            manufacturerForm.ShowDialog();
            this.Show();
        }

        private void bt_buying_goods_Click(object sender, EventArgs e)
        {
            this.Hide();
            BuyingGoodsForm buyingGoodsForm = new BuyingGoodsForm();
            buyingGoodsForm.ShowDialog();
            this.Show();
        }
    }
}
