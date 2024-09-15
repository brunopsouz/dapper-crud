namespace OrderManagement.Domain.Entities
{
    public class ProductsModel
    {
        public string ProductName { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get; set; }
        public DateTime CreatedAt => DateTime.Now;
    }
}
