﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingPool.DB.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
    }
}
