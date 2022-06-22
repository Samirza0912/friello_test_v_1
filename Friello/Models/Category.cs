﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Friello.Models
{
    public class Category
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
