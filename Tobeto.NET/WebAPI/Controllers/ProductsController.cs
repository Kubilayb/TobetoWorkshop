using Business.Abstracts;
using Business.Concretes;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductService productService; // ❌❌❌

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public List<Product> GetAll()
        {
            return productService.GetAll();
        }

        [HttpPost]
        public void Add([FromBody] Product product)
        {
            productService.Add(product);
        }
    }
}

















//{
//    [HttpGet]
//    public string Hello([FromQuery] string name, [FromQuery] string surname)
//    {
//        var language = Request.Headers.AcceptLanguage;
//        if (language == "en")
//            return "Hello " + name + " " + surname;
//        return "Merhaba " + name + " " + surname;
//    }
//    // Route Parameters, Query String => Get isteklerinde popüler
//    // Body => POST,PUT
//    // Headers => Yan bilgileri içerir. ()

//    [HttpGet("{username}")]
//    public string Tobeto([FromRoute] string username)
//    {
//        return "Tobeto Kullanıcı Adınız: " + username;
//    }

//    [HttpPost]
//    public Product GoodBye([FromBody] Product product)
//    {
//        return product;
//    }

