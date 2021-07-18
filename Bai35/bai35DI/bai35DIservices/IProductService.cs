using bai35DIservices.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace bai35DIservices
{
    public interface IProductService
    {
        List<ProductViewModel> GetAll();
    }
}
