using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LimatamboAdmin.Models
{
    public class Consultorio
    {
        static public string titulo = "Consultorio";
        static public string tituloPlural = "Consultorios";

        public int ID { get; set; }
        public string nombre { get; set; }
        public int piso { get; set; }
        public int idEspecialidadPorSede { get; set; }

        [ForeignKey("idEspecialidadPorSede")]
        public virtual EspecialidadPorSede especialidadPorSede { get; set; }
    }
}