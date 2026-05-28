using System;
using System.Collections.Generic;

namespace ModuleWork3.Logic;

public static class ListUtils 
{
    public static void AnalyzeList(List<int> list) 
    {
        if (list.Count == 5)
        {
            var first = list[0];
            var second = list[1];
            var last = list[4];
            Console.WriteLine($"Элементы списка: {first}, {second}, {last}");
        }

       string result = list switch
{
    [1, 2, 3, 4, 5] => "Полное совпадение",
    
    [1, .., 9] => "Список содержит все числа от 1 до 9",
    
    [1, ..] => "Список начинается с 1",
    [] => "Уникальный список",
    
    _ => "Другой случай"
};

        Console.WriteLine(result);
    }
}