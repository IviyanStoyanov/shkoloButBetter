var builder = WebApplication.CreateBuilder(args);

/// <summary>
/// Добавяне на услуги в контейнера.
/// </summary>
builder.Services.AddRazorPages();


/// <summary>
/// Добавяне на услуги в Database Context.
/// </summary>
builder.Services.AddDbContext<Data.Context>();

var app = builder.Build();

/// <summary>
/// Конфигуриране на HTTP заявки.
/// </summary>
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    /// <summary>
    /// Стойноста по подразбиране на HSTS е 30 дена. За промени виж: https://aka.ms/aspnetcore-hsts.
    /// </summary>
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
