using Products.Api.Data.Entity;

namespace Products.Api.Data.Dtos.ProductDto;

public class ProductCreateDto
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public EProductStatus Status { get; set; }
}
