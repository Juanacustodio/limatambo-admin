﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LimatamboAdmin.Models
{
    public class Paciente
    {
        static public string titulo = "Paciente";

        static public string tituloPlural = "Pacientes";

        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int idSeguro { get; set; }

        public virtual Seguro seguro { get; set; }
    }
}