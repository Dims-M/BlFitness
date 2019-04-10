namespace TestConsolle2
{
    /// <summary>
    /// Класс описывает дорогу
    /// </summary>
    public sealed class Road
    {
        public string Number { get; set; }

        public int Lenght { get; set; }

        //Переопределяем метод ToString
        public override string ToString()
        {
            return $"Дорога {Number} , Длина {Lenght}" ;
        }

    }
}