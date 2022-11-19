using BlazorShop1.Models.DTOs;

namespace BlazorShop1.Web.Services
{
    public interface IGerenciaCarrinhoItensLocalStorageService
    {
        Task<List<CarrinhoItemDto>> GetCollection();
        Task SaveCollection(List<CarrinhoItemDto> carrinhoItensDto);
        Task RemoveCollection();
    }
}
