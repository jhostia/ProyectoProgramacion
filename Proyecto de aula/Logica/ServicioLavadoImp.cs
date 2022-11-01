using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Logica
{
    internal class ServicioLavadoImp : IServicioLavado<LavadoCompleto>
    {
        List<LavadoCompleto> lavadoCompletos;

        public ServicioLavadoImp()
        {
            lavadoCompletos = new List<LavadoCompleto>();
        }
        public string Add(LavadoCompleto servicio)
        {
            lavadoCompletos.Add(servicio);
            return $"Servicio asignado al coche placa: {servicio.Placa}";
        }

        public string Delete(LavadoCompleto servicio)
        {
            try
            {
                lavadoCompletos.Remove(GetByPlaca(servicio.Placa));
                return $"Servicio eliminado del coche: {servicio.Marca} de placa {servicio.Placa}";
            }
            catch (Exception)
            {
                return $"Servicio no eliminado. Placa: {servicio.Placa}";

            }
        }

        public LavadoCompleto GetByPlaca(string placa)
        {
            foreach (var item in lavadoCompletos)
            {
                if (item.Equals(placa))
                {
                    return item;
                }
            }
            return null;
        }

        public List<LavadoCompleto> GetAll()
        {
            return lavadoCompletos;
        }

        public bool Exists(LavadoCompleto servicio)
        {
            return false;
        }
    }
}
