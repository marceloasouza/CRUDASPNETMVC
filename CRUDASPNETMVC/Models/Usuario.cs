﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CRUDASPNETMVC.Models
{
    public class Usuario
    {
        public int Id  { get; set; }
        public string Login { get; set; }

        public string Senha { get; set; }

    }
}