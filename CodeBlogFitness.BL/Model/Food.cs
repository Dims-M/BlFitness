using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// Справочник продуктов(еды)
    /// </summary>
   public class Food
    {
        /// <summary>
        /// Название продукта
        /// </summary>
        public string Name{ get; }

        /// <summary>
        /// Протеины
        /// </summary>
       public double Proteins { get;  }

        /// <summary>
        /// Жиры
        /// </summary>
       public double Fats { get;  }

        /// <summary>
        /// Углеводы
        /// </summary>
        public double Сarbohydrates { get;  }

        /// <summary>
        /// Кaлории за 100 грамм продукта
        /// </summary>
        public double Calories{ get; }

        /// <summary>
        /// Кaлории за 1 !! грамм продукта
        /// </summary>
        private double CalloriesOnGramm { get { return Calories / 100.0; } }
        private double ProteinsOnGramm { get { return Proteins / 100.0; } }
        private double FatsOnGramm { get { return Fats / 100.0; } }
        private double СarbohydratesOnGramm { get { return Сarbohydrates / 100.0; } }

        //Конструктор

        public Food(string name) : this(name,0,0,0,0)
        {
            // TODO: Проверка
            Name = name;
        }

        public Food(string name, double calories, double proteins, double fats, double carbohydrates)
        {
            // TODO: Проверка
            Name = name;
            Calories = calories / 100.0;
            Proteins = proteins / 100.0;
            Fats = fats / 100.0;
            Сarbohydrates = carbohydrates / 100.0;
        }



    }
}
