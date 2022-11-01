using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    internal class ReposLavado : Archivo
    {
        public ReposLavado() : base(){}

        public ReposLavado(string fileName) : base(fileName){}
        
        public List<LavadoCompleto> GetAll()
        {
            StreamReader sr = new StreamReader(ruta);
            //string linea;
            List<LavadoCompleto> lavadoCompletos = new List<LavadoCompleto>();
            while (!sr.EndOfStream)
            {
                //linea = sr.ReadLine();
                lavadoCompletos.Add(Mappear(sr.ReadLine()));
            }
            sr.Close();
            return lavadoCompletos;
        }

        LavadoCompleto Mappear(string lineaDatos)
        {
            var servicio = new Entidades.LavadoCompleto();

            servicio.Marca = (lineaDatos.Split(';')[0]);
            servicio.Placa = (lineaDatos.Split(';')[1]);
            
            return servicio;
        }

        public string Update(List<Entidades.LavadoCompleto> lista)
        {
            var sw = new StreamWriter(ruta, false);
            foreach (var item in lista)
            {
                sw.WriteLine(item.ToString());

            }
            sw.Close();
            return "Datos del servicio actualizados ... ";
        }
    }
}
