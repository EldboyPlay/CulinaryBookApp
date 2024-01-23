using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CulinaryBookApp
{
    public partial class Form1 : Form
    {
        // private SqlConnection? sqlConnection = null; // коннект переменная))

        public Form1()
        {
            InitializeComponent();
        }

        // Обработчик события формы главной
        private void Form1_Load(object sender, EventArgs e)
        {
            // =============== Тест подключения к БД ==================

            //sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString);

            //try
            //{
            //    sqlConnection.Open();
            //    if (sqlConnection.State == ConnectionState.Open)
            //    {
            //        MessageBox.Show("Подключение установлено!");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Ошибка подключения: " + ex.Message);
            //}
        }


        // ======================= НАСТРОЙКА ОТКРЫТИЯ ФОРМ =======================

        //Открытие первой формы

        private async void button1_Click(object sender, EventArgs e)
        {
            // Плавное исчезновение главной формы
            for (double i = 1.0; i >= 0.0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(5); // Задержка в 50 мс
            }

            // Создаем и открываем вторую форму
            DishForm dishForm = new DishForm();
            dishForm.Show();

            // Скрываем текущую форму после анимации исчезновения
            this.Hide();

            // Сброс прозрачности, если пользователь вернется на эту форму
            this.Opacity = 1.0;

            // Подписываемся на событие закрытия второй формы
            dishForm.FormClosed += (s, args) =>
            {
                // Плавное появление главной формы
                for (double i = 0.0; i <= 1.0; i += 0.1)
                {
                    this.Opacity = i;
                    this.Show(); // Показываем главную форму
                    Task.Delay(3).Wait(); // Задержка в 50 мс
                }
            };
        }


        //Открытие второй формы
        private async void button2_Click(object sender, EventArgs e)
        {
            // Плавное исчезновение главной формы
            for (double i = 1.0; i >= 0.0; i -= 0.1)
            {
                this.Opacity = i;
                await Task.Delay(5); // Задержка в 50 мс
            }

            // Создаем и открываем вторую форму
            FormProduct formProduct = new FormProduct(); // Обратите внимание на правильное написание имен переменных
            formProduct.Show();

            // Скрываем текущую форму после анимации исчезновения
            this.Hide();

            // Сброс прозрачности, если пользователь вернется на эту форму
            this.Opacity = 1.0;

            // Подписываемся на событие закрытия второй формы
            formProduct.FormClosed += (s, args) =>
            {
                // Плавное появление главной формы
                for (double i = 0.0; i <= 1.0; i += 0.1)
                {
                    this.Opacity = i;
                    this.Show(); // Показываем главную форму
                    Task.Delay(3).Wait(); // Задержка в 50 мс
                }
            };
        }



        //Открытие третьей формы




        private void button3_Click(object sender, EventArgs e)
        {
            // Код для выхода из приложения
            Application.Exit();
        }


        private void ВыходToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ПоискToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            // Создаем и настраиваем форму для ввода поискового запроса
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Поиск",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Введите название или часть названия:" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            // Отображаем форму как диалоговое окно
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                // Здесь логика поиска и отображения результатов в будущих обновлениях!!!!
                string query = textBox.Text;
                // Вы можете вызвать метод поиска, который вернет результаты в зависимости от запроса
                // Например, SearchData(query), который должен быть реализован в вашем приложении
                // Результаты поиска могут быть отображены на новой форме или в существующем DataGridView
            }
        }



        private void ПомощьToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Руководство по использованию приложения 'Поваренная книга':\n\n" +
                "1. Управление блюдами:\n" +
                "- 'Добавить': Для добавления нового блюда, введите данные в соответствующие поля и нажмите кнопку 'Добавить'.\n" +
                "- 'Изменить': Выберите блюдо из списка, измените необходимые данные и нажмите 'Изменить'.\n" +
                "- 'Удалить': Выберите блюдо из списка и нажмите 'Удалить', чтобы удалить его из базы данных.\n" +
                "- 'Очистить': Нажмите, чтобы очистить форму ввода для добавления нового блюда.\n\n" +
                "2. Управление продуктами:\n" +
                "- Действия аналогичны управлению блюдами, но применяются к продуктам.\n\n" +
                "3. Экспорт данных:\n" +
                "- Используйте функцию 'Отчет' в меню, чтобы экспортировать данные в Excel.\n\n" +
                "4. Дополнительная информация:\n" +
                "- В меню 'Файл' вы можете выйти из приложения.\n" +
                "- В разделе 'Справка' доступна информация о приложении.\n\n" +
                "При возникновении вопросов или проблем обращайтесь в службу поддержки или используйте контактную информацию в разделе 'О программе'.",
                "Помощь по программе 'Поваренная книга'",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }


        private void ОПрограммеToolStripMenuItem_Click_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Поваренная книга v1.0\n" +
                "Дата разработки: Январь 2024\n\n" +
                "Описание:\n" +
                "'Поваренная книга' - это современное интерактивное приложение для управления кулинарными рецептами. " +
                "Оно позволяет пользователям просматривать, добавлять, редактировать и удалять информацию о блюдах и продуктах. " +
                "\n\nОсновные функции:\n" +
                "- Управление блюдами: добавление, редактирование и удаление данных о блюдах.\n" +
                "- Управление продуктами: управление информацией о продуктах, используемых в блюдах.\n" +
                "- Экспорт данных: возможность создания отчетов и экспорта данных в формате Excel.\n\n" +
                "Разработчик: Артур\n\n" +
                "© 2024 Поваренная книга. Все права защищены.",
                "О программе 'Поваренная книга'",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}
