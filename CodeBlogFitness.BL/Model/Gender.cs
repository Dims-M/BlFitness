using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Класс отвечающий за пол
    /// </summary>
   public class Gender
    {
        /// <summary>
        /// Имя, называние
        /// </summary>
        public string Name { get; }

        /// конструктор
        /// <summary>
        /// Конструктор при создании обьекта класса.
        /// </summary>
        public Gender(string name)
        {
            // проверка на кокектность входящих данных
            if (string.IsNullOrWhiteSpace(name))
            {
                //Вызываем искучение о ошибке в ручную
                throw new ArgumentNullException("Имя пола не может быть пустым", nameof(name));
            }

           

            Name = name;
            
        }



        public override string ToString()
        {
            return Name;
        }
    }
}
