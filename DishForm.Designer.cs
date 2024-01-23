namespace CulinaryBookApp
{
    partial class DishForm
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
            labelTitle = new Label();
            dataGridViewDishes = new DataGridView();
            DishCodeColumn = new DataGridViewTextBoxColumn();
            DishTypeColumn = new DataGridViewTextBoxColumn();
            DishWeightColumn = new DataGridViewTextBoxColumn();
            CookingOrderColumn = new DataGridViewTextBoxColumn();
            CaloriesColumn = new DataGridViewTextBoxColumn();
            CarbohydratesColumn = new DataGridViewTextBoxColumn();
            groupBoxDishDetails = new GroupBox();
            textBoxCarbohydrates = new TextBox();
            labelCarbohydrates = new Label();
            textBoxCalories = new TextBox();
            textBoxCookingOrder = new TextBox();
            textBoxDishWeight = new TextBox();
            textBoxDishType = new TextBox();
            textBoxDishCode = new TextBox();
            labelCalories = new Label();
            labelCookingOrder = new Label();
            labelDishWeight = new Label();
            labelDishType = new Label();
            labelDishCode = new Label();
            buttonAdd_Click = new Button();
            buttonDelete_Click = new Button();
            buttonClear_Click = new Button();
            statusStripDishForm = new StatusStrip();
            ToolStripStatusLabel = new ToolStripStatusLabel();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            выходToolStripMenuItem = new ToolStripMenuItem();
            отчетToolStripMenuItem = new ToolStripMenuItem();
            excelToolStripMenuItem = new ToolStripMenuItem();
            справкаToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishes).BeginInit();
            groupBoxDishDetails.SuspendLayout();
            statusStripDishForm.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelTitle.Location = new Point(266, 29);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(274, 32);
            labelTitle.TabIndex = 1;
            labelTitle.Text = "Управление блюдами";
            // 
            // dataGridViewDishes
            // 
            dataGridViewDishes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDishes.Columns.AddRange(new DataGridViewColumn[] { DishCodeColumn, DishTypeColumn, DishWeightColumn, CookingOrderColumn, CaloriesColumn, CarbohydratesColumn });
            dataGridViewDishes.Location = new Point(26, 73);
            dataGridViewDishes.Name = "dataGridViewDishes";
            dataGridViewDishes.ReadOnly = true;
            dataGridViewDishes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewDishes.Size = new Size(736, 247);
            dataGridViewDishes.TabIndex = 2;
            dataGridViewDishes.SelectionChanged += dataGridViewDishes_SelectionChanged;
            // 
            // DishCodeColumn
            // 
            DishCodeColumn.DataPropertyName = "DishCode";
            DishCodeColumn.HeaderText = "Код блюда";
            DishCodeColumn.Name = "DishCodeColumn";
            DishCodeColumn.ReadOnly = true;
            // 
            // DishTypeColumn
            // 
            DishTypeColumn.DataPropertyName = "DishType";
            DishTypeColumn.HeaderText = "Тип блюда";
            DishTypeColumn.Name = "DishTypeColumn";
            DishTypeColumn.ReadOnly = true;
            // 
            // DishWeightColumn
            // 
            DishWeightColumn.DataPropertyName = "DishWeight";
            DishWeightColumn.HeaderText = "Вес блюда";
            DishWeightColumn.Name = "DishWeightColumn";
            DishWeightColumn.ReadOnly = true;
            // 
            // CookingOrderColumn
            // 
            CookingOrderColumn.DataPropertyName = "CookingOrder";
            CookingOrderColumn.HeaderText = "Порядок приготовления";
            CookingOrderColumn.Name = "CookingOrderColumn";
            CookingOrderColumn.ReadOnly = true;
            // 
            // CaloriesColumn
            // 
            CaloriesColumn.DataPropertyName = "Calories";
            CaloriesColumn.HeaderText = "Калорийность";
            CaloriesColumn.Name = "CaloriesColumn";
            CaloriesColumn.ReadOnly = true;
            // 
            // CarbohydratesColumn
            // 
            CarbohydratesColumn.DataPropertyName = "Carbohydrates";
            CarbohydratesColumn.HeaderText = "Углеводы";
            CarbohydratesColumn.Name = "CarbohydratesColumn";
            CarbohydratesColumn.ReadOnly = true;
            // 
            // groupBoxDishDetails
            // 
            groupBoxDishDetails.Controls.Add(textBoxCarbohydrates);
            groupBoxDishDetails.Controls.Add(labelCarbohydrates);
            groupBoxDishDetails.Controls.Add(textBoxCalories);
            groupBoxDishDetails.Controls.Add(textBoxCookingOrder);
            groupBoxDishDetails.Controls.Add(textBoxDishWeight);
            groupBoxDishDetails.Controls.Add(textBoxDishType);
            groupBoxDishDetails.Controls.Add(textBoxDishCode);
            groupBoxDishDetails.Controls.Add(labelCalories);
            groupBoxDishDetails.Controls.Add(labelCookingOrder);
            groupBoxDishDetails.Controls.Add(labelDishWeight);
            groupBoxDishDetails.Controls.Add(labelDishType);
            groupBoxDishDetails.Controls.Add(labelDishCode);
            groupBoxDishDetails.Location = new Point(26, 326);
            groupBoxDishDetails.Name = "groupBoxDishDetails";
            groupBoxDishDetails.Size = new Size(736, 220);
            groupBoxDishDetails.TabIndex = 3;
            groupBoxDishDetails.TabStop = false;
            groupBoxDishDetails.Text = "Информация о блюде";
            // 
            // textBoxCarbohydrates
            // 
            textBoxCarbohydrates.Location = new Point(107, 174);
            textBoxCarbohydrates.Name = "textBoxCarbohydrates";
            textBoxCarbohydrates.Size = new Size(74, 23);
            textBoxCarbohydrates.TabIndex = 11;
            // 
            // labelCarbohydrates
            // 
            labelCarbohydrates.AutoSize = true;
            labelCarbohydrates.Location = new Point(15, 177);
            labelCarbohydrates.Name = "labelCarbohydrates";
            labelCarbohydrates.Size = new Size(60, 15);
            labelCarbohydrates.TabIndex = 10;
            labelCarbohydrates.Text = "Углеводы";
            // 
            // textBoxCalories
            // 
            textBoxCalories.Location = new Point(107, 145);
            textBoxCalories.Name = "textBoxCalories";
            textBoxCalories.Size = new Size(74, 23);
            textBoxCalories.TabIndex = 9;
            // 
            // textBoxCookingOrder
            // 
            textBoxCookingOrder.Location = new Point(163, 118);
            textBoxCookingOrder.Name = "textBoxCookingOrder";
            textBoxCookingOrder.Size = new Size(406, 23);
            textBoxCookingOrder.TabIndex = 8;
            // 
            // textBoxDishWeight
            // 
            textBoxDishWeight.Location = new Point(102, 89);
            textBoxDishWeight.Name = "textBoxDishWeight";
            textBoxDishWeight.Size = new Size(100, 23);
            textBoxDishWeight.TabIndex = 7;
            // 
            // textBoxDishType
            // 
            textBoxDishType.Location = new Point(102, 60);
            textBoxDishType.Name = "textBoxDishType";
            textBoxDishType.Size = new Size(150, 23);
            textBoxDishType.TabIndex = 6;
            // 
            // textBoxDishCode
            // 
            textBoxDishCode.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textBoxDishCode.Location = new Point(102, 31);
            textBoxDishCode.Name = "textBoxDishCode";
            textBoxDishCode.ReadOnly = true;
            textBoxDishCode.Size = new Size(55, 23);
            textBoxDishCode.TabIndex = 5;
            // 
            // labelCalories
            // 
            labelCalories.AutoSize = true;
            labelCalories.Location = new Point(15, 148);
            labelCalories.Name = "labelCalories";
            labelCalories.Size = new Size(86, 15);
            labelCalories.TabIndex = 4;
            labelCalories.Text = "Калорийность";
            // 
            // labelCookingOrder
            // 
            labelCookingOrder.AutoSize = true;
            labelCookingOrder.Location = new Point(15, 121);
            labelCookingOrder.Name = "labelCookingOrder";
            labelCookingOrder.Size = new Size(142, 15);
            labelCookingOrder.TabIndex = 3;
            labelCookingOrder.Text = "Порядок приготовления";
            // 
            // labelDishWeight
            // 
            labelDishWeight.AutoSize = true;
            labelDishWeight.Location = new Point(15, 92);
            labelDishWeight.Name = "labelDishWeight";
            labelDishWeight.Size = new Size(65, 15);
            labelDishWeight.TabIndex = 2;
            labelDishWeight.Text = "Вес блюда";
            // 
            // labelDishType
            // 
            labelDishType.AutoSize = true;
            labelDishType.Location = new Point(15, 64);
            labelDishType.Name = "labelDishType";
            labelDishType.Size = new Size(66, 15);
            labelDishType.TabIndex = 1;
            labelDishType.Text = "Тип блюда";
            // 
            // labelDishCode
            // 
            labelDishCode.AutoSize = true;
            labelDishCode.Location = new Point(15, 35);
            labelDishCode.Name = "labelDishCode";
            labelDishCode.Size = new Size(66, 15);
            labelDishCode.TabIndex = 0;
            labelDishCode.Text = "Код блюда";
            // 
            // buttonAdd_Click
            // 
            buttonAdd_Click.Location = new Point(205, 552);
            buttonAdd_Click.Name = "buttonAdd_Click";
            buttonAdd_Click.Size = new Size(95, 37);
            buttonAdd_Click.TabIndex = 12;
            buttonAdd_Click.Text = "Добавить";
            buttonAdd_Click.UseVisualStyleBackColor = true;
            buttonAdd_Click.Click += buttonAdd_Click_Click;
            // 
            // buttonDelete_Click
            // 
            buttonDelete_Click.Location = new Point(508, 553);
            buttonDelete_Click.Name = "buttonDelete_Click";
            buttonDelete_Click.Size = new Size(95, 37);
            buttonDelete_Click.TabIndex = 13;
            buttonDelete_Click.Text = "Удалить";
            buttonDelete_Click.UseVisualStyleBackColor = true;
            buttonDelete_Click.Click += buttonDelete_Click_Click;
            // 
            // buttonClear_Click
            // 
            buttonClear_Click.Location = new Point(407, 553);
            buttonClear_Click.Name = "buttonClear_Click";
            buttonClear_Click.Size = new Size(95, 37);
            buttonClear_Click.TabIndex = 14;
            buttonClear_Click.Text = "Очистить";
            buttonClear_Click.UseVisualStyleBackColor = true;
            buttonClear_Click.Click += buttonClear_Click_Click;
            // 
            // statusStripDishForm
            // 
            statusStripDishForm.Items.AddRange(new ToolStripItem[] { ToolStripStatusLabel });
            statusStripDishForm.Location = new Point(0, 599);
            statusStripDishForm.Name = "statusStripDishForm";
            statusStripDishForm.Size = new Size(785, 22);
            statusStripDishForm.TabIndex = 15;
            statusStripDishForm.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel
            // 
            ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            ToolStripStatusLabel.Size = new Size(46, 17);
            ToolStripStatusLabel.Text = "Статус:";
            // 
            // button1
            // 
            button1.Location = new Point(306, 553);
            button1.Name = "button1";
            button1.Size = new Size(95, 37);
            button1.TabIndex = 16;
            button1.Text = "Изменить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.Info;
            menuStrip1.Items.AddRange(new ToolStripItem[] { выходToolStripMenuItem, отчетToolStripMenuItem, справкаToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(785, 24);
            menuStrip1.TabIndex = 17;
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
            // DishForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(785, 621);
            Controls.Add(button1);
            Controls.Add(statusStripDishForm);
            Controls.Add(menuStrip1);
            Controls.Add(buttonClear_Click);
            Controls.Add(buttonDelete_Click);
            Controls.Add(groupBoxDishDetails);
            Controls.Add(dataGridViewDishes);
            Controls.Add(buttonAdd_Click);
            Controls.Add(labelTitle);
            MainMenuStrip = menuStrip1;
            Name = "DishForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Управление блюдами";
            Load += DishForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDishes).EndInit();
            groupBoxDishDetails.ResumeLayout(false);
            groupBoxDishDetails.PerformLayout();
            statusStripDishForm.ResumeLayout(false);
            statusStripDishForm.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelTitle;
        private DataGridView dataGridViewDishes;
        private DataGridViewTextBoxColumn DishCodeColumn;
        private DataGridViewTextBoxColumn DishTypeColumn;
        private DataGridViewTextBoxColumn DishWeightColumn;
        private DataGridViewTextBoxColumn CookingOrderColumn;
        private DataGridViewTextBoxColumn CaloriesColumn;
        private DataGridViewTextBoxColumn CarbohydratesColumn;
        private GroupBox groupBoxDishDetails;
        private Label labelCookingOrder;
        private Label labelDishWeight;
        private Label labelDishType;
        private Label labelDishCode;
        private TextBox textBoxCalories;
        private TextBox textBoxCookingOrder;
        private TextBox textBoxDishWeight;
        private TextBox textBoxDishType;
        private TextBox textBoxDishCode;
        private Label labelCalories;
        private TextBox textBoxCarbohydrates;
        private Label labelCarbohydrates;
        private Button buttonAdd_Click;
        private Button buttonDelete_Click;
        private Button buttonClear_Click;
        private StatusStrip statusStripDishForm;
        private ToolStripStatusLabel ToolStripStatusLabel;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem отчетToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem excelToolStripMenuItem;
    }
}