using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;


namespace Business.Abstracts
{
    public interface ICategoryService
    {
        Category GetById(int categoryId);
        List<Category> GetAll();
        void Add(Category category);
       // void Update(Category category);
        void Delete(int categoryId);

    }
}
