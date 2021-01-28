using System;

namespace GameProject
{
    internal class ProductManager : IProductService
    {
        private readonly IOrderService _order;

        public ProductManager(IOrderService order)
        {
            _order = order;
        }

        public void Buy(Product product, Gamer gamer, Campaign campaign, int amount)
        {
            _order.ApplyOrder(new Order()
            {
                GamerId = gamer.Id,
                Id = 1,
                OrderAmount = amount,
                OrderDetail = product.Name,
                ProductId = product.Id
            });

            if (campaign == null)
            {
                Console.WriteLine($"{product.Name}, {gamer.FirstName} adlı oyuncuya satıldı");
            }
            else
            {
                Console.WriteLine($"{product.Name}, {gamer.FirstName} adlı %{campaign.DiscountValue} indirimle satıldı");
            }
        }
    }
}