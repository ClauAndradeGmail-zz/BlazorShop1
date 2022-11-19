using BlazorShop1.Api.Entities;
using BlazorShop1.Models.DTOs;

namespace BlazorShop1.Api.Repositories;

public interface ICarrinhoCompraRepository
{
    Task<CarrinhoItem> AdicionaItem(CarrinhoItemAdicionaDto carrinhoItemAdicionaDto);

    Task<CarrinhoItem> AtualizaQuantidade(int id, CarrinhoItemAtualizaQuantidadeDto 
                carrinhoAtualizaQuantidadeDto);

    Task<CarrinhoItem> DeletaItem(int id);

    Task<CarrinhoItem> GetItem(int id);

    Task<IEnumerable<CarrinhoItem>> GetItens(string usuarioId);
}
