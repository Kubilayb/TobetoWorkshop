using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Business.Abstracts
{

    // Yapacağımız işin taslağı miras kısmı
    public interface IProductService 
    {
        Product GetById(int id);
        List<Product> GetAll();
        void Add(Product product); 
        void Update(Product product);
        void Delete(Product product);
    }
}
