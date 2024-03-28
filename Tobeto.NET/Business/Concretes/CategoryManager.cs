using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstracts;
using Entities;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        List<Category> categories;

        public CategoryManager()
        {
            categories = new List<Category>();
        }

        public List<Category> GetAll()
        {
            return this.categories;
        }
        public void Add(Category category)
        {
            categories.Add(category);
        }

        public void Delete(int categoryId)
        {
            categories.Remove(categories.Find(x => x.CategoryId == categoryId));
        }

        //public void Update(Category category)
        //{
        //    Category foundCategory = categories.Find(x => x.Id == category.Id);
        //    foundCategory.Name = category.Name;
        //    foundCategory.Description = category.Description;

        //}

        public Category GetById(int categoryId)
        {
            return categories.Find(x => x.CategoryId == categoryId);
        }
    }
}
