using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace bai26.Models
{
    public class ProductEditModel
    {
        public int ID { get; set;}
        [Required(ErrorMessage =" Must input name")]
        [StringLength(maximumLength: 25, MinimumLength =3, ErrorMessage =" Length must be between 3 to 25")]
        public string Name { get; set;}
        public decimal? Rate { get; set;}
        public int? Rating { get; set;}        
    }
}
