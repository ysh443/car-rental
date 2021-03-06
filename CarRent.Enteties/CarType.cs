﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRent.Enteties
{
  public  class CarType
    {
        public int CarTypeId { get; set; }
        public string Manufacture { get; set; }
        public string Model { get; set; }
        public double DailyCost { get; set; }
        public double LateReturnDailyCost { get; set; }
        public int ManufactionYear { get; set; }
        public Gear  Gear { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}

namespace CarRent.Enteties
{
    public enum Gear
    {
        Automatic,
        Tiptronic,
        Manual
    }
}