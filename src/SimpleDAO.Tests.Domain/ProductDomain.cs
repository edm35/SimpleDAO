﻿namespace SimpleDAO.Tests.Domain
{
    public class ProductDomain
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CollectionId { get; set; }
        public string CollectionName { get; set; }
    }
}
