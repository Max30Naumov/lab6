using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class WeatherForecastApp : WeatherApp
    {
        public static readonly int MIN_TEMPERATURE = -80; //рекордная максимальная 
        public static readonly int MAX_TEMPERATURE = 50; //и рекордная минимальная тепмература в мире
        public static readonly int MAX_WIND_SPEED = 372; //372 км/год  было зафиксировано во время песчаной бури в Австралии

        private int temperature;
        private int humidity;
        private int windSpeed;
        public string Units;
        public  string Weather {  get; set; }
        public int Temperature { get => temperature; set => temperature = value >= MIN_TEMPERATURE && value <= MAX_TEMPERATURE ? value : throw new ArgumentOutOfRangeException(); } 
        public int Humidity { get => humidity; set => humidity = value >= 0 && value <= 100 ? value : throw new ArgumentOutOfRangeException(); } // обычно влажность определяется в процентах
        public int WindSpeed { get => windSpeed; set => windSpeed = value >= 0 && value <= MAX_WIND_SPEED ? value : throw new ArgumentOutOfRangeException(); } 
        public WeatherForecastApp(int temperature, int humidity, int windSpeed) : base()
        {
            Temperature = temperature;
            Humidity = humidity;
            WindSpeed = windSpeed;
        }
        //определяем погоду исходя из значений заданых в конструкторе
        public override void GetWeather(string location)
        {
            // проверяем location на null и Empty, если строка пустая - назначаем ей значение по умолчанию определенное в родительском классе
            if (!string.IsNullOrEmpty(location))
                 Weather = $"В {location} {Temperature} градуса по {Units}, влажность {Humidity}%, ветер {WindSpeed} км/час";
            else 
                Weather = $"В {DefaultLocation} {Temperature} градуса по {Units}, влажность {Humidity}%, ветер {WindSpeed} км/час";
        }

        public override void SetUnits(string units)
        {//проверка сттроки на пустоту и null
            if (!string.IsNullOrEmpty(units))
            {
                // Проверка, является ли строка одной из четырех допустимых единиц измерения
                if (units.Equals("Цельсия", StringComparison.OrdinalIgnoreCase) ||
                    units.Equals("Фаренгейта", StringComparison.OrdinalIgnoreCase) || 
                    units.Equals("Кельвин", StringComparison.OrdinalIgnoreCase) ||
                    units.Equals("Ранкин", StringComparison.OrdinalIgnoreCase)) 
                {
                    Units = units;
                }
                else
                {
                    throw new ArgumentException("Недопустима единица измерения. Введите 'Цельсия', 'Ранкин', 'Фаренгейта' или 'Кельвин'.");
                }
            } 
            else
            {         
                throw new ArgumentException("Значення не може бути пустим або null.");
            }
        }      

        public override string ToString()
        {
            return Weather;
        }
    }
}
