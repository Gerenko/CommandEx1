using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandEx1
{
    class radioControl
    {
        public string turnOn()
        {
            // Включаем радио
            return "Включаем радио";
        }
        public string turnOff()
        {
            // Выключаем радио
            return "Выключаем радио";
         }
        public string tuneUp()
        {
            // Настраиваем  радио
            return "Ищем любимую мелодию";
        }
        public string tuneDown()
        {
            // Заканчиваем настройку радио
            return "Выбрали мелодию, слушаем";
        }
    }
}
