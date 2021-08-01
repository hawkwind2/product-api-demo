using Microsoft.EntityFrameworkCore;
using Product_Kolmeo.Entities;
using Product_Kolmeo.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Product_Kolmeo.Models
{
    public class RepositoryProduct : IRepository<Product>
    {
        protected KDBContext dbContext;

        public RepositoryProduct(KDBContext context)
        {
            dbContext = context;
        }

        public async Task CreateAsync(Product entity)
        {
            this.dbContext.Set<Product>().Add(entity);
            _ = await this.dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Product entity)
        {
            this.dbContext.Set<Product>().Remove(entity);
            _ = await this.dbContext.SaveChangesAsync();
        }

        public async Task<List<Product>> SelectAll()
        {
            return await this.dbContext.Set<Product>().ToListAsync();
        }

        public async Task<Product> SelectById(long id)
        {
            return await this.dbContext.Set<Product>().FindAsync(id);
        }

        public async Task UpdateAsync(Product entity)
        {
            this.dbContext.Set<Product>().Update(entity);
            _ = await this.dbContext.SaveChangesAsync();
        }
    }
}
