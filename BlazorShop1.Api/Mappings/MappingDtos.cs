using BlazorShop1.Api.Entities;
using BlazorShop1.Models.DTOs;
using System.Collections.Immutable;

namespace BlazorShop1.Api.Mappings;

public static class MappingDtos
{
    //retornando a lista de categorias
    public static IEnumerable<CategoriaDto> ConverterCategoriaParaDto(
                                            this IEnumerable<Categoria> categorias)
    {
        return (from categoria in categorias
                select new CategoriaDto
                {
                    Id = categoria.Id,
                    Nome = categoria.Nome,
                    IconCSS = categoria.IconCSS,
                }).ToList();
    }

    //retornando a lista de Produtos
    public static IEnumerable<ProdutoDto> ConverterProdutosParaDto(
                                          this IEnumerable<Produto> produtos)
    {
        return (from produto in produtos
                select new ProdutoDto
                {
                    Id = produto.Id,
                    Nome = produto.Nome,
                    Descricao = produto.Descricao,
                    ImagemUrl = produto.ImagemUrl,
                    Preco = produto.Preco,
                    Quantidade = produto.Quantidade,
                    CategoriaId = produto.CategoriaId,
                    CategoriaNome = produto.Categoria.Nome
                }).ToList();
    }

    //retornando o produto Selecionado
    public static ProdutoDto ConverterProdutoParaDto(
                            this Produto produto)
    {
        return new ProdutoDto
        {
            Id = produto.Id,
            Nome = produto.Nome,
            Descricao = produto.Descricao,
            ImagemUrl = produto.ImagemUrl,
            Preco = produto.Preco,
            Quantidade = produto.Quantidade,
            CategoriaId = produto.CategoriaId,
            CategoriaNome = produto.Categoria.Nome
        };
    }

    //retornando os produtos do carrinho
    public static IEnumerable<CarrinhoItemDto> ConverterCarrinhoItemParaDtO(
    this IEnumerable<CarrinhoItem> carrinhoItens, IEnumerable<Produto> produtos)
    {
        return (from carrinhoItem in carrinhoItens
                join produto in produtos
                on carrinhoItem.ProdutoId equals produto.Id
                select new CarrinhoItemDto
                {
                    Id = carrinhoItem.Id,
                    ProdutoId = carrinhoItem.ProdutoId,
                    ProdutoNome = produto.Nome,
                    ProdutoDescricao = produto.Descricao,
                    ProdutoImagemUrl = produto.ImagemUrl,
                    Preco = produto.Preco,
                    CarrinhoId = carrinhoItem.CarrinhoId,
                    Quantidade = carrinhoItem.Quantidade,
                    PrecoTotal = produto.Preco * carrinhoItem.Quantidade
                }
                ).ToList();
    }

    //Retornando um item do carrinho
    public static CarrinhoItemDto ConverterCarrinhoItemParaDto(
                                  this CarrinhoItem carrinhoItem, Produto produto )
    {
        return new CarrinhoItemDto
        {
            Id = carrinhoItem.Id,
            ProdutoId = carrinhoItem.ProdutoId,
            ProdutoNome = produto.Nome,
            ProdutoDescricao = produto.Descricao,
            ProdutoImagemUrl = produto.ImagemUrl,
            Preco = produto.Preco,
            CarrinhoId = carrinhoItem.CarrinhoId,
            Quantidade = carrinhoItem.Quantidade,
            PrecoTotal = produto.Preco * carrinhoItem.Quantidade
        };
    } 
}
