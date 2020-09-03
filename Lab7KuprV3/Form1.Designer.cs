namespace Lab7KuprV3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_buying_goods = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_delivery = new System.Windows.Forms.Button();
            this.bt_provider = new System.Windows.Forms.Button();
            this.bt_manufacturer = new System.Windows.Forms.Button();
            this.bt_Goods = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_buying_goods
            // 
            this.bt_buying_goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_buying_goods.Location = new System.Drawing.Point(189, 371);
            this.bt_buying_goods.Margin = new System.Windows.Forms.Padding(4);
            this.bt_buying_goods.Name = "bt_buying_goods";
            this.bt_buying_goods.Size = new System.Drawing.Size(267, 76);
            this.bt_buying_goods.TabIndex = 23;
            this.bt_buying_goods.Text = "Закупки";
            this.bt_buying_goods.UseVisualStyleBackColor = true;
            this.bt_buying_goods.Click += new System.EventHandler(this.bt_buying_goods_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(76, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 31);
            this.label1.TabIndex = 22;
            this.label1.Text = "База данных \"Система учета закупок\"";
            // 
            // bt_delivery
            // 
            this.bt_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_delivery.Location = new System.Drawing.Point(189, 466);
            this.bt_delivery.Margin = new System.Windows.Forms.Padding(4);
            this.bt_delivery.Name = "bt_delivery";
            this.bt_delivery.Size = new System.Drawing.Size(267, 76);
            this.bt_delivery.TabIndex = 21;
            this.bt_delivery.Text = "Доставка";
            this.bt_delivery.UseVisualStyleBackColor = true;
            this.bt_delivery.Click += new System.EventHandler(this.bt_delivery_Click);
            // 
            // bt_provider
            // 
            this.bt_provider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_provider.Location = new System.Drawing.Point(189, 268);
            this.bt_provider.Margin = new System.Windows.Forms.Padding(4);
            this.bt_provider.Name = "bt_provider";
            this.bt_provider.Size = new System.Drawing.Size(267, 76);
            this.bt_provider.TabIndex = 20;
            this.bt_provider.Text = "Поставщик";
            this.bt_provider.UseVisualStyleBackColor = true;
            this.bt_provider.Click += new System.EventHandler(this.bt_provider_Click);
            // 
            // bt_manufacturer
            // 
            this.bt_manufacturer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_manufacturer.Location = new System.Drawing.Point(189, 175);
            this.bt_manufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.bt_manufacturer.Name = "bt_manufacturer";
            this.bt_manufacturer.Size = new System.Drawing.Size(267, 74);
            this.bt_manufacturer.TabIndex = 19;
            this.bt_manufacturer.Text = "Производитель";
            this.bt_manufacturer.UseVisualStyleBackColor = true;
            this.bt_manufacturer.Click += new System.EventHandler(this.bt_manufacturer_Click);
            // 
            // bt_Goods
            // 
            this.bt_Goods.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Goods.Location = new System.Drawing.Point(189, 79);
            this.bt_Goods.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Goods.Name = "bt_Goods";
            this.bt_Goods.Size = new System.Drawing.Size(267, 76);
            this.bt_Goods.TabIndex = 18;
            this.bt_Goods.Text = "Товары";
            this.bt_Goods.UseVisualStyleBackColor = true;
            this.bt_Goods.Click += new System.EventHandler(this.bt_Goods_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 555);
            this.Controls.Add(this.bt_buying_goods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_delivery);
            this.Controls.Add(this.bt_provider);
            this.Controls.Add(this.bt_manufacturer);
            this.Controls.Add(this.bt_Goods);
            this.Name = "Form1";
            this.Text = "Система управления";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_buying_goods;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_delivery;
        private System.Windows.Forms.Button bt_provider;
        private System.Windows.Forms.Button bt_manufacturer;
        private System.Windows.Forms.Button bt_Goods;
    }
}

