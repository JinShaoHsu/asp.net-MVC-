using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Site.Models.DTOs
{
    public class ShippingInfo
    {
        public string Receiver { get; set; }
        public string Address { get; set; }
        public string CellPhone { get; set; }
    }
}