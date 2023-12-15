using Serilog;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDistributedMemoryCache();

builder.Services.AddSession(ops =>
{
    ops.IdleTimeout = TimeSpan.FromMinutes(30);
    ops.Cookie.HttpOnly = true;
});

//builder.Host.UseSerilog();


builder.Services.AddRazorPages();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

//app.UseSerilogRequestLogging();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
