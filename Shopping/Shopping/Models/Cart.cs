namespace Shopping.Models
{
    public class Cart
    {
        List<CartItem> ItemList = new List<CartItem>();

        public int Total { get; set; }

        public void UpdateTotal()
        {
            Total = ItemList.Sum(x=> x.Total);
        }
    }
}
