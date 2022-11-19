using BlazorShop1.Models.DTOs;

namespace BlazorShop1.Web.Services;

public interface ICarrinhoCompraService
{
    Task<List<CarrinhoItemDto>> GetItens(string usuarioId);
    Task<CarrinhoItemDto> AdicionarItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto);
    Task<CarrinhoItemDto> DeletaItem(int id);
    Task<CarrinhoItemDto> AtualizaQuantidade(CarrinhoItemAtualizaQuantidadeDto carrinhoItemAtualizaQuantidadeDto);
    
    event Action<int> OnCarrinhoCompraChanged;
    void RaiseEventOncarrinhoCompraChanged(int totalQuantidade);


}
