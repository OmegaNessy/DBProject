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
    public partial class BuyingTable : Form
    {
        public BuyingTable()
        {
            InitializeComponent();
        }

        private void buying_GoodsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.view_1BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseWorkFor7LabDataSet);

        }

        private void BuyingTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Delivery". При необходимости она может быть перемещена или удалена.
            this.deliveryTableAdapter.Fill(this.courseWorkFor7LabDataSet.Delivery);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            this.manufacturerTableAdapter.Fill(this.courseWorkFor7LabDataSet.Manufacturer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.courseWorkFor7LabDataSet.Goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.courseWorkFor7LabDataSet.Provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.View_1". При необходимости она может быть перемещена или удалена.
            this.view_1TableAdapter.Fill(this.courseWorkFor7LabDataSet.View_1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Manufacturer". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Delivery". При необходимости она может быть перемещена или удалена.
          
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.courseWorkFor7LabDataSet.Provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Goods". При необходимости она может быть перемещена или удалена.
            this.goodsTableAdapter.Fill(this.courseWorkFor7LabDataSet.Goods);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Buying_Goods". При необходимости она может быть перемещена или удалена.


        }

        private void bt_Filter_Click(object sender, EventArgs e)
        {
            view_1BindingSource.Filter = null;
            if (comboBox1.SelectedIndex == -1) comboBox1.Text = "";
            if (comboBox2.SelectedIndex == -1) comboBox2.Text = "";
            if (comboBox2.Text == "" && comboBox1.Text != "")
            {
                view_1BindingSource.Filter = "[manufacturer] ='" + comboBox1.Text + "'";
            }

            else if (comboBox1.Text == "" && comboBox2.Text != "")
            {
                view_1BindingSource.Filter = "[good_name] ='" + comboBox2.Text + "'";
            }

            else view_1BindingSource.Filter = "[manufacturer] ='" + comboBox1.Text + "'" +
            " AND " + "[good_name] ='" + comboBox2.Text + "'";
        }
    }
}
