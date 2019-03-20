using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            zapolneneRandomList();

            VovodList(zapolneneRandomList());

            Console.ReadKey();
        }

        /// <summary>
        /// Рандомное заполнение листа случайными значениями. 
        /// </summary>
        /// <param name="list">Конкретнвц тип колекции</param>
        /// <returns></returns>
        public static List<int> zapolneneRandomList()
        {
            var collection = new List<int>();

            Console.WriteLine("Случайное заполнение Array листа ");
            Random random = new Random();

            for (int i = 0; i < collection.Count; i++ )
            {
                var teempp = random.Next(1, 1000);
                collection.Add(teempp);
            }

            Console.WriteLine(collection.ToString());
            return collection;

        }

        /// <summary>
        /// Вывод коллекции
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public static void VovodList<T>(List<T> list)
        {
            Console.WriteLine("Содержимое Листа");
            
            foreach (var LestTemp in list)
            {
                Console.WriteLine(LestTemp.ToString());
                Console.WriteLine("Размер"+ list.Count);
                Console.WriteLine("\t\n");
            }
            Console.ReadKey();
        }

    }
}
