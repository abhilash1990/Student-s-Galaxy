namespace Students_Galaxy_Infrastructure.Data
{
    public class ProductMaster
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool InStock { get; set; }
    }
}
