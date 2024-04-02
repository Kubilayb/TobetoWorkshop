using Business.Abstracts;
using Business.Concretes;
using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// DataAccess - Entity Framework

// Singleton-Scoped-Transient -> Lifetime
// Singleton => Üretilen bağımlılık uygulama açık olduğu sürece tek bir kere newlenir. 
// Her enjeksiyonda o instance kullanılır.

// Scoped => (API isteği) İstek başına 1 instance oluşturur.

// Transient => Her adımda (her talepte) yeni 1 instance.
//       builder.Services.AddSingleton<IProductService, ProductManager>();
//       builder.Services.AddSingleton<IProductRepository, EfProductRepository>();

builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductRepository, EfProductRepository>();

builder.Services.AddDbContext<BaseDbContext>(); //db bağlantısı
//builder.Services.AddSingleton<IProductRepository, InMemoryProductRepository>(); // ef ekledik

builder.Services.AddSingleton<ICategoryService, CategoryManager>();
builder.Services.AddSingleton<ICustomerService, CustomerManager>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();