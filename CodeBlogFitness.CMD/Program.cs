using CodeBlogFitness.BL.Controller;
using CodeBlogFitness.BL.Model;
using System;


namespace CodeBlogFitness.CMD
{
    class Program
    {  
        // запуск программы
        static void Main(string[] args)
        {
            zapuskator();
        }

        /// <summary>
        /// Пробный тестовой запусковый метод
        /// </summary>
        public static void zapuskator()
        {
            Console.WriteLine("Вас привествует приложение х@na \t\nТЕСТОВОЙ ЗАпуск");

            Console.WriteLine("Введите имя пользователя");
            var name = Console.ReadLine();

            if (name.Length >=3)
            {
                var user = new User(name);
            }

            Console.WriteLine("Введите пол");
            var gender = Console.ReadLine();

            Console.WriteLine("Введите дату рождения");
            var birthdate = DateTime.Parse(Console.ReadLine());
            



        }

    }
}
