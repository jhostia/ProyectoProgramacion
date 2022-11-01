using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Enjuague : Coche
    {
        public override string ToString()
        {
            return $"{Serial};{Marca};{Placa}";
        }
    }
}
