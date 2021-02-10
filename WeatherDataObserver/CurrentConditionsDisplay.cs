using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDataObserver
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject weatherData;
        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            // 把自己注册为观察者
            weatherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"目前状况：{temperature}华氏度，湿度% {humidity}");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.temperature = temp;
            this.humidity = humidity;
            Display();
        }
    }
}
