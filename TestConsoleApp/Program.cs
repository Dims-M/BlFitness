using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // zapolneneRandomList();

            //VovodList(zapolneneRandomList(100));

            testChenieFaila();

            Console.ReadKey();
        }

        /// <summary>
        /// Рандомное заполнение листа случайными значениями. 
        /// </summary>
        /// <param name="list">Конкретный тип колекции</param>
        /// <returns></returns>
        public static List<int> zapolneneRandomList(int dlinaLista)
        {
            
            var collection = new List<int>(dlinaLista);

            Console.WriteLine("Случайное заполнение Array листа ");
           // Random random = new Random();

            for (int i = 0; i < collection.Capacity; i++ )
            {
                Random random = new Random();
                var teempp = random.Next(0, 1000);
                collection.Add(teempp);
                Console.WriteLine(teempp); // отлатка и вывод.
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
            Console.WriteLine("Размер " + list.Count);

            foreach (var LestTemp in list)
            {
                Console.WriteLine(LestTemp.ToString());
               // Console.WriteLine("Размер "+ list.Count);
               // Console.WriteLine("\t\n");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Чтение из файла
        /// </summary>
        public static void testChenieFaila()
        {
            Console.WriteLine("чтение из файла");
            //путь к файлу
            string path = @"C:\Users\Dmitrii\Desktop\гг.txt";
            int countList =0;

            //лист для хранения спарсенных данных
            var collections = new List<string>();

           //Получаем данные о файле 
            FileInfo fileInf = new FileInfo(path);

            // если файл существует.
            //Вывод инфы о файле
            if (fileInf.Exists)
            {
                Console.WriteLine("Имя файла: {0}", fileInf.Name);
                Console.WriteLine("Время создания: {0}", fileInf.CreationTime);
                Console.WriteLine("Размер: {0}", fileInf.Length);
                countList = (int)fileInf.Length;
            }

            //временный массив
            string [] strcollectionsing = new string [countList]; // 

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null) // читает поток пока не дайдет до конца файла
                {
                   string[] str = line.Split(' '); // читаем файл. и разбиваем его на цельные слова

                    for (int i = 0; i < collections.Count; i++)
                    {
                        // collections.Insert(i, str);
                        collections.AddRange(str);
                        Console.WriteLine($"Добавленно: {str}"); // Ятестовой вывод
                    }
                }

            }

            Console.WriteLine("Количество элементов в коллекции " + collections.Count);
            for (int i = 0; i < collections.Count; i++)
            {
                Console.WriteLine("Элемент [" + i + "]: " + collections[i]);
            }
        }


    }
}
