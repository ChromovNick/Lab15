using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    class ArithProgression : ISeries
    {
        int step;
        int currentValue;
        int startValue;

        public int getNext()
        {
            currentValue += step;
            return currentValue;
        }

        public void reset()
        {
            currentValue = startValue;
        }

        public void setStart()
        {
            Console.WriteLine("Введите начальное значение ряда арифметической прогрессии");
            startValue = Convert.ToInt32(Console.ReadLine());
            currentValue = startValue;
        }
        public void setStep()
        {
            Console.WriteLine("Введите шаг арифметическоей прогрессии");
            step = Convert.ToInt32(Console.ReadLine());
        }
    }
}
