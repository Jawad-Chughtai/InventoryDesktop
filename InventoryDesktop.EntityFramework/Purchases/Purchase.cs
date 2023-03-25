
namespace InventoryDesktop.EntityFramework.Purchases
{
    public class Purchase
    {
        public int Id { get; set; }
        public int PurchaseItemId { get; set; }
        public string PurchaseItemDescription { get; set; }
        public string Batch { get; set; }
        public string Barcode { get; set; } 

        public int PerPacketQuantity { get; set; }
        public int PurchasePacketQuantity { get; set; }
        public double PurchasePacketPrice { get; set; }

        public int PurchaseQuantity { get; set; }   
        public double PurchaseUnitPrice { get; set; }   

        public double SalePacketPrice { get; set; }
        public double SaleUnitPrice { get; set; }

        public DateTime? Expiry { get; set; }

        public DateTime CreationTime { get; set; } = DateTime.Now;
        public string CreationTimeString { get { return CreationTime.ToString("dd-MMM-yyyy hh:mm tt"); } }
    }
}
