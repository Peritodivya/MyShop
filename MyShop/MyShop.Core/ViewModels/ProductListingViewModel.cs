﻿using MyShop.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyShop.Core.ViewModels
{
   public class ProductListingViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public IEnumerable<ProductCategory> ProductCategories { get; set; }
    }
}
