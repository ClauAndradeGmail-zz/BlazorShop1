using BlazorShop1.Models.DTOs;

namespace BlazorShop1.Web.Services;

public interface IProdutoService
{
    Task<IEnumerable<ProdutoDto>> GetItens();
    Task<ProdutoDto> GetItem(int id);

    //consumir endpoint da api
    Task<IEnumerable<CategoriaDto>> GetCategorias();
    Task<IEnumerable<ProdutoDto>> GetItensPorCategoria(int categoriaId);
}

