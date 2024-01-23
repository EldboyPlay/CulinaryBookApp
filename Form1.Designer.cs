namespace CulinaryBookApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            ВыходToolStripMenuItem_Click = new ToolStripMenuItem();
            ПоискToolStripMenuItem_Click = new ToolStripMenuItem();
            ПомощьToolStripMenuItem_Click = new ToolStripMenuItem();
            ОПрограммеToolStripMenuItem_Click = new ToolStripMenuItem();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            statusStrip1 = new StatusStrip();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label2 = new Label();
            label3 = new Label();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = SystemColors.GradientInactiveCaption;
            menuStrip1.Items.AddRange(new ToolStripItem[] { ВыходToolStripMenuItem_Click, ПоискToolStripMenuItem_Click, ПомощьToolStripMenuItem_Click, ОПрограммеToolStripMenuItem_Click });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(611, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // ВыходToolStripMenuItem_Click
            // 
            ВыходToolStripMenuItem_Click.Name = "ВыходToolStripMenuItem_Click";
            ВыходToolStripMenuItem_Click.Size = new Size(54, 20);
            ВыходToolStripMenuItem_Click.Text = "Выход";
            ВыходToolStripMenuItem_Click.Click += ВыходToolStripMenuItem_Click_Click;
            // 
            // ПоискToolStripMenuItem_Click
            // 
            ПоискToolStripMenuItem_Click.Name = "ПоискToolStripMenuItem_Click";
            ПоискToolStripMenuItem_Click.Size = new Size(54, 20);
            ПоискToolStripMenuItem_Click.Text = "Поиск";
            ПоискToolStripMenuItem_Click.Click += ПоискToolStripMenuItem_Click_Click;
            // 
            // ПомощьToolStripMenuItem_Click
            // 
            ПомощьToolStripMenuItem_Click.Name = "ПомощьToolStripMenuItem_Click";
            ПомощьToolStripMenuItem_Click.Size = new Size(68, 20);
            ПомощьToolStripMenuItem_Click.Text = "Помощь";
            ПомощьToolStripMenuItem_Click.Click += ПомощьToolStripMenuItem_Click_Click;
            // 
            // ОПрограммеToolStripMenuItem_Click
            // 
            ОПрограммеToolStripMenuItem_Click.Name = "ОПрограммеToolStripMenuItem_Click";
            ОПрограммеToolStripMenuItem_Click.Size = new Size(94, 20);
            ОПрограммеToolStripMenuItem_Click.Text = "О программе";
            ОПрограммеToolStripMenuItem_Click.Click += ОПрограммеToolStripMenuItem_Click_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ImageAlign = ContentAlignment.TopCenter;
            label1.Location = new Point(219, 29);
            label1.Name = "label1";
            label1.Size = new Size(233, 32);
            label1.TabIndex = 1;
            label1.Text = "Добро пожаловать!";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.лого;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(8, 36);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(214, 230);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // statusStrip1
            // 
            statusStrip1.BackColor = SystemColors.Control;
            statusStrip1.Location = new Point(0, 295);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(611, 22);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Info;
            button1.Location = new Point(373, 117);
            button1.Name = "button1";
            button1.Size = new Size(222, 41);
            button1.TabIndex = 4;
            button1.Text = "Управление блюдами";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Info;
            button2.Location = new Point(373, 164);
            button2.Name = "button2";
            button2.Size = new Size(222, 40);
            button2.TabIndex = 5;
            button2.Text = "Управление продуктами";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.Info;
            button3.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(429, 210);
            button3.Name = "button3";
            button3.Size = new Size(100, 41);
            button3.TabIndex = 6;
            button3.Text = "Выйти";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label2.Location = new Point(429, 93);
            label2.Name = "label2";
            label2.Size = new Size(119, 17);
            label2.TabIndex = 7;
            label2.Text = "Меню приложения:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 265);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 8;
            label3.Text = "©️ Поваренная книга";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(611, 317);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(statusStrip1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Приложение \"Поваренная книга\"";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private PictureBox pictureBox1;
        private StatusStrip statusStrip1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label2;
        private Label label3;
        private ToolStripMenuItem ВыходToolStripMenuItem_Click;
        private ToolStripMenuItem ПоискToolStripMenuItem_Click;
        private ToolStripMenuItem ПомощьToolStripMenuItem_Click;
        private ToolStripMenuItem ОПрограммеToolStripMenuItem_Click;
    }
}
