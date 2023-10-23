var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages(); // Добавляю своему строителю поддержку Razor Pages


builder.Services.AddSession(); // Добавляю поддержку сессий

// Доо этой строчки кода добавляются все настройки строителя
var app = builder.Build(); // Создаю приложение

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error"); // Если приложение не в режиме разработки, то использую обработчик ошибок
    app.UseHsts(); // Использую HSTS
}

// Все, что начинается с app.Use - это Middleware

app.UseSession(); // Использую сессии
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
