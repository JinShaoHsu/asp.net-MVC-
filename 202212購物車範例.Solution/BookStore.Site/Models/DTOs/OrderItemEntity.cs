using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Site.Models.DTOs
{
    public class OrderItemEntity
    {
        public OrderItemEntity(int id, OrderProductEntity product, int qty)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (qty <= 0) throw new ArgumentOutOfRangeException(nameof(qty));
            Id = id;
            Product = product;
            Qty = qty;
        }
        public int Id { get; set; }
        public OrderProductEntity Product { get; set; }
        public int Qty { get; set; }
        public int SubTotal => Product.Price * Qty;
    }
}