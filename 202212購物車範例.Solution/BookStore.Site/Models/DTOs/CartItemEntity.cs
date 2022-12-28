using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Site.Models.DTOs
{
    public class CartItemEntity
    {
        public CartItemEntity(CartProductEntity product, int qty)
        {
            Product = product;
            Qty = qty;
        }
        public int Id { get; set; }
        private CartProductEntity _Product;
        public CartProductEntity Product
        {
            get => _Product;
            set => _Product = value != null ? value : throw new Exception("Product必須存在");
        }
        private int _Qty;
        public int Qty
        {
            get => _Qty;
            set => _Qty = value > 0 ? value : throw new Exception("Qty必須是整數");
        }
        public int SubTotal
        {
            get
            {
                // Allen Todo
                return Product.Price * Qty;
            }
        }
    }
}