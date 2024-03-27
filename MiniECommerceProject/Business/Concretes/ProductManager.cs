using Business.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        IProductService _productService;

        // DI => Bu servis, servisler arasına eklendi mi?

        public ProductManager(IProductService productService)
        {
            _productService = productService;
        }

        public void Add(Product product)
        {
            if (product.Price < 0)
                throw new Exception("Ürün fiyatı 0'dan küçük olamaz");
        }

        // (int to product yaptık)
        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _productService.GetAll();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
