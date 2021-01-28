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

            gamerManager.Add(new Gamer()
            {
                Id = 1,
                FirstName = "Çağkan Mert",
                Lastname = "Öztaş",
                BirthDate = new DateTime(1993, 10, 27),
                IdentityNumber = "12386749234"
            });

            Product product1 = new Product()
            {
                Id = 1,
                Name = "T-shirt",
                UnitPrice = 5
            };

            productManager.Buy(product1,
                new Gamer() { Id = 2, FirstName = "Çağkan Mert", Lastname = "Öztaş", BirthDate = new DateTime(1993, 10, 27), IdentityNumber = "1983275498345" },
                null, 3);

            productManager.Buy(product1,
                new Gamer() { Id = 2, FirstName = "Çağkan Mert", Lastname = "Öztaş", BirthDate = new DateTime(1993, 10, 27), IdentityNumber = "1983275498345" }, 
                new Campaign() { CampaignDetail = "%15 indirim", DiscountValue = 15, Id = 1 }, 
                3);
        }
    }
}