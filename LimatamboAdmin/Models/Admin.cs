﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LimatamboAdmin.Models
{
    public class Admin
    {
        public int ID { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string correo { get; set; }
        public string contrasena { get; set; }
    }
}