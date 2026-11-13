using System;
using System.Collections.Generic;
using System.Text;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Interfaces
{
    public interface IProductRepository
    {
       Product AddProduct(Product product);
       Product UpdateProduct(Product product);
       Product DeleteProduct(Product product);
       Product GetProductById(Guid id);
       List<Product> GetAllProduct(List<Guid>? productIds); 
    }
}
