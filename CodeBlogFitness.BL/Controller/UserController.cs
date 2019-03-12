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
    /// Контролер по управлением классом user Логика работы с пользовтелем. 
    /// </summary>
   public class UserController
    {
   
      /// <summary>
      /// Список для хранения пользователей
      /// </summary>
        public List<User> Users { get; } //Список пользователей 

        public User CurrentUser { get; } // текущий, активный пользователь
        /// <summary>
        /// Создание нового пользователя.
        /// </summary>
        /// <param name="userName">Имя пользователя</param>
        public UserController(string userName)
        {
            //Провека на коректность заплнения имени пользователя
            if (string.IsNullOrWhiteSpace(userName))
            {
                throw new ArgumentNullException("Имя не может быть пустым ", nameof(userName));
            }
            Users = GetUsersData(); // получаем спсок пользователей. Или пустой список
           
            // получаем одного пользователя из списка Users и сравниваем со входящими именем. 
            //Если такого пользователя нет. То получил null
            CurrentUser = Users.SingleOrDefault(u => u.Name == userName); // c помощью линка using System.Linq

        }

        //Конструктор в качестве параметра указывать пользователя c отрибутами
        //public UserController(string userName, string genderName, DateTime birthDay, double weight, double heigth)
        //{
        //    //TODO; проверка  

        //    var gender = new Gender(genderName);
        //    //Создает конкретный обьект пользователя.(с параметрами)
        //    var user = new User(userName, gender, birthDay, weight, heigth);

        //    // Если произошла ошибка. Сработает исключение ArgumentNullException
        //    // User = user ?? throw new ArgumentNullException("Пользователь не может быть равен Null",nameof(user));
        //}

        /// <summary>
        /// Получить список пользователей из файла сеарилизации. Сохраненный.
        /// </summary>
        private List<User> GetUsersData()
        {
            // обьект для работы с сериализацией
            var formatter = new BinaryFormatter();

            // стрим поток для работы с файлом
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                // десерериализуем из стрима в обьект типа User
                if (formatter.Deserialize(fs) is List<User> users)
                {
                    return users; // возращаем лист с десериализованным списком пользователей
                }

                else
                {
                    return new List<User>(); // возврат нового пустого списка. 
                }
                //TODO: Что делать при ошибке чтения файла 
            }
            
        }

      

         
        public void Save()
        {
            // обьект для работы с сериализацией
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat",FileMode.OpenOrCreate))
            {

                formatter.Serialize(fs, Users);

                //TODO: Что делать при ошибке чтения файла 
            }
        }

            /// <summary>
            /// Загрузка данного пользователя
            /// </summary>
            #region перенесли метод в конструктор по умолчанию
            /// <returns>Пользователя приложения</returns>
            //public User Load()
            //{
            //    // обьект для работы с сериализацией
            //    var formatter = new BinaryFormatter();

            //    using (var fs = new FileStream("users.bat", FileMode.OpenOrCreate))
            //    {

            //        return formatter.Deserialize(fs) as User;
            //      //  // Проверка на десариализацию обьекта
            //      //if( formatter.Deserialize(fs) is User user)
            //      //  {
            //      //      return user;
            //      //  }

            //        //else
            //        //  {
            //        //     // throw new FileLoadException("Ошбка при загрузки файла пользователя",nameof(user));
            //        //      return  null;
            //        //  // return user;(
            //    }
            //}
            #endregion
        }


    } //Конец класса

