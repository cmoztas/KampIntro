namespace GameProject
{
    internal class Order
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int GamerId { get; set; }
        public string OrderDetail { get; set; }
        public int OrderAmount { get; set; }
    }
}