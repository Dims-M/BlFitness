using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


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


        static void RabList()
        {

            var list = new List<Road>();
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
                    Console.WriteLine("Четное число");
                    Console.WriteLine($"Текущие значение {result} является остатком от деления");
                }
                else
                {
                    Console.WriteLine("Нечетное число");
                    Console.WriteLine("Число не явдяется целым числом");
                }

                //Проверка результата деления 2 чисел.
                int h = 182;
                h.isDivided(7);

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
         

    }
}
