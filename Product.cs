﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2KarunaKandel
{
        public class Product()
        {
            public int ProductId { get; set; }
            public string? PName { get; set; }
            public double Price { get; set; }
        //navigate to category
        public Category? Category { get; set; }

    }
    }


