using Business.Abstracts;
using Business.Concretes;
using Business.Dtos.Product.Requests;
using Business.Dtos.Product.Responses;
using Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        // IProductService productService; // ❌❌❌

        IProductService _productService;

        public ProductsController(IProductService productService)
        {
            this._productService = productService;
        }

        [HttpGet]

        // public List<Product> GetAll()
        // public async Task<List<Product>> GetAll()

        // public async Task<List<ListProductResponse>> GetAll()

        public async Task<List<ListProductResponse>> GetAll()

        {
            return await _productService.GetAll();

            //   return _productService.GetAll();
        }

        [HttpPost]
        //  public async Task Add([FromBody] Product product)
        //  public async Task Add([FromBody] AddProductRequest product)
        public async Task Add([FromBody] AddProductRequest product)

        {
            await _productService.Add(product);
        }


        [HttpGet("Senkron")]
        public string Sync()
        {
            Thread.Sleep(5000);  // 5 saniye beklet
            return "Sync endpoint";
        }

        [HttpGet("Asenkron")]
        public async Task<string> Async()
        {
            await Task.Delay(5000);  // 5 saniye gecikme  await=> bekle dedik
            return "Async endpoint";
        }
    }
}

// SOLID => S => SINGLE RESPONSIBILITY

















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

