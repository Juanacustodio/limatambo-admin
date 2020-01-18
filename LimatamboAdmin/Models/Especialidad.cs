using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LimatamboAdmin.Models
{
    public class Especialidad
    {
        static public string titulo = "Especialidad";
        static public string tituloPlural = "Especialidades";

        public int ID { get; set; }
        public string nombre { get; set; }
        public string imagen { get; set; }
        public string imagenVector { get; set; }

        public virtual ICollection<EspecialidadPorSede> especialidadesPorSede { get; set; }
    }
}