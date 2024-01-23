using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CulinaryBookApp
{
    public partial class Form1 : Form
    {
        // private SqlConnection? sqlConnection = null; // ������� ����������))

        public Form1()
        {
            InitializeComponent();
        }

        // ���������� ������� ����� �������
        private void Form1_Load(object sender, EventArgs e)
        {
            // =============== ���� ����������� � �� ==================

            //sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            //try
            //{
            //    sqlConnection.Open();
            //    if (sqlConnection.State == ConnectionState.Open)
            //    {
            //        MessageBox.Show("����������� �����������!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("������ �����������: " + ex.Message);
            //}
        }


        // ======================= ��������� �������� ���� =======================

        //�������� ������ �����

        private async void button1_Click(object sender, EventArgs e)
        {
            // ������� ������������ ������� �����
            for (double i = 1.0; i >= 0.0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(5); // �������� � 50 ��
            }

            // ������� � ��������� ������ �����
            DishForm dishForm = new DishForm();
            dishForm.Show();

            // �������� ������� ����� ����� �������� ������������
            this.Hide();

            // ����� ������������, ���� ������������ �������� �� ��� �����
            this.Opacity = 1.0;

            // ������������� �� ������� �������� ������ �����
            dishForm.FormClosed += (s, args) =>
            {
                // ������� ��������� ������� �����
                for (double i = 0.0; i <= 1.0; i += 0.1)
                {
                    this.Opacity = i;
                    this.Show(); // ���������� ������� �����
                    Task.Delay(3).Wait(); // �������� � 50 ��
                }
            };
        }


        //�������� ������ �����
        private async void button2_Click(object sender, EventArgs e)
        {
            // ������� ������������ ������� �����
            for (double i = 1.0; i >= 0.0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(5); // �������� � 50 ��
            }

            // ������� � ��������� ������ �����
            FormProduct formProduct = new FormProduct(); // �������� �������� �� ���������� ��������� ���� ����������
            formProduct.Show();

            // �������� ������� ����� ����� �������� ������������
            this.Hide();

            // ����� ������������, ���� ������������ �������� �� ��� �����
            this.Opacity = 1.0;

            // ������������� �� ������� �������� ������ �����
            formProduct.FormClosed += (s, args) =>
            {
                // ������� ��������� ������� �����
                for (double i = 0.0; i <= 1.0; i += 0.1)
                {
                    this.Opacity = i;
                    this.Show(); // ���������� ������� �����
                    Task.Delay(3).Wait(); // �������� � 50 ��
                }
            };
        }



        //�������� ������� �����




        private void button3_Click(object sender, EventArgs e)
        {
            // ��� ��� ������ �� ����������
            Application.Exit();
        }


        private void �����ToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void �����ToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            // ������� � ����������� ����� ��� ����� ���������� �������
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "�����",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "������� �������� ��� ����� ��������:" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            // ���������� ����� ��� ���������� ����
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                // ����� ������ ������ � ����������� ����������� � ������� �����������!!!!
                string query = textBox.Text;
                // �� ������ ������� ����� ������, ������� ������ ���������� � ����������� �� �������
                // ��������, SearchData(query), ������� ������ ���� ���������� � ����� ����������
                // ���������� ������ ����� ���� ���������� �� ����� ����� ��� � ������������ DataGridView
            }
        }



        private void ������ToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "����������� �� ������������� ���������� '���������� �����':\n\n" +
                "1. ���������� �������:\n" +
                "- '��������': ��� ���������� ������ �����, ������� ������ � ��������������� ���� � ������� ������ '��������'.\n" +
                "- '��������': �������� ����� �� ������, �������� ����������� ������ � ������� '��������'.\n" +
                "- '�������': �������� ����� �� ������ � ������� '�������', ����� ������� ��� �� ���� ������.\n" +
                "- '��������': �������, ����� �������� ����� ����� ��� ���������� ������ �����.\n\n" +
                "2. ���������� ����������:\n" +
                "- �������� ���������� ���������� �������, �� ����������� � ���������.\n\n" +
                "3. ������� ������:\n" +
                "- ����������� ������� '�����' � ����, ����� �������������� ������ � Excel.\n\n" +
                "4. �������������� ����������:\n" +
                "- � ���� '����' �� ������ ����� �� ����������.\n" +
                "- � ������� '�������' �������� ���������� � ����������.\n\n" +
                "��� ������������� �������� ��� ������� ����������� � ������ ��������� ��� ����������� ���������� ���������� � ������� '� ���������'.",
                "������ �� ��������� '���������� �����'",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void ����������ToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "���������� ����� v1.0\n" +
                "���� ����������: ������ 2024\n\n" +
                "��������:\n" +
                "'���������� �����' - ��� ����������� ������������� ���������� ��� ���������� ����������� ���������. " +
                "��� ��������� ������������� �������������, ���������, ������������� � ������� ���������� � ������ � ���������. " +
                "\n\n�������� �������:\n" +
                "- ���������� �������: ����������, �������������� � �������� ������ � ������.\n" +
                "- ���������� ����������: ���������� ����������� � ���������, ������������ � ������.\n" +
                "- ������� ������: ����������� �������� ������� � �������� ������ � ������� Excel.\n\n" +
                "�����������: �����\n\n" +
                "� 2024 ���������� �����. ��� ����� ��������.",
                "� ��������� '���������� �����'",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
