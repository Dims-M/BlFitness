using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace CodeBlogFitness.BL.Controller
{
    /// <summary>
    /// Класс отвечающий за 
    /// </summary>
   public abstract class ControllerBase
    {
        /// <summary>
        ///  Сеарилизация
        /// </summary>
        /// <param name="fileName">Имя сохраненного файло</param>
        /// <param name="item">Тип файла. Которого требуется сериализовать</param>
        protected void Save(string fileName, object item)
        {
            // обьект для работы с сериализацией
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, item); //Какие обьекты сеаризцем  
                //TODO: Что делать при ошибке чтения файла в методе сеарилизации?   
            }
        }


        protected T Load<T>(string fileName, object item)
        {
            // обьект для работы с сериализацией
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream(fileName, FileMode.OpenOrCreate))
            {
                    // десерериализуем из стрима в обьект типа User
                    // доп проверки
                    if (fs.Length > 0 && formatter.Deserialize(fs) is T items)
                    {
                        return items; // возращаем обьект типа object  с десериализованным даннами
                }

                    else
                    {
                        return default(T) ; // возврат пустого типа с настройками по умолчанию
                    }
                   
                    //TODO: Что делать при ошибке чтения файла в методе Деарилизации?   
                }
            }

    }
}
