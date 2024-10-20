using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2KarunaKandel
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string? CategoryName { get; set; }
        public int? ProductId { get; set; }
        //navigate to product
        public ICollection<Product>? Product { get; set; }
    }
}
