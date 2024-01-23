namespace CulinaryBookApp
{
    partial class FormProduct
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
            dataGridViewProduct = new DataGridView();
            ProductCode = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductVolume = new DataGridViewTextBoxColumn();
            UnitOfMeasure = new DataGridViewTextBoxColumn();
            labelTitle = new Label();
            groupBoxProductDetails = new GroupBox();
            textBoxUnitOfMeasure = new TextBox();
            textBoxProductVolume = new TextBox();
            textBoxProductName = new TextBox();
            textBoxProductCode = new TextBox();
            labelProductOrder = new Label();
            labelProductWeight = new Label();
            labelProductType = new Label();
            labelProductCode = new Label();
            menuStrip1 = new MenuStrip();
            выходToolStripMenuItem = new ToolStripMenuItem();
            отчетToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            statusStripProductForm = new StatusStrip();
            ToolStripStatusLabel = new ToolStripStatusLabel();
            button1 = new Button();
            buttonClear_Click = new Button();
            buttonDelete_Click = new Button();
            buttonAdd_Click = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).BeginInit();
            groupBoxProductDetails.SuspendLayout();
            menuStrip1.SuspendLayout();
            statusStripProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewProduct
            // 
            dataGridViewProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProduct.Columns.AddRange(new DataGridViewColumn[] { ProductCode, ProductName, ProductVolume, UnitOfMeasure });
            dataGridViewProduct.Location = new Point(26, 82);
            dataGridViewProduct.Name = "dataGridViewProduct";
            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProduct.Size = new Size(525, 247);
            dataGridViewProduct.TabIndex = 4;
            dataGridViewProduct.CellContentClick += dataGridViewProduct_CellContentClick;
            dataGridViewProduct.SelectionChanged += dataGridViewProduct_SelectionChanged;
            // 
            // ProductCode
            // 
            ProductCode.DataPropertyName = "ProductCode";
            ProductCode.HeaderText = "Код продукта";
            ProductCode.Name = "ProductCode";
            ProductCode.ReadOnly = true;
            // 
            // ProductName
            // 
            ProductName.DataPropertyName = "ProductName";
            ProductName.HeaderText = "Название продукта";
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            // 
            // ProductVolume
            // 
            ProductVolume.DataPropertyName = "ProductVolume";
            ProductVolume.HeaderText = "Объём продукта";
            ProductVolume.Name = "ProductVolume";
            ProductVolume.ReadOnly = true;
            // 
            // UnitOfMeasure
            // 
            UnitOfMeasure.DataPropertyName = "UnitOfMeasure";
            UnitOfMeasure.HeaderText = "Единица измерения";
            UnitOfMeasure.Name = "UnitOfMeasure";
            UnitOfMeasure.ReadOnly = true;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(128, 33);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(306, 32);
            labelTitle.TabIndex = 3;
            labelTitle.Text = "Управление продуктами";
            // 
            // groupBoxProductDetails
            // 
            groupBoxProductDetails.Controls.Add(textBoxUnitOfMeasure);
            groupBoxProductDetails.Controls.Add(textBoxProductVolume);
            groupBoxProductDetails.Controls.Add(textBoxProductName);
            groupBoxProductDetails.Controls.Add(textBoxProductCode);
            groupBoxProductDetails.Controls.Add(labelProductOrder);
            groupBoxProductDetails.Controls.Add(labelProductWeight);
            groupBoxProductDetails.Controls.Add(labelProductType);
            groupBoxProductDetails.Controls.Add(labelProductCode);
            groupBoxProductDetails.Location = new Point(26, 342);
            groupBoxProductDetails.Name = "groupBoxProductDetails";
            groupBoxProductDetails.Size = new Size(507, 157);
            groupBoxProductDetails.TabIndex = 5;
            groupBoxProductDetails.TabStop = false;
            groupBoxProductDetails.Text = "Информация о продукте";
            // 
            // textBoxUnitOfMeasure
            // 
            textBoxUnitOfMeasure.Location = new Point(133, 118);
            textBoxUnitOfMeasure.Name = "textBoxUnitOfMeasure";
            textBoxUnitOfMeasure.Size = new Size(63, 23);
            textBoxUnitOfMeasure.TabIndex = 8;
            // 
            // textBoxProductVolume
            // 
            textBoxProductVolume.Location = new Point(116, 89);
            textBoxProductVolume.Name = "textBoxProductVolume";
            textBoxProductVolume.Size = new Size(100, 23);
            textBoxProductVolume.TabIndex = 7;
            // 
            // textBoxProductName
            // 
            textBoxProductName.Location = new Point(129, 60);
            textBoxProductName.Name = "textBoxProductName";
            textBoxProductName.Size = new Size(229, 23);
            textBoxProductName.TabIndex = 6;
            // 
            // textBoxProductCode
            // 
            textBoxProductCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxProductCode.Location = new Point(102, 31);
            textBoxProductCode.Name = "textBoxProductCode";
            textBoxProductCode.ReadOnly = true;
            textBoxProductCode.Size = new Size(64, 23);
            textBoxProductCode.TabIndex = 5;
            // 
            // labelProductOrder
            // 
            labelProductOrder.AutoSize = true;
            labelProductOrder.Location = new Point(15, 121);
            labelProductOrder.Name = "labelProductOrder";
            labelProductOrder.Size = new Size(116, 15);
            labelProductOrder.TabIndex = 3;
            labelProductOrder.Text = "Единица измерения";
            // 
            // labelProductWeight
            // 
            labelProductWeight.AutoSize = true;
            labelProductWeight.Location = new Point(15, 92);
            labelProductWeight.Name = "labelProductWeight";
            labelProductWeight.Size = new Size(98, 15);
            labelProductWeight.TabIndex = 2;
            labelProductWeight.Text = "Объём продукта";
            // 
            // labelProductType
            // 
            labelProductType.AutoSize = true;
            labelProductType.Location = new Point(15, 64);
            labelProductType.Name = "labelProductType";
            labelProductType.Size = new Size(112, 15);
            labelProductType.TabIndex = 1;
            labelProductType.Text = "Название продукта";
            // 
            // labelProductCode
            // 
            labelProductCode.AutoSize = true;
            labelProductCode.Location = new Point(15, 35);
            labelProductCode.Name = "labelProductCode";
            labelProductCode.Size = new Size(80, 15);
            labelProductCode.TabIndex = 0;
            labelProductCode.Text = "Код продукта";
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Info;
            menuStrip1.Items.AddRange(new ToolStripItem[] { выходToolStripMenuItem, отчетToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(575, 24);
            menuStrip1.TabIndex = 18;
            menuStrip1.Text = "menuStrip1";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(54, 20);
            выходToolStripMenuItem.Text = "Выход";
            выходToolStripMenuItem.Click += выходToolStripMenuItem_Click;
            // 
            // отчетToolStripMenuItem
            // 
            отчетToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excelToolStripMenuItem });
            отчетToolStripMenuItem.Name = "отчетToolStripMenuItem";
            отчетToolStripMenuItem.Size = new Size(51, 20);
            отчетToolStripMenuItem.Text = "Отчет";
            // 
            // excelToolStripMenuItem
            // 
            excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            excelToolStripMenuItem.Size = new Size(101, 22);
            excelToolStripMenuItem.Text = "Excel";
            excelToolStripMenuItem.Click += excelToolStripMenuItem_Click;
            // 
            // справкаToolStripMenuItem
            // 
            справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            справкаToolStripMenuItem.Size = new Size(65, 20);
            справкаToolStripMenuItem.Text = "Справка";
            справкаToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // statusStripProductForm
            // 
            statusStripProductForm.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel });
            statusStripProductForm.Location = new Point(0, 567);
            statusStripProductForm.Name = "statusStripProductForm";
            statusStripProductForm.Size = new Size(575, 22);
            statusStripProductForm.TabIndex = 19;
            statusStripProductForm.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel
            // 
            ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            ToolStripStatusLabel.Size = new Size(46, 17);
            ToolStripStatusLabel.Text = "Статус:";
            // 
            // button1
            // 
            button1.Location = new Point(189, 519);
            button1.Name = "button1";
            button1.Size = new Size(95, 37);
            button1.TabIndex = 23;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonClear_Click
            // 
            buttonClear_Click.Location = new Point(290, 519);
            buttonClear_Click.Name = "buttonClear_Click";
            buttonClear_Click.Size = new Size(95, 37);
            buttonClear_Click.TabIndex = 22;
            buttonClear_Click.Text = "Очистить";
            buttonClear_Click.UseVisualStyleBackColor = true;
            buttonClear_Click.Click += buttonClear_Click_Click;
            // 
            // buttonDelete_Click
            // 
            buttonDelete_Click.Location = new Point(391, 519);
            buttonDelete_Click.Name = "buttonDelete_Click";
            buttonDelete_Click.Size = new Size(95, 37);
            buttonDelete_Click.TabIndex = 21;
            buttonDelete_Click.Text = "Удалить";
            buttonDelete_Click.UseVisualStyleBackColor = true;
            buttonDelete_Click.Click += buttonDelete_Click_Click;
            // 
            // buttonAdd_Click
            // 
            buttonAdd_Click.Location = new Point(88, 518);
            buttonAdd_Click.Name = "buttonAdd_Click";
            buttonAdd_Click.Size = new Size(95, 37);
            buttonAdd_Click.TabIndex = 20;
            buttonAdd_Click.Text = "Добавить";
            buttonAdd_Click.UseVisualStyleBackColor = true;
            buttonAdd_Click.Click += buttonAdd_Click_Click;
            // 
            // FormProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(575, 589);
            Controls.Add(button1);
            Controls.Add(buttonClear_Click);
            Controls.Add(buttonDelete_Click);
            Controls.Add(buttonAdd_Click);
            Controls.Add(statusStripProductForm);
            Controls.Add(menuStrip1);
            Controls.Add(groupBoxProductDetails);
            Controls.Add(dataGridViewProduct);
            Controls.Add(labelTitle);
            Name = "FormProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление продуктами";
            Load += FormProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProduct).EndInit();
            groupBoxProductDetails.ResumeLayout(false);
            groupBoxProductDetails.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            statusStripProductForm.ResumeLayout(false);
            statusStripProductForm.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProduct;
        private Label labelTitle;
        private DataGridViewTextBoxColumn ProductCode;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductVolume;
        private DataGridViewTextBoxColumn UnitOfMeasure;
        private GroupBox groupBoxProductDetails;
        private TextBox textBoxUnitOfMeasure;
        private TextBox textBoxProductVolume;
        private TextBox textBoxProductName;
        private TextBox textBoxProductCode;
        private Label labelProductOrder;
        private Label labelProductWeight;
        private Label labelProductType;
        private Label labelProductCode;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem отчетToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private StatusStrip statusStripProductForm;
        private ToolStripStatusLabel ToolStripStatusLabel;
        private Button button1;
        private Button buttonClear_Click;
        private Button buttonDelete_Click;
        private Button buttonAdd_Click;
    }
}