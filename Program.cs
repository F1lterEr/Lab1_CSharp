using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Programб
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x: ");
            int x = Convert.ToInt32(Console.ReadLine()); //переменная x
            Console.WriteLine("Введите кол-во повторов: ");
            int steps = Convert.ToInt32(Console.ReadLine()); //кол-во повторов
            double n = -1; //множитель и степень
            int i = 0; //число для цикла
            double nk = 0; //переменная для функции
            while (i < steps){
                n++;
                n++; //+2 к степени и множителю
                double k =1 / (n * Math.Pow(x,n)); //сама функция
                nk += k;
                i++;
            }
            double result = 2 * nk;
            Console.WriteLine($"Ваш ответ: {result}");
            Console.ReadLine();
        }
    }
}
