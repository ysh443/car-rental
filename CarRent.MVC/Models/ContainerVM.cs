﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarRent.MVC.Models
{
    public class ContainerVM
    {
        public string SearchGear { get; set; }
        public string SearchModel { get; set; }
        public string SearchText { get; set; }


        public ContainerVM()
        {

        }
    }
}