using DataAccess.Abstracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.InMemory
{
    public class InMemoryProductRepository : IProductRepository
    {
        List<Product> products;

        public InMemoryProductRepository()
        {
            products = new List<Product>();
        }

        public void Add(Product product)
        {
            products.Add(product);
        }
        public List<Product> GetAll()
        {
            return products;
        }
        public Product GetById(int productId)
        {
            // LINQ => SQL'in C# hali
            Product? product = products.FirstOrDefault(p => p.ProductId == productId);
            return product;

            // Product? product = products.Find(x => x.Id == id);
            // return products.Where(p => p.Id == id).FirstOrDefault();     predicate lamda expretion
            // return products..FirstOrDefault(p => p.Id == id);          farklı kullanımlar

        }

        public void Delete(Product product)
        {
            products.Remove(product);
        }

        public void Update(Product product)
        {
            // InMemory olduğundan şimdilik yapmıyoruz. atladık.
        }
    }
}
