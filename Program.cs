using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_15
{
    class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression();
            arith.setStart();
            arith.setStep();
            Console.WriteLine("Первые 3 члена арифметической прогрессии:");
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine("Сброс");
            arith.reset();
            Console.WriteLine("Проверка:");
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine(arith.getNext());
            Console.WriteLine();
            GeomProgression geomProgression = new GeomProgression();
            geomProgression.setStart();
            geomProgression.setStep();
            Console.WriteLine("Первые 3 члена геометрической прогрессии:");
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine("Сброс");
            geomProgression.reset();
            Console.WriteLine("Проверка:");
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.WriteLine(geomProgression.getNext());
            Console.ReadKey();

        }
    }
}
