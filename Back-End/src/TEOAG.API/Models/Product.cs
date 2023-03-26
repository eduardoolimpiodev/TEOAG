using System;
namespace TEOAG.API.Models
{
    public class Product
    {
        public int Id {get; set;}
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public Status Status { get; set; }
        public DateTime ManufacturingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int SupplierId { get; set; }
        public string SupplierDescription { get; set; }
        public string CNPJSupplier { get; set; }

        public Product() { }

        public Product(int id)
        {
            Id =id;
        }

    }
}