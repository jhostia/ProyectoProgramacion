using Entidades;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace Logica
{
    internal class ServicioEnjuagueImp : IServicioLavado<Enjuague>
    {
        List<Enjuague> enjuagues;

        public ServicioEnjuagueImp()
        {
            enjuagues = new List<Enjuague>();
        }
        public string Add(Enjuague servicio)
        {
            enjuagues.Add(servicio);
            return $"Servicio asignado al coche placa: {servicio.Placa}";
        }

        public string Delete(Enjuague servicio)
        {
            try
            {
                enjuagues.Remove(GetByPlaca(servicio.Placa));
                return $"Servicio eliminado del coche: {servicio.Marca} de placa {servicio.Placa}";
            }
            catch (Exception)
            {
                return $"Servicio no eliminado. Placa: {servicio.Placa}";

            }
        }

        public Enjuague GetByPlaca(string placa)
        {
            foreach (var item in enjuagues)
            {
                if (item.Equals(placa))
                {
                    return item;
                }
            }
            return null;
        }

        public List<Enjuague> GetAll()
        {
            return enjuagues;
        }

        public bool Exists(Enjuague servicio)
        {
            return false;
        }
    }
}
