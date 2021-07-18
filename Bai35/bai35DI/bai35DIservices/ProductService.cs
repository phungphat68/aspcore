﻿using bai35DIservices.Dtos;
using System.Collections.Generic;

namespace bai35DIservices
{
    public class ProductService : IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {Id = 1, Name = "Pen Drive" },
                new ProductViewModel {Id = 2, Name = "Memory Card" },
                new ProductViewModel {Id = 3, Name = "Mobile Phone" },
                new ProductViewModel {Id = 4, Name = "Tablet" },
                new ProductViewModel {Id = 5, Name = "Desktop PC" } ,
            };
        }
    }
}
