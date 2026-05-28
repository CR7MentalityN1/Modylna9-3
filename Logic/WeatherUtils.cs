namespace ModuleWork3.Logic;

public static class WeatherUtils 
{
    public static void CheckWeather((string day, string weather) tuple) 
    {
        var (day, weather) = tuple;

        if (day == "Воскресенье" && weather == "солнечно") 
            Console.WriteLine("Идти гулять");
        else if (day == "Воскресенье") 
            Console.WriteLine("Провести уборку");
        else if (weather == "дождь") 
            Console.WriteLine("Пойти готовить");
        else if (weather == "снег") 
            Console.WriteLine("Посмотреть фильм");
        else 
            Console.WriteLine("Заняться делами по работе");
    }
}