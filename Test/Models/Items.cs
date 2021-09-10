using System;
namespace Test.Models
{
    public class Items
    {
        public int ItemId { get; set; }

        public string ItemName { get; set; }

        public int CategoryId { get; set; }

        public decimal SalesPrice { get; set; }

        public decimal PurchasePrice { get; set; }
    }
}
