using Product_Kolmeo.Entities;
using Product_Kolmeo.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product_Kolmeo.Services
{
    public class ProductService: IProductService
    {
        private readonly IRepository<Product> _product;

        public ProductService(IRepository<Product> product)
        {
            _product = product;
        }

        public async Task<List<Product>> GetAll()
        {
            return await _product.SelectAll();
        }

        public async Task Add(Product product)
        {
            await _product.CreateAsync(product);
        }

    }
}
