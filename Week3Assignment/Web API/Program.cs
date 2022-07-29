using DataAccessLayer.Abstarct;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.EntityFrameworkCore;
using ServiceLayer.Abstract;
using ServiceLayer.Concrete;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Entity life cycle configuration
builder.Services.AddScoped<IProductService, ProductManager>();
builder.Services.AddScoped<IProductFeatureService, ProductFeaturesManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<IProductDal, EFProductDal>();
builder.Services.AddScoped<IProductFeatureDal, EFProductFeatureDal>();
builder.Services.AddScoped<ICategoryDal, EFCategoryDal>();
builder.Services.AddScoped<IUnitOfWork, unitOfWork>();

//Veritaban� ba�lat�s� i�in gerekli olan conncetion string tan�mlamas�
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("SqlCon"), action =>
    {
        //Migration dosyas�n�n konumu belirttik
        action.MigrationsAssembly("DataAccessLayer");
    });
});

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
