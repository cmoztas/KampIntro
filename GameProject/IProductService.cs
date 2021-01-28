namespace GameProject
{
    internal interface IProductService
    {
        void Buy(Product product, Gamer gamer, Campaign campaign, int amount);
    }
}