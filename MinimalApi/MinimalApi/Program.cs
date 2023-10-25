using InstantAPIs;
using Microsoft.EntityFrameworkCore;
using MinimalApi.Data.Dbcontexts;
using MinimalApi.Data.Models;

//using Aloha = Microsoft.AspNetCore.Builder;
//using static Microsoft.AspNetCore.Builder.EndpointRouteBuilderExtensions;


var builder = WebApplication.CreateBuilder(args); // Pattern builder

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AcademyContext>(ops => 
            ops.UseSqlServer(builder.Configuration.GetConnectionString("Default")));

builder.Services.AddInstantAPIs();

var app = builder.Build(); // Добавляет в HttpContext свойство RequestServices

app.MapInstantAPIs<AcademyContext>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Веб приложение, для тестирования API
    app.UseSwaggerUI(); // Добавление его UI в приложение
}

app.UseHttpsRedirection();


app.MapGet("/test", async (AcademyContext context) =>
{
   return await context.Students.ToListAsync();
});


app.MapPost("/test", async (User student) =>
{
    // https://habr.com/ru/companies/simbirsoft/articles/690970/

    /*
    CreateScope() - нужен для того чтобы выйти из области видимости делегата,
    в котром мы находимся, иначе мы не сможем получить доступ к сервисам, которые
    мы зарегистрировали сверху
    */

    using var scope = app.Services.CreateScope();

    var context = scope.ServiceProvider.GetRequiredService<AcademyContext>();

    context.Users.Add(student);
    await context.SaveChangesAsync();
    return Results.Created($"/test/{student.Id}", student);
});

app.Run();