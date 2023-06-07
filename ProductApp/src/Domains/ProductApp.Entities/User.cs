﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductApp.Entities
{
    public class User : IEntity
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
