using System;
using System.Collections.Generic;
using System.Text;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain.Entities;
using WarehouseManagement.Infrastructure.Data;

namespace WarehouseManagement.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository

    {
        private readonly AppDbContext _dbContext;
        public ProductRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Product AddProduct(Product product)
        {
            var dbContext = new AppDbContext();
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
            return product;
        }

        public Product DeleteProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllProduct(List<Guid>? productIds)
        {
            var product = _dbContext.Products.Where(p => productIds == null || productIds.Contains(p.Id)).ToList();
            return product;
        }

        public Product GetProductById(Guid id)
        {
            return _dbContext.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public Product UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
