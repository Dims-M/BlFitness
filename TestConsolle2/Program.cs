using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper;

namespace TestConsolle2
{
    /// <summary>
    /// Тестовой класс 2
    /// </summary>
    class Program
    {

        static void Main(string[] args)
        {

            Zapuskator();
        }


        static void Zapuskator()
        {
            Console.WriteLine("ВВедите число");
            var tempint = Console.ReadLine();

            if (int.TryParse(tempint, out int result)) // в переменную result сохраняем спарсированное число из строки tempint 
            {
                // получаем булевый тим
                // var isEvenn =  IsEven(result);
                // var isEvenn = result.IsEven();

                //Вызываем булевский метод .IsEven() параметром является значение в переменной result
                if (result.IsEven()) // метод с помощью разширения. 
                {
                    Console.WriteLine($"Текущие значение {result} является остатком от деления");
                }
                else
                {
                    Console.WriteLine("Число не явдяется целым числом");
                }
                 
            }

            else
            {
                Console.WriteLine("Не корректные значения");
            }
            Console.ReadKey();
        }
        /// <summary>
        /// Проверяем на четность и нечетность числа
        /// </summary>
        /// <param name="i"></param>
        ///// <returns></returns>
        //    static bool IsEven(  int i)
        //    {
        //        Console.WriteLine("Проверяем  остаток на деление.");
            
        //        return i % 2 == 0; // проверяем  остаток на деление. 
        //    }

    }
}
