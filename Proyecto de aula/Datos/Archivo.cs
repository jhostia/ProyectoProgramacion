using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Archivo
    {
        protected string ruta;

        public Archivo()
        {
            ruta = "Coches.txt";
        }

        public Archivo(string fileName)
        {
            ruta = fileName;
        }

        public string Guardar(Entidades.Coche servicio)
        {
            StreamWriter sw = new StreamWriter(ruta, true);
            sw.Close();

            return $"Servicio asignado correctamente .. {servicio.Marca} {servicio.Placa}";
        }
    }
}
