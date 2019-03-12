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

            #region Не успользуем
            //if (name.Length >= 3)
            //{
            //    var user = new User(name);
            //}


            //Console.WriteLine("Введите пол");
            //var gender = Console.ReadLine();

            //Console.WriteLine("Введите дату рождения");
            //var birthdate = DateTime.Parse(Console.ReadLine());
            ////TODO Переписать парсе даты рождения

            //Console.WriteLine("Введите вес"); // Используем обьекты Double.Parse для перевода строки в число 
            //var weight = double.Parse(Console.ReadLine());

            //Console.WriteLine("Введите рост");
            //var height = double.Parse(Console.ReadLine());
            #endregion

            //Создаем контроллер. Он же создает конкретный обьект. И так же сеарилует его.
           // var userController = new UserController(name, gender, birthdate, weight, height);
            var userController = new UserController(name);

            Console.WriteLine(userController.CurrentUser);
            //Console.WriteLine();

            if (userController.IsNewsUser)
            {
                 
            }

            Console.ReadKey(true);
        }
    }
}