using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using static SortingApp.SortingAlgorithms;

namespace SortingApp
{
    public partial class MainWindow : Window
    {
        private SortingAlgorithms sortingAlgorithms; // Экземпляр класса сортировки

        public MainWindow()
        {
            InitializeComponent();
            sortingAlgorithms = new SortingAlgorithms();
        }

        // Обработчик кнопки сортировки
        private void SortButton_Click(object sender, RoutedEventArgs e)
        {
            // Получаем входные данные и преобразуем их в список целых чисел
            string input = InputTextBox.Text;
            var data = input.Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries)
                             .Select(x => int.TryParse(x, out int num) ? num : 0).ToList();

            // Получаем выбранный метод сортировки
            SortDelegate sortMethod;
            if (SortingMethodComboBox.SelectedIndex == 0) // Сортировка пузырьком
            {
                sortMethod = sortingAlgorithms.BubbleSort;
            }
            else // Быстрая сортировка
            {
                sortMethod = sortingAlgorithms.QuickSort;
            }

            // Сортируем данные
            var sortedData = sortMethod(data);
            UpdateSortedDataList(sortedData); // Обновляем отображение отсортированных данных

            // Очищаем текстовое поле для нового ввода
            InputTextBox.Clear();
        }

        // Обновление списка отсортированных данных на экране
        private void UpdateSortedDataList(List<int> sortedData)
        {
            SortedDataListBox.Items.Clear(); // Очищаем предыдущие элементы
            foreach (var number in sortedData)
            {
                SortedDataListBox.Items.Add(number); // Добавляем отсортированные элементы
            }
        }
    }
}
