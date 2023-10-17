using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.KlokovIA.Sprint1.Task3.V2.Lib;

namespace Tyuiu.KlokovIA.Sprint1.Task3.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Клоков И. А. | ИСПБ-23-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #2                                                              *");
            Console.WriteLine("* Выполнил: Клоков И. А. | ИСПБ-23-1                                      *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
            Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            double priceNotebook;
            int amountNotebook;
            double pricePencil;
            int amountPencil;

            Console.WriteLine("Введите cтоимость одной тетради = ");
            priceNotebook = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите колличество тетрадей = ");
            amountNotebook = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите cтоимость одной ручки = ");
            pricePencil = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите колличество ручек = ");
            amountPencil = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ                                                               *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Стоимость покупки тетрадей и ручек = " + ds.PurchaseAmount(priceNotebook, amountNotebook, pricePencil, amountPencil));

            Console.ReadKey();
        }
    }
}
