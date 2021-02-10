using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDataObserver
{
    public interface IObserver
    {
        public void Update(float temp, float humidity, float pressure);
    }
}
