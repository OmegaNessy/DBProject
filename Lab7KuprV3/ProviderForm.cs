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
    public partial class ProviderForm : Form
    {
        public ProviderForm()
        {
            InitializeComponent();
        }

        private void providerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.providerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.courseWorkFor7LabDataSet);

        }

        private void ProviderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "courseWorkFor7LabDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.courseWorkFor7LabDataSet.Provider);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            providerBindingSource.Filter = "provider_name LIKE '" + textBox1.Text + "%'";
        }
    }
}
