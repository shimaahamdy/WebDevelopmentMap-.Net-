﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarAPI.Models
{
    public class BuyCarInput
    {
        public int CarId { get; set; }
        public int OwnerId { get; set; }
        public int Amount { get; set; }
    }
}