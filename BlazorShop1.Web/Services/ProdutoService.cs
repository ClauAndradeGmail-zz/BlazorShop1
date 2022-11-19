﻿using BlazorShop1.Models.DTOs;
using System.Net;
using System.Net.Http.Json;

namespace BlazorShop1.Web.Services;

public class ProdutoService : IProdutoService
{

    public HttpClient _httpClient;
    public ILogger<ProdutoService> _logger;

    public ProdutoService(HttpClient httpClient, ILogger<ProdutoService> logger)
    {
        _httpClient = httpClient;
        _logger = logger;
    }

    public async Task<IEnumerable<CategoriaDto>> GetCategorias()
    {
        try
        {
            var response = await _httpClient.GetAsync("api/Produtos/GetCategorias");
            if (response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    return Enumerable.Empty<CategoriaDto>();
                }
                return await response.Content.ReadFromJsonAsync<IEnumerable<CategoriaDto>>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Http Status Code - {response.StatusCode} Message = {message}");
            }
        }
        catch (Exception)
        {
            //log exception - log de auditoria
            throw;
        }
    }

    public async Task<ProdutoDto> GetItem(int id)
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/produtos/{id}");
            if (response.IsSuccessStatusCode) //status code 200-299
            {
                if (response.StatusCode == HttpStatusCode.NoContent) //status 204
                {
                    return default(ProdutoDto); //retorna os valores padrão/empty
                }
                return await response.Content.ReadFromJsonAsync<ProdutoDto>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                _logger.LogError($"Erro a obter produto pelo Id = {id} - {message}");
                throw new Exception($"Status Code : {response.StatusCode} - {message}");
            }
        }
        catch (Exception)
        {
            _logger.LogError($"Erro a obter produto pelo Id = {id}");
            throw;
        }
    }

    public async Task<IEnumerable<ProdutoDto>> GetItens()
    {
        try
        {
            var produtosDto = await _httpClient
                        .GetFromJsonAsync<IEnumerable<ProdutoDto>>("api/produtos");
            return produtosDto;
        }
        catch (Exception)
        {
            _logger.LogError("Erro ao acessar produtos: api/produtos");
            throw;
        }
        
    }

    public async Task<IEnumerable<ProdutoDto>> GetItensPorCategoria(int categoriaId)
    {
        try
        {
            var response = await _httpClient.GetAsync($"api/Produtos/{categoriaId}/GetItensPorCategoria");
            if(response.IsSuccessStatusCode)
            {
                if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    return Enumerable.Empty<ProdutoDto> ();
                }
                return await response.Content.ReadFromJsonAsync<IEnumerable<ProdutoDto>>();
            }
            else
            {
                var message = await response.Content.ReadAsStringAsync();
                throw new Exception($"Http Status Code - {response.StatusCode} Message - {message}");
            }
        }
        catch (Exception)
        {
            //log exception - log de auditoria
            throw;
        }
    }
}
