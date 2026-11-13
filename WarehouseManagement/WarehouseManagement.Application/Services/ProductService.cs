using System;
using System.Collections.Generic;
using System.Text;
using WarehouseManagement.Application.Dtos;
using WarehouseManagement.Application.Interfaces;
using WarehouseManagement.Domain.Entities;

namespace WarehouseManagement.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository )
    {
        _productRepository = productRepository;
    }
    
        public ProductDto CreateProduct(CreateProductDto createProductDto)

        {
            if (createProductDto.UnitPrice <= 0)
            {
                throw new ArgumentException("Unit price must be greater than zero.");
            }
            var product = new Product
            {
                Name = createProductDto.Name,
                Description = createProductDto.Description,
                SKU = createProductDto.SKU,
                UnitPrice = createProductDto.UnitPrice,
            };

           var createdProduct= _productRepository.AddProduct(product);
            return new ProductDto
            {
                Id = createdProduct.Id,
                Name = createdProduct.Name,
                Description = createdProduct.Description,
                SKU = createdProduct.SKU,
                UnitPrice = createdProduct.UnitPrice
            };


        }

  

        public ProductBaseDto DeleteProduct(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<ProductBaseDto> GetAllProduct(List<Guid>? productIds)
        {
            throw new NotImplementedException();
        }

        public ProductBaseDto GetProductById(Guid id)
        {
            throw new NotImplementedException();
        }

        public ProductDto UpdateProductDto(UpdateProductDto updateProductDto)
        {
            throw new NotImplementedException();
        }
    }
}
