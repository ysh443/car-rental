﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CarRent.Enteties
{
  public  class RentContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<RentDetails> Rents { get; set; }
        public DbSet<Branch> Branches { get; set; }
        public DbSet<CarType> CarTypes { get; set; }

    }
}
