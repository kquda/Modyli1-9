using System;
using System.Collections.Generic;
using System.Linq;

namespace DataFilterApp
{
    public class DataFilter
    {
        public delegate bool FilterDelegate(string data);

        // Метод для фильтрации данных
        public List<string> FilterData(List<string> data, FilterDelegate filter)
        {
            return data.Where(d => filter(d)).ToList();
        }

        // Фильтр по ключевым словам
        public bool KeywordFilter(string data, string keyword)
        {
            return data.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0;
        }

        // Фильтр по дате (допустим, данные имеют формат "yyyy-MM-dd")
        public bool DateFilter(string data, DateTime date)
        {
            return DateTime.TryParse(data.Substring(0, 10), out var parsedDate) && parsedDate.Date == date.Date; // Предполагаем, что дата - это первые 10 символов
        }
    }
}
