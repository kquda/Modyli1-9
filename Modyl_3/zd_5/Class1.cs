using System;
using System.Collections.Generic;

namespace SortingApp
{
    public class SortingAlgorithms
    {
        // Делегат для методов сортировки
        public delegate List<int> SortDelegate(List<int> data);

        // Метод сортировки пузырьком
        public List<int> BubbleSort(List<int> data)
        {
            var sortedData = new List<int>(data);
            int n = sortedData.Count;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (sortedData[j] > sortedData[j + 1])
                    {
                        // Меняем местами
                        int temp = sortedData[j];
                        sortedData[j] = sortedData[j + 1];
                        sortedData[j + 1] = temp;
                    }
                }
            }
            return sortedData;
        }

        // Метод быстрой сортировки
        public List<int> QuickSort(List<int> data)
        {
            if (data.Count <= 1) return data;

            int pivot = data[data.Count / 2];
            var less = new List<int>();
            var equal = new List<int>();
            var greater = new List<int>();

            foreach (var number in data)
            {
                if (number < pivot) less.Add(number);
                else if (number == pivot) equal.Add(number);
                else greater.Add(number);
            }

            var sortedList = new List<int>();
            sortedList.AddRange(QuickSort(less));
            sortedList.AddRange(equal);
            sortedList.AddRange(QuickSort(greater));
            return sortedList;
        }
    }
}
