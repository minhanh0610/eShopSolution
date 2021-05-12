using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShopSolution.Data.Entities
{
    public class Cart
    {
        public int id { get; set; }
        public int productId { get; set; }
        public string quatity { get; set; }
        public decimal price { get; set; }
        public Guid UserId { get; set; } // guid : 128bit ma dinh danh

        public Product Product { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
