﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day4_Demo_42.Data
{
    public class Day4_Demo_42Context : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public Day4_Demo_42Context() : base("name=Day4_Demo_42Context")
        {
        }

        public System.Data.Entity.DbSet<Day4_Demo_42.Models.Student> Students { get; set; }
    }
}
