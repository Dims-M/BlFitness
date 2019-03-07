using System;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Класс описывающий пользователя в программе.
    /// </summary>
    class User
    {
        public string Name { get;} //Только получаем свойства. Изменять не можем. Усанавливаем при создании экземпляра класса

        public Gender Cender { get; } // Пол пользователя.  Является классом со своими свойствами

        public DateTime BirthDate { get; } // Дата рождения

        public double Weight { get; set; } // Вес пользователя

        public double Height { get; set; } // рост

        private string textLpg = "Лог работы";
        private string textErrors = "Ошибки в работе:";


        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height)
        {
            //Проверки на коректные данные при создании пользователя
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(name));
                
            }
            Name = name;

            if (gender == null)
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900"))
            {
                throw new ArgumentException(""); 
            }

            if (weight <=0 )
            {

            }

            if (height <= 0)
            {

            }
        }

    }
}
