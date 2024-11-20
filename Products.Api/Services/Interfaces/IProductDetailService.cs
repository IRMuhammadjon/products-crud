using Products.Api.Data.Entity;

namespace Products.Api.Services.Interfaces;

public interface IProductDetailService
{
    Task<ProductDetail> GetDetailsByProductIdAsync(Guid productId);
    Task<ProductDetail> CreateProductDetailAsync(Guid productId, ProductDetail detail);
    Task<ProductDetail> UpdateProductDetailAsync(Guid productId, ProductDetail detail);
    Task<bool> DeleteProductDetailAsync(Guid productId);
}
