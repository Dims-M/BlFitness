using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace TestConsoleApp
{

    class Program
    {

      static Random rnd = new Random();

        static void Main(string[] args)
        {
            //заполнение  инотовнго листа рандомными значениями
           //var temColection = zapolneneRandomList(30);

            var ColectionProduct = new List<ProductTest>();
            // zapolneneRandomList();
            // VovodList(zapolneneRandomList(10)); // вывод заполненого рандомом листа

            // Console.WriteLine(ZaprosLino1(temColection));
            // ZaprosLino1(temColection);
           // ZaprosLino2(temColection); // метод 2

           // ZaprosLino_Class(); //Заполнение листа обьетами с продуктами

            // testChenieFaila(); // чтение из файлов.

           // SserializationObject(ZaprosLino_Class()); //Сеарлизация с рандом заполнением

           // VovodListO( DeSerializationListProductTest()); //вывод на консоль десиаризованный архив списка

            ZaprosLino_Class(); // вывод из листа List<ProductTest> list  с заданными параметрами.

            //VovodListO(ReversColecctionss(ZaprosLino_Class())); // реверс списка колекции


            Console.ReadKey();
        }

        /// <summary>
        /// Вывод листов
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list">Указывайте List </param>
        private static void VovodListO<T>(List<T> list) //List<ProductTest> list
        {
            Console.WriteLine("Вывод Содержимое колекции");
            foreach (var vivod in list)
            {
                Console.WriteLine(vivod); 
            } 
        }

        /// <summary>
        /// Заполнение рандомом списка ProductTest
        /// </summary>
        /// <returns></returns>
        public static List<ProductTest> ZaprosLino_Class()
        {
            var collections = new List<ProductTest>();

            //заполнение листа случайными значениями
            for (int i = 0; i < 100; i++)
            {
                var product = new ProductTest()
                { //инициализоторы класса

                    Name = "Продукт № " + i,
                    Energy = rnd.Next(10, 500)
                };
                collections.Add(product);
            }

            var result = from item in collections
                         where item.Energy < 200 // выборка товаров больше 200;
                         select item;
            //Работаем с линком
            //var result2 = collections.Where(item => item < collections.).OrderByDescending(item => item);
            //                        // .Where(item => item % 2 == 0) // item "такой что" item  равен четному числу
            //                         //.OrderByDescending(item => item); // Сортировка  по убыванию 
            Console.WriteLine("Заполнение  колекции завершено по условию where item.Energy < 200 // выборка товаров больше 200;");
            Console.WriteLine($"Содержимое коллекции:");
            foreach (var item in result)
            {
                Console.WriteLine($"{item}");
            }

            // колекция целых чисел. 
            var selectCollection = 
                collections.Select(product => product.Energy); // преобразуем из колекции collections в переменую product значениями Energy

            Console.WriteLine($"Содержимое преобразуемой коллекции: со значениями Energy");
            Console.WriteLine($"{selectCollection.ToString()}");

            foreach (var item in selectCollection)
            {
                Console.WriteLine($"{item}");
            }

            //сортировка по значениям Energy

           // var orderByCollectionМ = collections.OrderBy(ProductEn => ProductEn.Energy); //  сортровка по уменьшению
            var orderByCollection = collections.OrderByDescending(ProductEn => ProductEn.Energy); //  сортровка по уменьшению + упорядачали по имени в обратном порядке

            Console.WriteLine($"Сортировка по уменьшению Energy");
            
            foreach (var item in orderByCollection)
            {
                Console.WriteLine($"{item}");
            }

            var orderByCollectionМ = collections.OrderBy(ProductEn => ProductEn.Energy).ThenByDescending(produkt => produkt.Name); //  сортровка по уменьшению
            Console.WriteLine($"Сортировка по возрастанию Energy+ при одинаковых значениях упорядоватся бужут по именам");

            foreach (var item in orderByCollectionМ)
            {
                Console.WriteLine($"{item}"); 
            }

            //Групировка выборки
            var groupbuCollection = collections.GroupBy(viborkaProdokta => viborkaProdokta.Energy);

            foreach(var grop in groupbuCollection)
            {
                Console.Write($"Ключ:{grop.Key}");
                foreach (var item in grop )
                { 
                    Console.WriteLine($"***{item}");
                }
                Console.WriteLine();
            }

            // проверка все ли элементы в колекции содержат нужное значение item.Energy == 120
            var all = collections.All( item => item.Energy == 120);
            Console.WriteLine($"Вывод выборки после условия All:{all}");

            // проверка все ли элементы в колекции содержат хотябы одно из значение item.Energy == 120
            var any = collections.Any(item =>item.Energy ==120);
           Console.WriteLine($"Вывод выборки после условия Аne:{any}");

            //вхождение нужного значения в колекции . Возврат булевского значения
            var contains = collections.Contains(collections[5]);
            Console.WriteLine($"Вывод выборки после условия Аne:{any}");

            //Обьединение колекций

            var razmerIntArrey = 10;
            var numbers1 = new int[razmerIntArrey];  // пустой интовый массив
            int[] numbers2 = new int[razmerIntArrey]; // пустой интовый массив

            for (int i = 0; i< razmerIntArrey; i++ )
            {
                numbers1[i] = RandomInt(razmerIntArrey); //РАндом заполнение массива.
                numbers2[i] = RandomInt(razmerIntArrey);
                Console.WriteLine(numbers1[i]); //тест вывод.
                Console.WriteLine(numbers2[i]);
            }

            foreach (int tempMass1 in numbers1)
            {
                Console.WriteLine($"Содержимое 1 массива {tempMass1}");
            }

            Console.ReadKey();

            foreach (int tempMass2 in numbers2)
            {
                Console.WriteLine($"Содержимое 2 массива {tempMass2}");
            }

            Console.ReadKey();

           Console.WriteLine("Обьеденение двух интовых списков ");
           var unionList = UnionList(numbers1, numbers2);

            foreach (var grop in unionList)
            {
                Console.WriteLine(grop);
            }

            Console.ReadKey();

            return collections;
           // return ()selectCollection;
        }

        /// <summary>
        /// Ревер колекции
        /// </summary>
        /// <param name="list">Укажите нужную колекцию. </param>
        /// <returns></returns>
        public static List<ProductTest> ReversColecctionss(List<ProductTest> list)
        {
            Console.WriteLine("Реверс колекции:");

           list.Reverse();

            return list;
        }

        /// <summary>
        /// обьединение 2 листа. Возращает обьеденный лист
        /// </summary>
        /// <param name="list">Лист для обьеденения №1 </param>
        /// <param name="list2">Лист для обьеденения №1</param>
        /// <returns></returns>
        public static List<int> UnionList(int [] list1, int [] list2)
        {
            var unionList = list1.Union(list2);

            return unionList.ToList();
        }

        /// <summary>
        /// Работаем с линком. Пример 2
        /// </summary>
        /// <param name="collections"></param>
        public static void ZaprosLino2(List<int> collections)
        {
            //Работаем с линком
            var result2 = collections.Where(item => item <= 5) // item "такой што" item меньше 5
                                     .Where(item => item % 2 == 0) // item "такой что" item  равен четному числу
                                     .OrderByDescending(item => item); // Сортировка  по убыванию 

            Console.WriteLine($"Содержимое коллекции:\t\n");

            foreach (var item in result2)
            {
                Console.WriteLine($"{item}");

                #region // выводим по 5 сообщений
                // выводим по 5 сообщений
                //if (coun != 5)
                //{
                //    Console.Write($"{item},"); // выводим по 5 сообщений
                //    coun++;
                //}
                ////переход на новую строку
                //if (coun == 5)
                //{
                //    coun = 0;
                //    Console.WriteLine("\t\n");
                //}
                #endregion

            }
        }

        /// <summary>
        /// Работаем с линком. Пример 1 
        /// </summary>
        /// <param name="collections"></param>
        /// <returns></returns>
        public static object ZaprosLino1(List<int> collections)
        {
            // запрос Linq. Выбрать в обьект  item из колекции collections. Где item < 5. Выбрать обьект item и присвоить его в переменную
            var result = from item in collections
                         where item < 5
                         select item;

            int coun = 0;

            //Вывод в консоль
            foreach (var item in result)
            {
                // выводим по 5 сообщений
                if (coun != 5)
                {
                    Console.Write($"{item},"); // выводим по 5 сообщений
                    coun++;
                }
                //переход на новую строку
                if (coun == 5)
                {
                    coun = 0;
                    Console.WriteLine("\t\n");
                }

            }
            Console.WriteLine($"\t\nКоличество элементов в выборке { result.Count()}");
            return result;
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

            //Рандомное заполнение и добавление в список
            for (int i = 0; i < collection.Capacity; i++)
            {
                Random random = new Random();
                var teempp = random.Next(0, 10);
                Thread.Sleep(100); // задержка основного потока
                collection.Add(teempp);
                Console.WriteLine(teempp); // отлатка и вывод.

            }

            Console.WriteLine(collection.ToString());
            return collection;

        }

        /// <summary>
        /// Рандомное интовое заполнение.
        /// </summary>
        /// <param name="count">В качестве параметра укажите размер рандома</param>
        /// <returns></returns>
        public static int RandomInt(int count)
        {
            int _count = 0;

            Random random = new Random();

            for (int i =0; i< count; i++)
            {
                Thread.Sleep(25);
               
                _count += random.Next(1, 1000);
            }

            return _count;
        }

         
        public static void VovodList(List<int> list)
        {
            Console.WriteLine("Содержимое Листа");
            Console.WriteLine("Размер " + list.Count);

            foreach (var LestTemp in list)
            {
                Console.WriteLine(LestTemp.ToString()); // тестовой вывод
                                                        // Console.WriteLine("Размер "+ list.Count);
                                                        // Console.WriteLine("\t\n");
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Чтение из файла. С настрйкой пути файла 
        /// </summary>
        public static void testChenieFaila()
        {
            Console.WriteLine("чтение из файла");
            //путь к файлу
            string path = @"C:\Users\Dmitrii\Desktop\гг.txt";
            int countList = 0;

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
            //временный массив. 
            string[] strcollectionsing = new string[countList]; // 

            using (StreamReader sr = new StreamReader(path, System.Text.Encoding.Default))
            {
                string line;

                while ((line = sr.ReadLine()) != null) // читает поток пока не дайдет до конца файла
                {
                    string temp = line.Trim();
                    string[] str = temp.Split(' '); // читаем файл. и разбиваем его на цельные слова

                    //if(str.Equals(" ") || str != null )
                    // {  
                    collections.AddRange(str);
                    Console.WriteLine($"Добавленно: {str}"); //  тестовой вывод

                }


                //  Console.WriteLine($"Добавленно: {str}"); //  тестовой вывод



            }

            Console.WriteLine("Количество элементов в коллекции " + collections.Count);
            for (int i = 0; i < collections.Count; i++)
            {
                Console.WriteLine("Элемент [" + i + "]: " + collections[i]);
            }
        }


        /// <summary>
        /// Сеаризируем любой обьект
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
       static public bool SserializationObject( object obj)
        {

            //Обьект для работы с сериализацией
            var binFormatter = new BinaryFormatter();

            //используем поток для схранения файла. (указываем имя файла и Режим работы(Создать если его нет или перезаписать))
            using (var  file = new FileStream("ddl.bin", FileMode.OpenOrCreate) )
            {
                // Параметрa ctfhbpfwbb стрим + сам обьект
                binFormatter.Serialize(file, obj);
            }
            Console.WriteLine("Обьект сеализован");
            return true;
        }

        /// <summary>
        /// Десарилизируем обьект.Возвращаем список ProductTest
        /// </summary>
        /// <returns></returns>
        static public List<ProductTest> DeSerializationListProductTest()
        {
            //Обьект для работы с сериализацией
            var binFormatter = new BinaryFormatter();

            using (var file = new FileStream("ddl.bin", FileMode.OpenOrCreate))
            {
                var newGroups = binFormatter.Deserialize(file) as List<ProductTest>;
                Console.WriteLine("Обьект распакован.....");
                return newGroups;
            }

           
        }

    } // конец клпасса

   
}
