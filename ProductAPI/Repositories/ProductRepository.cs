using Microsoft.EntityFrameworkCore;
using ProductAPI.Datas;
using ProductCore.Models;
using System.Linq.Expressions;

namespace ProductAPI.Repositories
{
    public class ProductRepository : IRepository<Product>
    {
        private ApplicationDbContext _dbContext { get; }
        public ProductRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        // CREATE
        public async Task<int> Add(Product product)
        {
            var addedObj = await _dbContext.Products.AddAsync(product);
            await _dbContext.SaveChangesAsync();
            return addedObj.Entity.Id;
        }

        // READ
        public async Task<Product?> GetById(int id)
        {
            return await _dbContext.Products.FindAsync(id);
        }
        public async Task<Product?> Get(Expression<Func<Product, bool>> predicate)
        {
            return await _dbContext.Products.FirstOrDefaultAsync(predicate);
        }
        public async Task<List<Product>> GetAll()
        {
            return await _dbContext.Products.ToListAsync();
        }
        public async Task<List<Product>> GetAll(Expression<Func<Product, bool>> predicate)
        {
            return await _dbContext.Products.Where(predicate).ToListAsync();
        }

        // UPDATE
        public async Task<bool> Update(Product product)
        {
            var productFromDb = await GetById(product.Id);

            if (productFromDb == null)
                return false;

            if (productFromDb.Code != product.Code)
                productFromDb.Code = product.Code;
            if (productFromDb.Name != product.Name)
                productFromDb.Name = product.Name;
            if (productFromDb.Description != product.Description)
                productFromDb.Description = product.Description;
            if (productFromDb.Price != product.Price)
                productFromDb.Price = product.Price;
            if (productFromDb.Quantity != product.Quantity)
                productFromDb.Quantity = product.Quantity;
            if (productFromDb.InventoryStatus != product.InventoryStatus)
                productFromDb.InventoryStatus = product.InventoryStatus;
            if (productFromDb.Category != product.Category)
                productFromDb.Category = product.Category;
            if (productFromDb.Image != product.Image)
                productFromDb.Image = product.Image;
            if (productFromDb.Rating != product.Rating)
                productFromDb.Rating = product.Rating;

            return await _dbContext.SaveChangesAsync() > 0;
        }

        // DELETE
        public async Task<bool> Delete(int id)
        {
            var product = await GetById(id);
            if (product == null)
                return false;
            _dbContext.Products.Remove(product);
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
