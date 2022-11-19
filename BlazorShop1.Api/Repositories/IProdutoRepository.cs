using BlazorShop1.Api.Entities;

namespace BlazorShop1.Api.Repositories;

public interface IProdutoRepository
{
    //obter todos os produtos
    Task<IEnumerable<Produto>> GetItens();

    // um produto em especifico
    Task<Produto> GetItem(int id);

    //produto de uma categoria em especifico
    Task<IEnumerable<Produto>> GetItensPorCategoria(int id);
    //Task<IEnumerable<Categoria>> GetitensPorCategoria(int id);
    Task<IEnumerable<Categoria>> GetCategorias();
}
