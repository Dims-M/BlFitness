using CodeBlogFitness.BL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
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

        //Конструктор в качестве параметра указывать пользователя 
      public UserController(User user)
        {
            // Если произошла ошибка. Сработает исключение ArgumentNullException
            User = user ?? throw new ArgumentNullException("Пользователь не может быть равен Null",nameof(user));
        }

        //Сохранение пользователя
        public bool Save(User)
        {

        }

    } //Конец класса
}
