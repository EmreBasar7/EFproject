namespace EFproject
{
    public class Sale
    {
        public int SaleId { get; set; }

        public int CustomerId { get; set; }

        public int CarId { get; set; }
        
        public string SaleDate { get; set; }

        public decimal SalePrice { get; set; }

        public Car Car { get; set; }
        public Customer Customer { get; set; }

    }
}
