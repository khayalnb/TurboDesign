﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboManagment.BLL.Models
{
    public class FuelType:BaseIDGenerator
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
