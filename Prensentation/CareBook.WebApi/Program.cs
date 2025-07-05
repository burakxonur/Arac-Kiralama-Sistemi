using CareBook.Application.Features.CQRS.Handlers.AboutHandlers;
using CareBook.Application.Features.CQRS.Handlers.BannerHandlers;
using CareBook.Application.Features.CQRS.Handlers.BrandHandlers;
using CareBook.Application.Features.CQRS.Handlers.CarHandlers;
using CareBook.Application.Features.CQRS.Handlers.CategoryHandlers;
using CareBook.Application.Features.CQRS.Handlers.ContactHandlers;
using CareBook.Application.Features.RepositoryPattern;
using CareBook.Application.�nterfaces;
using CareBook.Application.�nterfaces.BlogInterfaces;
using CareBook.Application.�nterfaces.CarDescriptionInterfaces;
using CareBook.Application.�nterfaces.CarFeatureInterfaces;
using CareBook.Application.�nterfaces.CarInterfaces;
using CareBook.Application.�nterfaces.CarPricingInterfaces;
using CareBook.Application.�nterfaces.RentACarInterfaces;
using CareBook.Application.�nterfaces.StatisticsInterfaces;
using CareBook.Application.�nterfaces.TagCloudInterfaces;
using CareBook.Application.Services;
using CareBook.Application.Tools;
using CareBook.Domain.Entities;
using CareBook.Persistence.Context;
using CareBook.Persistence.Repository;
using CareBook.Persistence.Repository.BlogRepository;
using CareBook.Persistence.Repository.CarDescriptionRepositories;
using CareBook.Persistence.Repository.CarFeatureRepositories;
using CareBook.Persistence.Repository.CarPricingRepositories;
using CareBook.Persistence.Repository.CarRepository;
using CareBook.Persistence.Repository.CommentRepositories;
using CareBook.Persistence.Repository.RentACarRepositories;
using CareBook.Persistence.Repository.StatisticsRepositories;
using CareBook.Persistence.Repository.TagCloudRepositories;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters
    {
        ValidAudience = JwtTokeDefaults.ValidAudience,
        ValidIssuer = JwtTokeDefaults.ValidIssuer,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokeDefaults.Key)),
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true
    };
});


// Add services to the container.
builder.Services.AddScoped<CarBookContext>();
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(ICarRepository), typeof(CarRepositories));
builder.Services.AddScoped(typeof(IStatisticsRepository), typeof(StatisticsRepository));
builder.Services.AddScoped(typeof(IBlogRepository), typeof(BlogRepository));
builder.Services.AddScoped(typeof(ICarPricingRepository), typeof(CatPricingRepository));
builder.Services.AddScoped(typeof(ITagCloudRepository), typeof(TagCloudRepository));
builder.Services.AddScoped(typeof(IRentACarRepository), typeof(RentACarRepository));
builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(CommetRepository<>));
builder.Services.AddScoped(typeof(ICarFeatureRepository), typeof(CarFeatureRepository));
builder.Services.AddScoped(typeof(ICarDescriptionRepository), typeof(CarDescriptionRepository));

builder.Services.AddScoped<GetAboutQueryHandler>();
builder.Services.AddScoped<GetAboutByIDQueryHandler>();
builder.Services.AddScoped<CreateAboutCommandHandler>();
builder.Services.AddScoped<UpdateAboutCommandHandler>();
builder.Services.AddScoped<RemoveAboutCommandHandler>();

builder.Services.AddScoped<GetBannerQueryHandler>();
builder.Services.AddScoped<GetBannerByIDQueryHandler>();
builder.Services.AddScoped<CreateBannerCommandHandler>();
builder.Services.AddScoped<UpdateBannerCommandHandler>();
builder.Services.AddScoped<RemoveBannerCommandHandler>();

builder.Services.AddScoped<GetBrandQueryHandler>();
builder.Services.AddScoped<GetBrandByIdQueryHandler>();
builder.Services.AddScoped<CreateBrandCommadHandler>();
builder.Services.AddScoped<UpdateBrandCommandHandler>();
builder.Services.AddScoped<RemoveBrandCommandHandler>();

builder.Services.AddScoped<GetCarQueryHandler>();
builder.Services.AddScoped<GetCarByIDQueryHandler>();
builder.Services.AddScoped<CreateCarCommandHandler>();
builder.Services.AddScoped<UpdateCarCommandsHandler>();
builder.Services.AddScoped<RemoveCarCommandHandler>();
builder.Services.AddScoped<GetCarWithBrandQueryHandler>();
builder.Services.AddScoped<GetLast5CarWithBrandQueryHandler>();

builder.Services.AddScoped<GetCategoryQueryHandler>();
builder.Services.AddScoped<GetCategoryByIDQueryHandler>();
builder.Services.AddScoped<CreateCategoryCommandsHandler>();
builder.Services.AddScoped<UpdateCategoyCommandsHandler>();
builder.Services.AddScoped<RemoveCategoryCommandsHandler>();

builder.Services.AddScoped<GetContactByIdQueryHandler>();
builder.Services.AddScoped<GetConatctQueryHandler>();
builder.Services.AddScoped<CreateContactCommandHandler>();
builder.Services.AddScoped<UpdateContactCommandHandler>();
builder.Services.AddScoped<RemoveContactCommandHandler>();

builder.Services.AddApplicationService(builder.Configuration);


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
