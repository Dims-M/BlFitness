using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Controller 
{
    /// <summary>
    /// Контролер для работы с логикой Приема пищи.
    /// </summary>
    public class EatingController : ControllerBase // Наследуемся от базового типа
    {
        private readonly User user; // Пользователь. Поле только для чтения
        private const string FOODS_File_NAME = "foods.dat";

        //Свойство задественной еды
        public List<Food> Foods { get; }

        //Конструктор
        public EatingController(User user)
        {
            // проверка. Если пользователь равен 0 то будет ошибка
            //если узер заполнен от присваевается обьекту User user;
            this.user = user ?? throw new ArgumentNullException("Пользователь не заполнен", nameof(user));

            Foods = GetAllFoods();
        }

        /// <summary>
        /// Получение сеарилизованного списка Продуктов
        /// </summary>
        /// <returns></returns>
        private List<Food> GetAllFoods()
        {
            return Load<List<Food>>(FOODS_File_NAME, user) ?? new List<Food>();
            //Использование из базового метода
            #region НЕ успользуем
            // обьект для работы с сериализацией
            //var formatter = new BinaryFormatter();
            ////C помощью потока десеаризуем список с пруктам питания
            //using (var fs = new FileStream("foods.dat", FileMode.OpenOrCreate))
            //{
            //    // десерериализуем из стрима в обьект типа User
            //    // доп проверки
            //    if (fs.Length > 0 && formatter.Deserialize(fs) is List<Food> users)
            //    {
            //        return users; // возращаем лист с десериализованным списком пользователей
            //    }

            //    else
            //    {
            //        return new List<Food>(); // возврат нового пустого списка. 
            //    }

                #endregion
                //TODO: Что делать при ошибке чтения файла   
        }

        /// <summary>
        /// Метод сеарилизации
        /// </summary>
        private void Save()
        {
            base.Save(FOODS_File_NAME, user); // отправляем через базовый метод  
            #region Метод Не успользуется 
            // обьект для работы с сериализацией
            //var formatter = new BinaryFormatter();

            //using (var fs = new FileStream("foods.dat", FileMode.OpenOrCreate))
            //{

            //    formatter.Serialize(fs, Foods); //Какие обьекты сеаризцем  
            #endregion
            //TODO: Что делать при ошибке чтения файла 
        }



    }


    
}
