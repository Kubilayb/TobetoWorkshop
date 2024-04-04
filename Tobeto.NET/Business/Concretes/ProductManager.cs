using Business.Abstracts;
using Entities;
using DataAccess.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.CrossCuttingConcerns.Types;
using AutoMapper;


namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        IProductRepository _productRepository;
        IMapper mapper;

        // DI => Bu servis, servisler arasına eklendi mi?
        public ProductManager(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        // public void Add(Product product)
        // public async void Add(Product product)
          public async Task Add(Product product)
        {
            // ürün ismini kontrol et
            // fiyatını kontrol et

            if (product.UnitPrice < 0)
                throw new BusinessException("Ürün fiyatı 0'dan küçük olamaz.");
            // Aynı isimde 2. ürün eklenemez.

            //  Product? productWithSameName = _productRepository.Get(p => p.Name == product.Name);
            Product? productWithSameName = await _productRepository.GetAsync(p => p.Name == product.Name);

            if (productWithSameName is not null)
                // throw new Exception("Aynı isimde 2. ürün eklenemez.");
                throw new System.Exception("Aynı isimde 2. ürün eklenemez.");

            if (product.Stock < 20)
            {
                throw new BusinessException("Stok miktarı 20'den küçük olamaz.");
            }

            // Async işlemler ✅
            // Global Ex. Handling.
            // İş kuralları, Validaton => Daha temiz yazarız?
            // Pipeline Mediator pattern ??

            //_productRepository.Add(product);
            await _productRepository.AddAsync(product);

        }

        public void Delete(int id)
        {
            Product? productToDelete = _productRepository.Get(i => i.Id == id);
            throw new NotImplementedException();
        }

        // public List<Product> GetAll()
        public async Task<List<Product>> GetAll()

        {
            // Cacheleme?
            //  return _productRepository.GetList();
            return await _productRepository.GetListAsync();


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
