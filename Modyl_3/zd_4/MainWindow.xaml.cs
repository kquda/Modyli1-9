using System;
using System.Collections.Generic;
using System.Windows;

namespace DataFilterApp
{
    public partial class MainWindow : Window
    {
        private List<string> dataList; // Список данных
        private DataFilter dataFilter; // Экземпляр DataFilter

        public MainWindow()
        {
            InitializeComponent();
            dataFilter = new DataFilter();
            dataList = new List<string>
            {
                "2024-10-01 - Задача 1",
                "2024-10-02 - Задача 2",
                "2024-10-01 - Задача 3",
                "2024-10-03 - Задача 4",
                "2024-10-04 - Задача 5"
            };
            UpdateDataList(dataList); // Изначально показываем все данные
        }

        // Обновление списка данных на экране
        private void UpdateDataList(List<string> filteredData)
        {
            DataListBox.Items.Clear(); // Очищаем предыдущие элементы
            foreach (var data in filteredData)
            {
                DataListBox.Items.Add(data); // Добавляем отфильтрованные элементы
            }
        }

        // Фильтрация данных по ключевым словам
        private void KeywordFilterButton_Click(object sender, RoutedEventArgs e)
        {
            string keyword = KeywordTextBox.Text; // Получаем текст из текстового поля
            DataFilter.FilterDelegate filter = data => dataFilter.KeywordFilter(data, keyword);
            var filteredData = dataFilter.FilterData(dataList, filter); // Фильтруем данные
            UpdateDataList(filteredData); // Обновляем список
        }

        // Фильтрация данных по дате
        private void DateFilterButton_Click(object sender, RoutedEventArgs e)
        {
            if (DateTime.TryParse(DateTextBox.Text, out var date)) // Проверяем правильность ввода даты
            {
                DataFilter.FilterDelegate filter = data => dataFilter.DateFilter(data, date);
                var filteredData = dataFilter.FilterData(dataList, filter);
                UpdateDataList(filteredData);
            }
            else
            {
                MessageBox.Show("Некорректный формат даты. Пожалуйста, используйте формат yyyy-MM-dd."); // Сообщение об ошибке
            }
        }
    }
}
