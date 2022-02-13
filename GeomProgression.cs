using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    class GeomProgression : ISeries
    {
        int step;
        int currentValue;
        int startValue;

        public int getNext()
        {
            currentValue *= step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart()
        {
            Console.WriteLine("Введите начальное значение ряда геометрической прогрессии");
            startValue = Convert.ToInt32(Console.ReadLine());
            currentValue = startValue;
        }
        public void setStep()
        {
            Console.WriteLine("Введите шаг геометрической прогрессии");
            step = Convert.ToInt32(Console.ReadLine());
        }
    }
}
