using System;
using System.Collections.Generic;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Класс, описывающий пользователя в программе.
    /// </summary>
    
     [Serializable] 
   public class User
    {
        #region Свойства класса. Переменыые
        public string Name { get;} //Только получаем свойства. Изменять не можем. Усанавливаем при создании экземпляра класса

        public Gender Cender { get; set; } // Пол пользователя.  Является классом со своими свойствами

        public DateTime BirthDate { get; set; } // Дата рождения

        public double Weight { get; set; } // Вес пользователя

        public double Height { get; set; } // рост

        /// <summary>
        /// возращаем значения полученными путем вычисления текущей даты и вычитанием введеной даты дня рождения
        /// </summary>
        public int Age { get { return DateTime.Now.Year - BirthDate.Year; } }

        #endregion

        private string textLpg = "Лог работы";
        private string textErrors = "Ошибки в работе:";

        //Конструктор по умолчанию
        public User(string name) 
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Не коректное имя", nameof(name));
            }
            else
            {
                Name = name;
            }
           
        }
        
        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height)
        #region Проверки на коректные данные при создании пользователя
        {
            //Проверки на коректные данные при создании пользователя
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("Имя пользователя не может быть пустым", nameof(name));
                
            }
            Name = name;

            if (gender == null)
            {
                throw new ArgumentNullException("Пол пользователя не может быть пустым", nameof(gender));
            }

            if (birthDate < DateTime.Parse("01.01.1900") || birthDate >= DateTime.Now )
            {
                throw new ArgumentException("Некоректнная дата рождения",nameof(birthDate)); 
            }

            //проверка веса пользователя
            if (weight <=0 )
            {
                throw new ArgumentException("Вес не должен быть меньше 0", nameof(weight));
            }
            //проверка роста пользователя
            if (height <= 0)
            {
                throw new ArgumentException("Рост не должен быть меньше 0", nameof(height));
            }

            #endregion
        }

        /// <summary>
        /// Переобределенный метод ToString класса User
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return  Name + " " + Age;
        }

      
    }
}
