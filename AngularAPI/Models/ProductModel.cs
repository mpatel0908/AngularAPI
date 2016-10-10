using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AngularAPI.Models
{
    public class ProductModel
    {
        internal bool soldOut;

        public bool canPurchase { get; internal set; }
        public object images { get; internal set; }
        public string Name { get; internal set; }
        public decimal Price { get; internal set; }
        public object review { get; internal set; }
        public string description { get; internal set; }
        public object id { get; internal set; }
    }
}