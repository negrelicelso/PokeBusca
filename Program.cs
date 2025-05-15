using PokeBusca.Components;

var Imagens = "_imagens";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: Imagens, policy =>
    {
        policy.WithOrigins("https://raw.githubusercontent.com/PokeAPI/")
              .AllowAnyHeader()
              .WithMethods("GET")
              .WithExposedHeaders("Content-Disposition");
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}
app.UseCors(Imagens);

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
