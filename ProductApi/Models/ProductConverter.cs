using SharedModels;

namespace ProductApi.Models
{
    public class ProductConverter : IConverter<Product, ProductDto>
    {
        public Product Convert(ProductDto sharedProduct)
        {
            return new Product
            {
                Id = sharedProduct.Id,
                Name = sharedProduct.Name,
                Price = sharedProduct.Price,
                ItemsInStock = sharedProduct.ItemsInStock,
                ItemsReserved = sharedProduct.ItemsReserved
            };
        }

        public ProductDto Convert(Product hiddenProduct)
        {
            return new ProductDto
            {
                Id = hiddenProduct.Id,
                Name = hiddenProduct.Name,
                Price = hiddenProduct.Price,
                ItemsInStock = hiddenProduct.ItemsInStock,
                ItemsReserved = hiddenProduct.ItemsReserved
            };
        }
    }
}
