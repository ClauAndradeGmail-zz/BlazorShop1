using Blazored.LocalStorage;
using BlazorShop1.Web;
using BlazorShop1.Web.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//endereço base da url da API
var baseUrl = "https://localhost:7233";
builder.Services.AddScoped(sp => new HttpClient 
{ 
    BaseAddress = new Uri(baseUrl) 
});

//registro do serviço Produto
builder.Services.AddScoped<IProdutoService, ProdutoService>();
builder.Services.AddScoped<ICarrinhoCompraService, CarrinhoCompraService>();


builder.Services.AddBlazoredLocalStorage();
builder.Services.AddScoped<IGerenciaProdutosLocalStorageService, 
                            GerenciaProdutosLocalStorageService>();

builder.Services.AddScoped<IGerenciaCarrinhoItensLocalStorageService, 
                            GerenciaCarrinhoItensLocalStorageService>();

await builder.Build().RunAsync();
