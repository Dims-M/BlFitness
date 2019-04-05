using System;
using System.Collections;

namespace TestConsolle2
{

    /// <summary>
    /// Класс для методов разширений
    /// </summary>
  public static class Helper
    {
        /// <summary>
        /// Проверяем является ли число целым. Может ли оно иметь остаток от деления.Возращает булевское значение.
        /// </summary>
        /// <param name="value">Число</param>
        /// <returns></returns>
      public  static bool IsEven(this int value) // c помощ this мы явно укажем что для всех методов нужно использовать интовые параметры
        {
            Console.WriteLine("Проверяем  остаток на деление.");

            return value % 2 == 0; // проверяем  остаток на деление. 
        }

        /// <summary>
        /// Остается ли отстаток при делении 2 чисел.
        /// </summary>
        /// <param name="i">ТекущиеЧисло</param>
        /// <param name="j">Число на кокое делим</param>
        /// <returns></returns>
        public static bool isDivided( this int i, int j)
        {
            Console.WriteLine($"Проверяем  остаток на деление 2 чисел. \t\n" +
                $"Основное число{i} делим на {j} \t\n" +
                $"Результат ={i % j}, {i % j == 0}");
            return i % j == 0; // проверяем  делится на остаток
        }

        /// <summary>
        /// Приведение любой коллекции к строке.
        /// </summary>
        /// <param name="collection">Нужная коллекция</param>
        /// <returns></returns>
        public static string CovencertToString( this IEnumerable collection)
        {
            var result = "";
            foreach (var item in collection)
            {
                result += item.ToString()+"," ;
            }
            return result;
        }


        //Методы разширения для класса Road

        public static Road CreateRandomRoad(this Road road, int min, int max)
        {
            var Road 
            return null;
        }
    }
}
