using lab6;

internal class Program
{
    private static void Main(string[] args)
    {
        WeatherApp app = new WeatherForecastApp(23 ,12 ,43);
        WeatherApp app1 = new WeatherForecastApp(12, 9, 3);
        WeatherApp app2 = new WeatherForecastApp(1, 0, 2);
        WeatherApp app3 = new WeatherForecastApp(-15, 7, 38);
        WeatherApp newApp2 = new WeatherForecastApp(-1, 34, 12);

        app.SetUnits("Цельсия");
        app.GetWeather("Киев");       

        app1.SetUnits("Фаренгейта");
        app1.GetWeather("");

        app2.SetUnits("Кельвин");
        app2.GetWeather("Житомир");

        app3.SetUnits("Цельсия");
        app3.GetWeather("Львов");

        newApp2.SetUnits("Ранкин");
        newApp2.GetWeather("Житомир");
        WeatherManagement array = new WeatherManagement(app,app1, app3);

        Console.WriteLine("Исходный масив:");
        Console.WriteLine(array.ToString());

        array.AddForecast(app2);
        Console.WriteLine("После добавления:");
        Console.WriteLine(array.ToString());

        Console.WriteLine("После редактирования:");
        array.EditForecast(3, newApp2);
        Console.WriteLine(array.ToString());

        Console.WriteLine("После удаления:");
        array.RemoveForecast(0);
        Console.WriteLine(array.ToString());
    }
}