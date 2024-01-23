using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CulinaryBookApp
{
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
            // InitializeStatusStripEventHandlers();
        }

        private void FormProduct_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            DatabaseHelper db = new DatabaseHelper();
            dataGridViewProduct.DataSource = db.GetAllProducts();
            dataGridViewProduct.AutoResizeColumns();
        }






        // Место для реализации StatusStrip в нижней части формы



        private void dataGridViewProduct_CellContentClick(object sender, EventArgs e)
        {
            if (dataGridViewProduct.CurrentRow != null)
            {
                textBoxProductCode.Text = dataGridViewProduct.CurrentRow.Cells["ProductCode"].Value?.ToString() ?? "";
                textBoxProductName.Text = dataGridViewProduct.CurrentRow.Cells["ProductName"].Value?.ToString() ?? "";
                textBoxProductVolume.Text = dataGridViewProduct.CurrentRow.Cells["ProductVolume"].Value?.ToString() ?? "";
                textBoxUnitOfMeasure.Text = dataGridViewProduct.CurrentRow.Cells["UnitOfMeasure"].Value?.ToString() ?? "";
            }
        }

        private void dataGridViewProduct_SelectionChanged(object sender, EventArgs e)
        {
            // Проверяем, что есть выбранные строки
            if (dataGridViewProduct.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewProduct.SelectedRows[0];
                textBoxProductCode.Text = selectedRow.Cells["ProductCode"].Value?.ToString() ?? "";
                textBoxProductName.Text = selectedRow.Cells["ProductName"].Value?.ToString() ?? "";
                textBoxProductVolume.Text = selectedRow.Cells["ProductVolume"].Value?.ToString() ?? "";
                textBoxUnitOfMeasure.Text = selectedRow.Cells["UnitOfMeasure"].Value?.ToString() ?? "";
            }
        }


        // Функция для формирования документа Excel
        private void ExportToExcel(DataGridView dataGridView)
        {
            if (dataGridView == null || dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Нет данных для экспорта.");
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx", FileName = "" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var package = new ExcelPackage())
                    {
                        var worksheet = package.Workbook.Worksheets.Add("Отчет");

                        // Добавляем заголовки
                        for (int i = 0; i < dataGridView.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1].Value = dataGridView.Columns[i].HeaderText;
                            worksheet.Cells[1, i + 1].Style.Font.Bold = true;
                            worksheet.Cells[1, i + 1].Style.Fill.PatternType = OfficeOpenXml.Style.ExcelFillStyle.Solid;
                            worksheet.Cells[1, i + 1].Style.Fill.BackgroundColor.SetColor(Color.LightBlue);
                            worksheet.Cells[1, i + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                        }

                        // Добавляем данные
                        for (int i = 0; i < dataGridView.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value?.ToString() ?? "";
                            }
                        }

                        // Авто-ширина колонок
                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        // Границы для ячеек
                        worksheet.Cells[worksheet.Dimension.Address].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        worksheet.Cells[worksheet.Dimension.Address].Style.Border.Left.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        worksheet.Cells[worksheet.Dimension.Address].Style.Border.Right.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
                        worksheet.Cells[worksheet.Dimension.Address].Style.Border.Bottom.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;

                        // Сохраняем файл
                        var fileStream = new FileStream(sfd.FileName, FileMode.Create);
                        package.SaveAs(fileStream);
                        fileStream.Close();

                        MessageBox.Show("Отчет успешно сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridViewProduct);
        }


        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Код для выхода из приложения
            Application.Exit();
            // Или если нужно закрыть только текущую форму
            // this.Close();
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программа 'Управление продуктами' предоставляет возможности по просмотру, добавлению, редактированию и удалению информации о продуктах в базе данных.\n\n" +
                "Основные функции программы:\n" +
                "- 'Добавить': позволяет ввести данные о новом продукте и добавить их в базу данных.\n" +
                "- 'Изменить': используется для редактирования данных о существующем продукте. Выберите продукт из списка для редактирования.\n" +
                "- 'Удалить': удаляет выбранный продукт из базы данных.\n" +
                "- 'Очистить': очищает поля ввода данных для внесения информации о новом продукте.\n\n" +
                "Для работы с данными выберите нужное действие в меню приложения или используйте соответствующие кнопки на форме.\n\n" +
                "За дополнительной информацией и поддержкой обращайтесь к документации пользователя или к службе поддержки.",
                "Справка по программе 'Управление продуктами'",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void buttonAdd_Click_Click(object sender, EventArgs e)
        {
            // Получаем данные из текстовых полей
            string productName = textBoxProductName.Text;
            int productVolume = int.Parse(textBoxProductVolume.Text); // Предполагается, что объем - это целое число
            string unitOfMeasure = textBoxUnitOfMeasure.Text;

            // Создаем экземпляр класса DatabaseHelper и вызываем метод добавления продукта
            DatabaseHelper db = new DatabaseHelper();
            db.AddProduct(productName, productVolume, unitOfMeasure);

            // Перезагрузка данных из базы данных для отображения новой записи
            LoadProducts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка в DataGridView
            if (dataGridViewProduct.CurrentRow == null)
            {
                MessageBox.Show("Выберите продукт для изменения");
                return;
            }

            // Получаем ProductCode выбранного продукта
            int productCode = Convert.ToInt32(dataGridViewProduct.CurrentRow.Cells["ProductCode"].Value);

            // Получаем остальные данные из текстовых полей
            string productName = textBoxProductName.Text;
            int productVolume = Convert.ToInt32(textBoxProductVolume.Text); // Пример, если объем - это число
            string unitOfMeasure = textBoxUnitOfMeasure.Text;

            // Создаем экземпляр класса DatabaseHelper и вызываем метод обновления
            DatabaseHelper db = new DatabaseHelper();
            db.UpdateProductInDatabase(productCode, productName, productVolume, unitOfMeasure);

            // Обновляем данные в DataGridView
            LoadProducts();
        }

        private void buttonClear_Click_Click(object sender, EventArgs e)
        {
            // Очистка всех текстовых полей
            textBoxProductCode.Clear();
            textBoxProductName.Clear();
            textBoxProductVolume.Clear();
            textBoxUnitOfMeasure.Clear();
        }

        private void buttonDelete_Click_Click(object sender, EventArgs e)
        {
            if (dataGridViewProduct.CurrentRow != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранный продукт?", "Удаление продукта", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int productCode = int.Parse(dataGridViewProduct.CurrentRow.Cells["ProductCode"].Value.ToString());
                    DatabaseHelper db = new DatabaseHelper();
                    db.DeleteProduct(productCode);

                    // Перезагрузка данных из базы данных
                    LoadProducts();
                }
            }
        }

    }
}

