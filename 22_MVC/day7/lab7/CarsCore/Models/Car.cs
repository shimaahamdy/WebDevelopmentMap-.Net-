﻿namespace CarsCore.Models
{
    public class Car
    {
        public int Num { get; set; }
        public string Color { get; set; }
        public string Model { get; set; }
        public string Manfacture { get; set; }


        public Car()
        {
            Num = LoadDate.num++;
        }

    }
}
