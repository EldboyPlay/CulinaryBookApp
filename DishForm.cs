using System;
using System.Windows.Forms;
using System.Data; 
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;


namespace CulinaryBookApp
{
    public partial class DishForm : Form
    {
        public DishForm()
        {
            InitializeComponent();
            InitializeStatusStripEventHandlers();

        }

        private void InitializeStatusStripEventHandlers()
        {
            // Пример добавления обработчика события MouseHover для кнопки
            buttonAdd_Click.MouseHover += (sender, e) => UpdateStatusStrip("Добавить новое блюдо.");
            button1.MouseHover += (sender, e) => UpdateStatusStrip("Изменить выбранное блюдо.");
            buttonClear_Click.MouseHover += (sender, e) => UpdateStatusStrip("Очистить поля ввода.");
            buttonDelete_Click.MouseHover += (sender, e) => UpdateStatusStrip("Удалить выбранное блюдо.");

            // Пример добавления обработчика события Click для кнопки
            buttonAdd_Click.Click += (sender, e) => UpdateStatusStrip("Добавление блюда...");
            button1.Click += (sender, e) => UpdateStatusStrip("Изменение блюда...");
            buttonClear_Click.Click += (sender, e) => UpdateStatusStrip("Очистка полей...");
            buttonDelete_Click.Click += (sender, e) => UpdateStatusStrip("Удаление блюда...");

            // Добавление обработчика события MouseHover для GroupBox
            groupBoxDishDetails.MouseHover += (sender, e) => UpdateStatusStrip("Просмотр и редактирование деталей блюда.");

            // Добавление обработчика события MouseHover для GroupBox
            dataGridViewDishes.MouseHover += (sender, e) => UpdateStatusStrip("Информация отображения данных в БД.");
        }

        private void UpdateStatusStrip(string message)
        {
            ToolStripStatusLabel.Text = message;
        }


        private void DishForm_Load(object sender, EventArgs e)
        {
            LoadDishes();
        }

        private void LoadDishes()
        {
            DatabaseHelper db = new DatabaseHelper();
            dataGridViewDishes.DataSource = db.GetAllDishes();
            dataGridViewDishes.AutoResizeColumns(); // Опционально: автоматическое изменение размера колонок
        }

        private void dataGridViewDishes_SelectionChanged(object sender, EventArgs e)
        {
            // Проверяем, что текущая строка действительно выбрана
            if (dataGridViewDishes.CurrentRow != null)
            {
                // Обновляем текстовые поля значениями из выбранной строки в DataGridView
                textBoxDishCode.Text = dataGridViewDishes.CurrentRow.Cells["DishCodeColumn"].Value?.ToString() ?? "";
                textBoxDishType.Text = dataGridViewDishes.CurrentRow.Cells["DishTypeColumn"].Value?.ToString() ?? "";
                textBoxDishWeight.Text = dataGridViewDishes.CurrentRow.Cells["DishWeightColumn"].Value?.ToString() ?? "";
                textBoxCookingOrder.Text = dataGridViewDishes.CurrentRow.Cells["CookingOrderColumn"].Value?.ToString() ?? "";
                textBoxCalories.Text = dataGridViewDishes.CurrentRow.Cells["CaloriesColumn"].Value?.ToString() ?? "";
                textBoxCarbohydrates.Text = dataGridViewDishes.CurrentRow.Cells["CarbohydratesColumn"].Value?.ToString() ?? "";

                // Если какие-то значения в ячейках будут null, используем оператор "??", чтобы заменить null на пустую строку
            }
        }

        private void buttonAdd_Click_Click(object sender, EventArgs e)
        {
            // Преобразование входных данных в подходящие типы данных
            int dishWeight = int.Parse(textBoxDishWeight.Text); // Предполагается, что вес - это целое число
            int calories = int.Parse(textBoxCalories.Text);
            int carbohydrates = int.Parse(textBoxCarbohydrates.Text);

            // Создаем экземпляр класса DatabaseHelper и вызываем метод добавления
            DatabaseHelper db = new DatabaseHelper();
            db.AddDish(textBoxDishType.Text, dishWeight, textBoxCookingOrder.Text, calories, carbohydrates);

            // Перезагрузка данных из базы данных для отображения новой записи
            LoadDishes();
        }


        private void buttonClear_Click_Click(object sender, EventArgs e)
        {
            // Очистка всех текстовых полей
            textBoxDishCode.Clear();
            textBoxDishType.Clear();
            textBoxDishWeight.Clear();
            textBoxCookingOrder.Clear();
            textBoxCalories.Clear();
            textBoxCarbohydrates.Clear();
        }


        private void buttonDelete_Click_Click(object sender, EventArgs e)
        {
            if (dataGridViewDishes.CurrentRow != null)
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить выбранное блюдо?", "Удаление блюда", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    int dishCode = int.Parse(dataGridViewDishes.CurrentRow.Cells["DishCodeColumn"].Value.ToString());
                    DatabaseHelper db = new DatabaseHelper();
                    db.DeleteDish(dishCode);

                    // Перезагрузка данных из базы данных
                    LoadDishes();
                }
            }
        }
        // Кнопка изменить
        private void button1_Click(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка в DataGridView
            if (dataGridViewDishes.CurrentRow == null)
            {
                MessageBox.Show("Выберите блюдо для изменения");
                return;
            }

            // Получаем DishCode выбранного блюда
            int dishCode = Convert.ToInt32(dataGridViewDishes.CurrentRow.Cells["DishCodeColumn"].Value);

            // Получаем остальные данные из текстовых полей
            string dishType = textBoxDishType.Text;
            int dishWeight = Convert.ToInt32(textBoxDishWeight.Text); // Пример, если вес - это число
            string cookingOrder = textBoxCookingOrder.Text;
            int calories = Convert.ToInt32(textBoxCalories.Text);
            int carbohydrates = Convert.ToInt32(textBoxCarbohydrates.Text);

            // Создаем экземпляр класса DatabaseHelper и вызываем метод обновления
            DatabaseHelper db = new DatabaseHelper();
            db.UpdateDishInDatabase(dishCode, dishType, dishWeight, cookingOrder, calories, carbohydrates);

            // Обновляем данные в DataGridView
            LoadDishes();
        }


        //  // Кнопка выход в меню
        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Код для выхода из приложения
            Application.Exit();
            // Или если нужно закрыть только текущую форму
            // this.Close();
        }


        // Кнопка справка в меню формы
        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Программа 'Управление блюдами' позволяет пользователю просматривать, добавлять, редактировать и удалять информацию о блюдах в базе данных.\n\n" +
                "Функции программы:\n" +
                "- 'Добавить': позволяет ввести данные о новом блюде и добавить их в базу данных.\n" +
                "- 'Изменить': для редактирования данных о существующем блюде. Для этого необходимо выбрать блюдо из списка.\n" +
                "- 'Удалить': удаляет выбранное блюдо из базы данных.\n" +
                "- 'Очистить': очищает форму ввода данных для внесения новой информации о блюде.\n\n" +
                "Для работы с данными выберите нужное действие в меню приложения или используйте соответствующие кнопки на форме.\n\n" +
                "Для получения более подробной информации обратитесь к документации пользователя или свяжитесь с поддержкой.",
                "Справка по программе 'Управление блюдами'",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
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

        // Кнопка отчета с меню
        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportToExcel(dataGridViewDishes);
        }

    }
}
