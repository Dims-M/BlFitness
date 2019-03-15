using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    public class Eating
    {
        /// <summary>
        /// Время приема пищи
        /// </summary>
        public DateTime Moment { get; }
        /// <summary>
        /// Список пищи для приема пищиы
        /// </summary>
        public Dictionary<Food, double> Foods {get;} // Словарь. В качестве ключа будет выступать еда. В качесве значения кличество

        /// <summary>
        /// Пользователь. Кто, что, кушал
        /// </summary>
        public User User { get; }

        //Конструктор
        public Eating(User user)
        {
            User = user ?? throw new ArgumentNullException("Пользователь не может быть пустым",nameof(user);
            Moment = DateTime.UtcNow;
            Foods = new Dictionary<Food, double>(); // Инициализация словаря.
        }

        public void Add(Food food, double weight)
        {
           // Foods.TryGetValue(); /// Сравнение по сслыкам не работает. Если значимые типо работает хорошо

            // проверка. Есть ли такое значение в справочнике
         var product =  Foods.Keys.FirstOrDefault(f => f.Name.Equals(food.Name)  );

            if (product == null) // Если такого продукта нет. То мы его добавляем
            {
                Foods.Add(food, weight);
            }

            else
            {
                Foods[product] += weight;
            }


        }



    }
}
