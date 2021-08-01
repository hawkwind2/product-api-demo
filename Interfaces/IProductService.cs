using Product_Kolmeo.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product_Kolmeo.Services
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task Add(Product product);
    }
}