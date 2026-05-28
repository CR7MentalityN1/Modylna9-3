using System;
using System.Collections.Generic;
using ModuleWork3.Models;
using ModuleWork3.Logic;

namespace ModuleWork3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Проверка книг 
            Console.WriteLine("--- ПРОВЕРКА КНИГ ---");
            Book[] books = {
                new Textbook { Subject = "Математика" },
                new PoetryBook { IsDomesticAuthor = true },
                new Book(), 
                null,       
                new Textbook { Subject = "Физика" }
            };
            foreach (var b in books) { BookUtils.DescribeBook(b); }
 
            Console.WriteLine("\n--- ПРОВЕРКА ТОВАРОВ ---");
            Appliance[] items = {
                new Appliance { Category = "Ноутбук", Country = "Китай", Price = 1000 },
                new Appliance { Category = "Ноутбук", Country = "Германия", Price = 1000 },
                new Appliance { Category = "Планшет", Price = 500 },
                null,
                new Appliance { Category = "Холодильник", Price = 800 }
            };
            foreach (var item in items) { ApplianceUtils.ProcessAppliance(item); }
 
            Console.WriteLine("\n--- ПРОВЕРКА КОРТЕЖЕЙ ---");
            var weatherTuples = new[] {
                ("Воскресенье", "солнечно"),
                ("Воскресенье", ""),
                ("", "дождь"),
                ("", "снег"),
                ("Понедельник", "ясно")
            };
            foreach (var t in weatherTuples) { WeatherUtils.CheckWeather(t); }

            Console.WriteLine("\n--- ПРОВЕРКА СПИСКОВ ---");
            List<List<int>> lists = new() {
                new List<int> { 1, 2, 3, 4, 5 },
                new List<int> { 1, 10, 20 },
                new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 },
                new List<int> { 10, 20, 30 },
                new List<int> { }
            };
            foreach (var l in lists) { ListUtils.AnalyzeList(l); }
        }
    }
}