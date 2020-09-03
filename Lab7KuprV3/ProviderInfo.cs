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
    public partial class ProviderInfo : Form
    {
        public ProviderInfo()
        {
            InitializeComponent();
        }

        private void providerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.providerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseWorkFor7LabDataSet);

        }

        private void ProviderInfo_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.courseWorkFor7LabDataSet.Provider);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            providerBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(courseWorkFor7LabDataSet);
            this.Dispose();
            BuyingGoodsForm buying_GodsForm = new BuyingGoodsForm();
            buying_GodsForm.ShowDialog();
        }
    }
}
