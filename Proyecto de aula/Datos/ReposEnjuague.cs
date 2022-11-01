using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class ReposEnjuague : Archivo
    {
        public ReposEnjuague() : base()
        {

        }
        public ReposEnjuague(string fileName) : base(fileName)
        {

        }
        public List<Enjuague> GetAll()
        {
            StreamReader sr = new StreamReader(ruta);
            //string linea;
            List<Enjuague> enjuagues = new List<Enjuague>();
            while (!sr.EndOfStream)
            {
                //linea = sr.ReadLine();
                enjuagues.Add(Mappear(sr.ReadLine()));
            }
            sr.Close();
            return enjuagues;

        }
        Entidades.Enjuague Mappear(string lineaDatos)
        {
            var servicio = new Entidades.Enjuague();

            servicio.Marca = (lineaDatos.Split(';')[0]);
            servicio.Placa = (lineaDatos.Split(';')[1]);

            return servicio;
        }

        public string Update(List<Entidades.Enjuague> lista, bool modo)
        {
            var sw = new StreamWriter(ruta, modo);
            foreach (var item in lista)
            {
                sw.WriteLine(item.ToString());

            }
            sw.Close();
            return "OK";
        }
    }
}
