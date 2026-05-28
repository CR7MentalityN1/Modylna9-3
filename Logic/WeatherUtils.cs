namespace ModuleWork3.Logic;

public static class WeatherUtils {
    public static void CheckWeather((string day, string weather) tuple) {
        var (day, weather) = tuple;
        if (day == "Воскресенье" && weather == "солнечно") Console.WriteLine("Идти гулять");
        // ... остальная логика из задания
    }
}