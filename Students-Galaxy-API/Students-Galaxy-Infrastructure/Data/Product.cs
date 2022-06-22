﻿namespace Students_Galaxy_Infrastructure.Data
{
    public class Product
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public bool InStock { get; set; }
    }
}
