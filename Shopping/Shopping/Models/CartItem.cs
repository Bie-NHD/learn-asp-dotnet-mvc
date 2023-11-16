namespace Shopping.Models
{
    public class CartItem
    {
        public string ProductId { get; set; } = string.Empty;
        public string ProductNane { get; set; } = string.Empty;
        public int ProductPrice { get; set; }
        public string? Photo { get; set; }
        public int Qty { get; set; }
        public int Total { get; set; }

        public Product? Product { get; set; } = null;
    }
}
