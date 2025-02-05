var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();


/* 
Controller: İstekleri işleyen sınıf.
Action: Controller'da, bir isteği işleyen metot.
Model: Uygulamanın veri yapısı.
View: Kullanıcıya gösterilen HTML şablonları.
Razor: View'lerde C# kodu ve HTML kodunun birleştiği şablon motoru.
RazorView: Razor kullanarak dinamik HTML içeriği oluşturan dosyalar.
wwwroot: Statik dosyaların (CSS, JS, resimler vb.) barındığı klasör.
builder.Build(): WebApplication nesnesini oluşturur.
app.Run(): Uygulamayı başlatır ve istekleri işlemeye başlar.
*/