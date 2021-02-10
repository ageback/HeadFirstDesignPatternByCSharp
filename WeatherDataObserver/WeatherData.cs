using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDataObserver
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;
        public WeatherData()
        {
            observers = new List<IObserver>();
        }
        public void NotifyObservers()
        {
            foreach(var o in observers)
            {
                o.Update(temperature, humidity, pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(IObserver o)
        {
            if (observers.Count > 0) observers.Remove(o);
        }

        /// <summary>
        /// 当从气象站得到更新观测值时，通知观察者。
        /// </summary>
        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        /// <summary>
        /// 设置温度、湿度、气压，用于更改数据进行测试。
        /// </summary>
        /// <param name="temperature"></param>
        /// <param name="humidity"></param>
        /// <param name="pressure"></param>
        public void SetMeasurements(float temperature,float humidity,float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
