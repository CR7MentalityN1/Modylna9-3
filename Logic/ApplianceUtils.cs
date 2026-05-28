using ModuleWork3.Models; // Подключаем, чтобы видеть класс Appliance

namespace ModuleWork3.Logic;

public static class ApplianceUtils
{
    public static void ProcessAppliance(Appliance item)
    {
        if (item == null) 
        {
            Console.WriteLine("Продукт задан некорректно");
            return;
        }

        // Логика из таблицы задания (пункт 7 и 8)
        if (item.Category == "Ноутбук")
        {
            string discount = (item.Country == "Китай") ? "15%" : "10%";
            Console.WriteLine($"Ноутбук из {item.Country}: Скидка {discount}");
        }
        else if (item.Category == "Планшет")
        {
            decimal priceBefore = item.Price;
            decimal priceAfter = item.Price * 0.95m; // Скидка 5%
            Console.WriteLine($"Планшет: цена до {priceBefore}, после {priceAfter}");
        }
        else
        {
            Console.WriteLine("Скидки нет");
        }
    }
}