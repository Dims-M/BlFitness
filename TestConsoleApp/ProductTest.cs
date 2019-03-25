using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsoleApp
{
    [Serializable]
    class ProductTest
    {
        /// <summary>
        /// Имя продукта
        /// </summary>
        public string  Name {get; set;}

        /// <summary>
        /// Энергетическая емкость 
        /// </summary>
        public int  Energy {get; set; }


        public override string ToString()
        {
            // return base.ToString();
            return ($"{Name} {Energy}");
        }
    }
}
