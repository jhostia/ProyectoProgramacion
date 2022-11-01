using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    internal interface IServicioLavado<T>
    {
        string Add(T servicio);

        string Delete(T servicio);

        T GetByPlaca(string placa);

        List<T> GetAll();
    }
}
