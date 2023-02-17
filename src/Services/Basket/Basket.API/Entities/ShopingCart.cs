namespace Basket.API.Entities
{
    public class ShopingCart
    {
        public string UserName { get; set; }
        public List<ShopingCartItem> Items { get; set; } = new();
        public ShopingCart() { }

        public ShopingCart(string userName)
        {
            UserName = userName;
        }
        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Quantity * item.Price;
                }
                return totalPrice;
            }
        }
    }
}
