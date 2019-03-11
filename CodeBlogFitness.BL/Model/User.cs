using System;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Класс описывающий пользователя в программе.
    /// </summary>
    /// [Serializable]
   public class User
    {
        #region Свойства класса. Переменыые
        public string Name { get;} //Только получаем свойства. Изменять не можем. Усанавливаем при создании экземпляра класса

        public Gender Cender { get; } // Пол пользователя.  Является классом со своими свойствами

        public DateTime BirthDate { get; } // Дата рождения

        public double Weight { get; set; } // Вес пользователя

        public double Height { get; set; } // рост
        #endregion

        private string textLpg = "Лог работы";
        private string textErrors = "Ошибки в работе:";

        //
        /// <summary>
        /// Конструктор класса User с параметрами
        /// </summary>
        /// <param name="name">Имя пользователя </param>
        /// <param name="gender">Пол пользователя</param>
        /// <param name="birthDate">День рождения пользователя</param>
        /// <param name="weight">Вес пользователя</param>
        /// <param name="height">Рост пользователя</param>
        public User(string name, 
                    Gender gender, 
                    DateTime birthDate, 
                    double weight, 
                    double height)
        {
            #region Проверки на коректные данные при создании пользователя
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
            return base.ToString();
        }
    }
}
