using System;


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
        /// <param name="i">Число</param>
        /// <param name="j">Делим на число</param>
        /// <returns></returns>
        public static bool isDivided( this int i, int j)
        {
            Console.WriteLine("Проверяем  остаток на деление.");
            return i % j == 0; // проверяем  делится на остаток
        }

    }
}
