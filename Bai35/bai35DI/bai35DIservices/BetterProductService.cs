using bai35DIservices.Dtos;
using System.Collections.Generic;

namespace bai35DIservices
{
    public class BetterProductService: IProductService
    {
        public List<ProductViewModel> GetAll()
        {
            return new List<ProductViewModel>
            {
                new ProductViewModel {Id = 1, Name = "TV" },
                new ProductViewModel {Id = 2, Name = "Tu Lanh" },
                new ProductViewModel {Id = 3, Name = "IPhone" },
                new ProductViewModel {Id = 4, Name = "Ca lem" },
                new ProductViewModel {Id = 5, Name = "Kem chuoi PC" } ,
            };
        }
    }
}
