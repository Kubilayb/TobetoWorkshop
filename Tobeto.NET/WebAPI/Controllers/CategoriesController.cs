using Business.Abstracts;
using Business.Concretes;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        ICategoryService categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }

        [HttpGet]
        public List<Category> GetAll()
        {
            return categoryService.GetAll();
        }

        [HttpGet("id")]
        public Category GetById(int id)
        {
            return categoryService.GetById(id);
        }

        [HttpPost("add")]
        public void Add([FromBody] Category category)
        {
            categoryService.Add(category);
        }

        [HttpPost("delete")]
        public void Delete([FromBody] int id)
        {
            categoryService.Delete(id);
        }

        [HttpPost("update")]
        public void Update([FromBody] Category category)
        {
            categoryService.Update(category);
        }


    }

}