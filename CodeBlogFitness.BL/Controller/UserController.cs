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
        //Переменные

        //  свойство для работы конкретным пользователем       
        public User User { get; }


        //Конструктор в качестве параметра указывать пользователя c отрибутами
        public UserController(string userName, string genderName, DateTime birthDay, double weight, double heigth)
        {
            //TODO; проверка  

            var gender = new Gender(genderName);
            //Создает конкретный обьект пользователя.(с параметрами)
            var user = new User(userName, gender, birthDay, weight, heigth);

            // Если произошла ошибка. Сработает исключение ArgumentNullException
            User = user ?? throw new ArgumentNullException("Пользователь не может быть равен Null",nameof(user));
        }

        /// <summary>
        /// Конструктор без параметров. с десерелезацией
        /// </summary>
        public UserController()
        {
            // обьект для работы с сериализацией
            var formatter = new BinaryFormatter();
            // стрим поток для работы с файлом
            using (var fs = new FileStream("users.dat", FileMode.OpenOrCreate))
            {
                // десерериализуем из стрима в обьект типа User
                if (formatter.Deserialize(fs) is User user)
                {
                    User = user;
                }
                //TODO: Что делать при ошибке чтения файла 
            }
        }

      

        /// <summary>
        /// Сохранение пользователя. С помощью сериализации
        /// </summary>
        /// <param name="User">Сериализация пользователя</param>
        public void Save()
        {
            // обьект для работы с сериализацией
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("users.dat",FileMode.OpenOrCreate))
            {

                formatter.Serialize(fs, User);

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

