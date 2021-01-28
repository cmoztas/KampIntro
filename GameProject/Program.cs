using System;
using MernisGamerValidationService;

namespace GameProject
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager(new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap)));

            //GamerManager gamerManager = new GamerManager(new FakeUserValidationManager());
            ProductManager productManager = new ProductManager(new OrderManager());
            Gamer gamer1 = new Gamer()
            {
                Id = 1,
                FirstName = "Çağkan Mert",
                Lastname = "Öztaş",
                BirthDate = new DateTime(1993, 10, 27),
                IdentityNumber = "12386749234"
            };

            Product product1 = new Product()
            {
                Id = 1,
                Name = "T-shirt",
                UnitPrice = 5
            };

            gamerManager.Add(gamer1);

            productManager.Buy(product1, gamer1, null, 3);

            productManager.Buy(product1, gamer1, new Campaign() { CampaignDetail = "%15 indirim", DiscountValue = 15, Id = 1 }, 3);
        }
    }
}