using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Site.Models.DTOs
{
    public class CreateOrderItem
    {
        public int ProductId { get; set; }
        public int Qty { get; set; }
    }
}