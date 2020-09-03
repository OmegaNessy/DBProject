namespace Lab7KuprV3
{
    partial class BuyingGoodsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label quantityLabel;
            System.Windows.Forms.Label data_ofRegistrationLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label totalPriceLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyingGoodsForm));
            this.courseWorkFor7LabDataSet = new Lab7KuprV3.CourseWorkFor7LabDataSet();
            this.buying_GoodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buying_GoodsTableAdapter = new Lab7KuprV3.CourseWorkFor7LabDataSetTableAdapters.Buying_GoodsTableAdapter();
            this.tableAdapterManager = new Lab7KuprV3.CourseWorkFor7LabDataSetTableAdapters.TableAdapterManager();
            this.deliveryTableAdapter = new Lab7KuprV3.CourseWorkFor7LabDataSetTableAdapters.DeliveryTableAdapter();
            this.goodsTableAdapter = new Lab7KuprV3.CourseWorkFor7LabDataSetTableAdapters.GoodsTableAdapter();
            this.manufacturerTableAdapter = new Lab7KuprV3.CourseWorkFor7LabDataSetTableAdapters.ManufacturerTableAdapter();
            this.providerTableAdapter = new Lab7KuprV3.CourseWorkFor7LabDataSetTableAdapters.ProviderTableAdapter();
            this.buying_GoodsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.buying_GoodsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.data_ofRegistrationDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Delete = new System.Windows.Forms.Button();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Next = new System.Windows.Forms.Button();
            this.bt_Previous = new System.Windows.Forms.Button();
            this.bt_Last = new System.Windows.Forms.Button();
            this.bt_First = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.goodsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manufacturerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.providerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bt_Tovar = new System.Windows.Forms.Button();
            this.bt_Postavka = new System.Windows.Forms.Button();
            this.bt_Dostavka = new System.Windows.Forms.Button();
            this.bt_Report = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            quantityLabel = new System.Windows.Forms.Label();
            data_ofRegistrationLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            totalPriceLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.courseWorkFor7LabDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buying_GoodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buying_GoodsBindingNavigator)).BeginInit();
            this.buying_GoodsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Location = new System.Drawing.Point(32, 79);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new System.Drawing.Size(69, 13);
            quantityLabel.TabIndex = 5;
            quantityLabel.Text = "Количество:";
            // 
            // data_ofRegistrationLabel
            // 
            data_ofRegistrationLabel.AutoSize = true;
            data_ofRegistrationLabel.Location = new System.Drawing.Point(32, 216);
            data_ofRegistrationLabel.Name = "data_ofRegistrationLabel";
            data_ofRegistrationLabel.Size = new System.Drawing.Size(103, 13);
            data_ofRegistrationLabel.TabIndex = 9;
            data_ofRegistrationLabel.Text = "Дата регистрации:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(32, 104);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(36, 13);
            priceLabel.TabIndex = 13;
            priceLabel.Text = "Цена:";
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Location = new System.Drawing.Point(32, 154);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new System.Drawing.Size(89, 13);
            totalPriceLabel.TabIndex = 15;
            totalPriceLabel.Text = "Иоговая сумма:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(32, 56);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(41, 13);
            label1.TabIndex = 43;
            label1.Text = "Товар:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(32, 193);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(69, 13);
            label3.TabIndex = 45;
            label3.Text = "Доставщик:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(33, 132);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 13);
            label2.TabIndex = 47;
            label2.Text = "Поставщик:";
            // 
            // courseWorkFor7LabDataSet
            // 
            this.courseWorkFor7LabDataSet.DataSetName = "CourseWorkFor7LabDataSet";
            this.courseWorkFor7LabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buying_GoodsBindingSource
            // 
            this.buying_GoodsBindingSource.DataMember = "Buying_Goods";
            this.buying_GoodsBindingSource.DataSource = this.courseWorkFor7LabDataSet;
            // 
            // buying_GoodsTableAdapter
            // 
            this.buying_GoodsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Buying_GoodsTableAdapter = this.buying_GoodsTableAdapter;
            this.tableAdapterManager.DeliveryTableAdapter = this.deliveryTableAdapter;
            this.tableAdapterManager.GoodsTableAdapter = this.goodsTableAdapter;
            this.tableAdapterManager.ManufacturerTableAdapter = this.manufacturerTableAdapter;
            this.tableAdapterManager.ProviderTableAdapter = this.providerTableAdapter;
            this.tableAdapterManager.UpdateOrder = Lab7KuprV3.CourseWorkFor7LabDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // goodsTableAdapter
            // 
            this.goodsTableAdapter.ClearBeforeFill = true;
            // 
            // manufacturerTableAdapter
            // 
            this.manufacturerTableAdapter.ClearBeforeFill = true;
            // 
            // providerTableAdapter
            // 
            this.providerTableAdapter.ClearBeforeFill = true;
            // 
            // buying_GoodsBindingNavigator
            // 
            this.buying_GoodsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.buying_GoodsBindingNavigator.BindingSource = this.buying_GoodsBindingSource;
            this.buying_GoodsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.buying_GoodsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.buying_GoodsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.buying_GoodsBindingNavigatorSaveItem});
            this.buying_GoodsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.buying_GoodsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.buying_GoodsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.buying_GoodsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.buying_GoodsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.buying_GoodsBindingNavigator.Name = "buying_GoodsBindingNavigator";
            this.buying_GoodsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.buying_GoodsBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.buying_GoodsBindingNavigator.TabIndex = 0;
            this.buying_GoodsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // buying_GoodsBindingNavigatorSaveItem
            // 
            this.buying_GoodsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.buying_GoodsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("buying_GoodsBindingNavigatorSaveItem.Image")));
            this.buying_GoodsBindingNavigatorSaveItem.Name = "buying_GoodsBindingNavigatorSaveItem";
            this.buying_GoodsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.buying_GoodsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.buying_GoodsBindingNavigatorSaveItem.Click += new System.EventHandler(this.buying_GoodsBindingNavigatorSaveItem_Click);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buying_GoodsBindingSource, "quantity", true));
            this.quantityTextBox.Location = new System.Drawing.Point(140, 76);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(200, 20);
            this.quantityTextBox.TabIndex = 6;
            // 
            // data_ofRegistrationDateTimePicker
            // 
            this.data_ofRegistrationDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.buying_GoodsBindingSource, "data_ofRegistration", true));
            this.data_ofRegistrationDateTimePicker.Location = new System.Drawing.Point(141, 210);
            this.data_ofRegistrationDateTimePicker.Name = "data_ofRegistrationDateTimePicker";
            this.data_ofRegistrationDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_ofRegistrationDateTimePicker.TabIndex = 10;
            // 
            // priceTextBox
            // 
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buying_GoodsBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(140, 101);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(200, 20);
            this.priceTextBox.TabIndex = 14;
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.buying_GoodsBindingSource, "totalPrice", true));
            this.totalPriceTextBox.Location = new System.Drawing.Point(140, 151);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalPriceTextBox.TabIndex = 16;
            // 
            // bt_Save
            // 
            this.bt_Save.Location = new System.Drawing.Point(265, 365);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(75, 23);
            this.bt_Save.TabIndex = 38;
            this.bt_Save.Text = "Сохранить";
            this.bt_Save.UseVisualStyleBackColor = true;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Delete
            // 
            this.bt_Delete.Location = new System.Drawing.Point(159, 365);
            this.bt_Delete.Name = "bt_Delete";
            this.bt_Delete.Size = new System.Drawing.Size(75, 23);
            this.bt_Delete.TabIndex = 37;
            this.bt_Delete.Text = "Удалить";
            this.bt_Delete.UseVisualStyleBackColor = true;
            this.bt_Delete.Click += new System.EventHandler(this.bt_Delete_Click);
            // 
            // bt_Add
            // 
            this.bt_Add.Location = new System.Drawing.Point(47, 365);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(75, 23);
            this.bt_Add.TabIndex = 36;
            this.bt_Add.Text = "Добавить";
            this.bt_Add.UseVisualStyleBackColor = true;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Next
            // 
            this.bt_Next.Location = new System.Drawing.Point(371, 307);
            this.bt_Next.Name = "bt_Next";
            this.bt_Next.Size = new System.Drawing.Size(75, 23);
            this.bt_Next.TabIndex = 35;
            this.bt_Next.Text = "Слудующий";
            this.bt_Next.UseVisualStyleBackColor = true;
            this.bt_Next.Click += new System.EventHandler(this.bt_Next_Click);
            // 
            // bt_Previous
            // 
            this.bt_Previous.Location = new System.Drawing.Point(265, 307);
            this.bt_Previous.Name = "bt_Previous";
            this.bt_Previous.Size = new System.Drawing.Size(75, 23);
            this.bt_Previous.TabIndex = 34;
            this.bt_Previous.Text = "Предыдущий";
            this.bt_Previous.UseVisualStyleBackColor = true;
            this.bt_Previous.Click += new System.EventHandler(this.bt_Previous_Click);
            // 
            // bt_Last
            // 
            this.bt_Last.Location = new System.Drawing.Point(159, 307);
            this.bt_Last.Name = "bt_Last";
            this.bt_Last.Size = new System.Drawing.Size(75, 23);
            this.bt_Last.TabIndex = 33;
            this.bt_Last.Text = "Конец";
            this.bt_Last.UseVisualStyleBackColor = true;
            this.bt_Last.Click += new System.EventHandler(this.bt_Last_Click);
            // 
            // bt_First
            // 
            this.bt_First.Location = new System.Drawing.Point(47, 307);
            this.bt_First.Name = "bt_First";
            this.bt_First.Size = new System.Drawing.Size(75, 23);
            this.bt_First.TabIndex = 32;
            this.bt_First.Text = "Начало";
            this.bt_First.UseVisualStyleBackColor = true;
            this.bt_First.Click += new System.EventHandler(this.bt_First_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.buying_GoodsBindingSource, "good_ID", true));
            this.comboBox1.DataSource = this.goodsBindingSource;
            this.comboBox1.DisplayMember = "good_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(140, 48);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 39;
            this.comboBox1.ValueMember = "good_ID";
            // 
            // goodsBindingSource
            // 
            this.goodsBindingSource.DataMember = "Goods";
            this.goodsBindingSource.DataSource = this.courseWorkFor7LabDataSet;
            // 
            // comboBox4
            // 
            this.comboBox4.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.buying_GoodsBindingSource, "delivery_ID", true));
            this.comboBox4.DataSource = this.deliveryBindingSource;
            this.comboBox4.DisplayMember = "delivery_name";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(141, 183);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 42;
            this.comboBox4.ValueMember = "delivery_ID";
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.courseWorkFor7LabDataSet;
            // 
            // manufacturerBindingSource
            // 
            this.manufacturerBindingSource.DataMember = "Manufacturer";
            this.manufacturerBindingSource.DataSource = this.courseWorkFor7LabDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.buying_GoodsBindingSource, "provider_ID", true));
            this.comboBox2.DataSource = this.providerBindingSource;
            this.comboBox2.DisplayMember = "provider_name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(141, 124);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 46;
            this.comboBox2.ValueMember = "provider_ID";
            // 
            // providerBindingSource
            // 
            this.providerBindingSource.DataMember = "Provider";
            this.providerBindingSource.DataSource = this.courseWorkFor7LabDataSet;
            // 
            // bt_Tovar
            // 
            this.bt_Tovar.Location = new System.Drawing.Point(359, 46);
            this.bt_Tovar.Name = "bt_Tovar";
            this.bt_Tovar.Size = new System.Drawing.Size(201, 23);
            this.bt_Tovar.TabIndex = 48;
            this.bt_Tovar.Text = "Справочник товаров";
            this.bt_Tovar.UseVisualStyleBackColor = true;
            this.bt_Tovar.Click += new System.EventHandler(this.bt_Tovar_Click);
            // 
            // bt_Postavka
            // 
            this.bt_Postavka.Location = new System.Drawing.Point(359, 125);
            this.bt_Postavka.Name = "bt_Postavka";
            this.bt_Postavka.Size = new System.Drawing.Size(201, 20);
            this.bt_Postavka.TabIndex = 49;
            this.bt_Postavka.Text = "Справочник поставщиков";
            this.bt_Postavka.UseVisualStyleBackColor = true;
            this.bt_Postavka.Click += new System.EventHandler(this.bt_Postavka_Click);
            // 
            // bt_Dostavka
            // 
            this.bt_Dostavka.Location = new System.Drawing.Point(359, 181);
            this.bt_Dostavka.Name = "bt_Dostavka";
            this.bt_Dostavka.Size = new System.Drawing.Size(201, 23);
            this.bt_Dostavka.TabIndex = 50;
            this.bt_Dostavka.Text = "Справочник доставщиков";
            this.bt_Dostavka.UseVisualStyleBackColor = true;
            this.bt_Dostavka.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_Report
            // 
            this.bt_Report.Location = new System.Drawing.Point(359, 210);
            this.bt_Report.Name = "bt_Report";
            this.bt_Report.Size = new System.Drawing.Size(201, 23);
            this.bt_Report.TabIndex = 51;
            this.bt_Report.Text = "Отчет";
            this.bt_Report.UseVisualStyleBackColor = true;
            this.bt_Report.Click += new System.EventHandler(this.bt_Report_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(201, 23);
            this.button1.TabIndex = 52;
            this.button1.Text = "Таблица";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BuyingGoodsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bt_Report);
            this.Controls.Add(this.bt_Dostavka);
            this.Controls.Add(this.bt_Postavka);
            this.Controls.Add(this.bt_Tovar);
            this.Controls.Add(label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(label3);
            this.Controls.Add(label1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Delete);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.bt_Next);
            this.Controls.Add(this.bt_Previous);
            this.Controls.Add(this.bt_Last);
            this.Controls.Add(this.bt_First);
            this.Controls.Add(quantityLabel);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(data_ofRegistrationLabel);
            this.Controls.Add(this.data_ofRegistrationDateTimePicker);
            this.Controls.Add(priceLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(totalPriceLabel);
            this.Controls.Add(this.totalPriceTextBox);
            this.Controls.Add(this.buying_GoodsBindingNavigator);
            this.Name = "BuyingGoodsForm";
            this.Text = "Закупки";
            this.Load += new System.EventHandler(this.BuyingGoodsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.courseWorkFor7LabDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buying_GoodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buying_GoodsBindingNavigator)).EndInit();
            this.buying_GoodsBindingNavigator.ResumeLayout(false);
            this.buying_GoodsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.goodsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CourseWorkFor7LabDataSet courseWorkFor7LabDataSet;
        private System.Windows.Forms.BindingSource buying_GoodsBindingSource;
        private CourseWorkFor7LabDataSetTableAdapters.Buying_GoodsTableAdapter buying_GoodsTableAdapter;
        private CourseWorkFor7LabDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator buying_GoodsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton buying_GoodsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.DateTimePicker data_ofRegistrationDateTimePicker;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Delete;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Next;
        private System.Windows.Forms.Button bt_Previous;
        private System.Windows.Forms.Button bt_Last;
        private System.Windows.Forms.Button bt_First;
        private CourseWorkFor7LabDataSetTableAdapters.GoodsTableAdapter goodsTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource goodsBindingSource;
        private CourseWorkFor7LabDataSetTableAdapters.ManufacturerTableAdapter manufacturerTableAdapter;
        private System.Windows.Forms.BindingSource manufacturerBindingSource;
        private CourseWorkFor7LabDataSetTableAdapters.ProviderTableAdapter providerTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource providerBindingSource;
        private CourseWorkFor7LabDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private System.Windows.Forms.Button bt_Tovar;
        private System.Windows.Forms.Button bt_Postavka;
        private System.Windows.Forms.Button bt_Dostavka;
        private System.Windows.Forms.Button bt_Report;
        private System.Windows.Forms.Button button1;
    }
}