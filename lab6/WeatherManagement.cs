using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    public class WeatherManagement
    {
        private WeatherApp[] _weatherApp; 
        public WeatherApp[] WeatherApp { get { return _weatherApp; } }

        //конструктор по умолчанию, кторый иннициализирует объект пустым массивом
        public WeatherManagement()
        {
            _weatherApp = Array.Empty<WeatherApp>();
        }

        //конструктор, принимающий переменное число объектов WeatherApp в качестве параметров
        public WeatherManagement(params WeatherApp[] weather)
        {
            _weatherApp = weather; 
        }

        //метод для добавления нового прогноза погоды
        public void AddForecast(WeatherApp weatherApp)
        {
            Array.Resize(ref _weatherApp, _weatherApp.Length + 1); // увеличение размера массива
            _weatherApp[^1] = weatherApp; // добавление нового прогноза в конец массива
        }
        // метод для удаления прогноза погоды по индексу
        public void RemoveForecast(int index)
        {
            if (index >= 0 && index < _weatherApp.Length) //проверка корректности индекса
            {
                for (int i = index; i < _weatherApp.Length - 1; i++)
                {
                    _weatherApp[i] = _weatherApp[i + 1]; //сдвиг элементов для удаления
                }
                Array.Resize(ref _weatherApp, _weatherApp.Length - 1); //уменьшение размера массива
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range"); 
            }
        }
        // метод для реактирования прогноза погоды по индексу
        public void EditForecast(int index, WeatherApp newWeatherApp)
        {
            if (index >= 0 && index < _weatherApp.Length) //проверка корректности индекса
            {
                _weatherApp[index] = newWeatherApp; // замена прогноза по указанному индексу
            }
            else
            {
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }
      // ме од для вывода масива на екран
        public override string ToString()
        {
            StringBuilder result = new StringBuilder(); //создание объекта StringBuilder для построения строки

            foreach (var weather in _weatherApp)
            {
                result.AppendLine(weather.ToString()); //добавление строки каждого прогноза в StringBuilder
            }
            return result.ToString(); 
        }
    }

}
