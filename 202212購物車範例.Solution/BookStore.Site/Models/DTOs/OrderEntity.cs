using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookStore.Site.Models.DTOs
{
    public class OrderEntity
    {
        public OrderEntity(int id, int customerId, List<OrderItemEntity> items, DateTime createdTime, ShippingInfo shippingInfo)
        {
            Id = id;
            CustomerId = customerId;
            Items = items;
            CreatedTime = createdTime;
            ShippingInfo = shippingInfo;
        }
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CustomerAccount { get; set; }
        private List<OrderItemEntity> _Items;
        public List<OrderItemEntity> Items
        {
            get => _Items;
            set => _Items = (value != null || value.Count == 0) ? value : throw new Exception("Items不能是空的");
        }
        public DateTime CreatedTime { get; set; }
        private int _Status;
        public int Status
        {
            get => _Status;
            set => _Status = (value >= 1 && value <= 3) ? value : throw new Exception("Status只能在1~3 之間");
        }
        private ShippingInfo _shippingInfo;
        public ShippingInfo ShippingInfo
        {
            get => _shippingInfo;
            set => _shippingInfo = value != null ? value : throw new Exception("ShippingInfo不能是null");
        }
        public bool AllowRefund
        {
            get
            {
                if (Status == 1) return true;
                if (Status == 2 && In7Days) return true;
                return false;
            }
        }
        /// <summary>
        /// 本系統沒有記錄客戶收貨日期, 所以判斷七天可退貨的標準, 暫時用訂單成立日期來計算
        /// </summary>
        private bool In7Days
        {
            get
            {
                return (DateTime.Today - this.CreatedTime).TotalDays <= 7.0;
            }
        }
    }
}