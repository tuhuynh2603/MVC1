using MVC1.Models;

namespace MVC1.Services
{
    public class ProductService : List<ProductModel>
    {
        public ProductService()
        {
            this.AddRange(
            [
                new ProductModel(){ProductId=1, Name = "Apple Watch", Price = 1000},
                new ProductModel(){ProductId=2, Name = "Apple Ipad", Price = 100},
                new ProductModel(){ProductId=5, Name = "Apple Iphone", Price = 500},
                new ProductModel(){ProductId=10, Name = "Samsung Watch", Price = 400},

            ]);
        }
    }
}