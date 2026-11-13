using System;
using System.Collections.Generic;
using System.Text;
using WarehouseManagement.Application.Dtos;

namespace WarehouseManagement.Application.Interfaces
{
    public interface IProductService
    {
        ProductDto CreateProduct (CreateProductDto createProductDto);
        ProductDto UpdateProductDto (UpdateProductDto updateProductDto);
        ProductBaseDto DeleteProduct(Guid id);
        ProductBaseDto GetProductById(Guid id);
        List<ProductBaseDto> GetAllProduct(List<Guid>? productIds);
    }
}
