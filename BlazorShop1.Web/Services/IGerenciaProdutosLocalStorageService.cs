using BlazorShop1.Models.DTOs;

namespace BlazorShop1.Web.Services
{
    public interface IGerenciaProdutosLocalStorageService
    {
        Task<IEnumerable<ProdutoDto>> GetCollection();
        Task RemoveCollection();
    }
}
