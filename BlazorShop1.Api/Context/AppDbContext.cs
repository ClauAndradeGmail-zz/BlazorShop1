using BlazorShop1.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorShop1.Api.Context;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {

    }


    //Mapeamento
    public DbSet<Carrinho>? Carrinhos { get; set; }
    public DbSet<CarrinhoItem>? CarrinhoItens { get; set; }
    public DbSet<Produto>? Produtos { get; set; }
    public DbSet<Categoria>? Categorias { get; set;}
    public DbSet<Usuario>? Usuarios { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Categoria>().HasData(new Categoria
        {
            Id = 1,
            Nome = "Beleza",
            IconCSS = "fas fa-spa"
        });
        modelBuilder.Entity<Categoria>().HasData(new Categoria
        {
            Id = 2,
            Nome = "Móveis",
            IconCSS = "fas fa-couch"
        });
        modelBuilder.Entity<Categoria>().HasData(new Categoria
        {
            Id = 3,
            Nome = "Roupas",
            IconCSS = "fas fa-clothes-hanger"
        });
        modelBuilder.Entity<Categoria>().HasData(new Categoria
        {
            Id = 4,
            Nome = "Tênis",
            IconCSS = "fas fa-shoe-prints"
        });



        //Incluir Produtos
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 1,
            Nome = "Presente Natura Faces Look com Nécessaire - Marsala",
            Descricao = "Um trio infalível que salva qualquer pessoa que precisa de uma make rápida e marcante! Com a máscara de cílios que possui o efeito de máximo volume para os cílios, com o Batom queridinho a sua escolha e o lápis que é super prático e portátil que pode ser usado na sobrancelha e nos olhos é um combo que não tem como errar no look make! O presente vem com uma linda sacola presenteável.",
            ImagemUrl = "/Imagens/Categoria.Beleza.Produto1",
            Preco = 79.90m,
            Quantidade = 100,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 2,
            Nome = "Combo Faces Tá Pra Jogo",
            Descricao = "Um combo para quem tá pra jogo, com look completo para ganhar qualquer partida. Para as unhas, Esmalte Faces Azul Santiago; para olhar todos os lances com impacto, Paleta de Sombra Faces Ecovibes e, para gritar gol, Batom Color Hidra FPS 8 Faces Rosa 280. Tá na cara que é bem melhor torcer assim!",
            ImagemUrl = "/Imagens/Categoria.Beleza.Produto2",
            Preco = 69.9m,
            Quantidade = 50,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 3,
            Nome = "Combo Una Look Brilho No Olhar",
            Descricao = "O combo que vai marcar um gol de placa! Junte o Delineador Peel Off Una Azul Equilíbrio, que é ultra pigmentado, ao Esmalte 3D Gel Una Equilíbrio 480 e Gloss labial FPS 15 Una Rose 100, que o time da vitória está formado.",
            ImagemUrl = "/Imagens/Categoria.Beleza.Produto3",
            Preco = 94.9m,
            Quantidade = 25,
            CategoriaId = 1
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 4,
            Nome = "Presente Natura Una Brilho",
            Descricao = "Um presente que pode ser uma ótima lembrancinha para quem adora make com 2 itens que não tem quem não goste ou não use: Um gloss multifuncional que pode ser usado nos olhos, rosto e lábios com acabamento de brilho laqueado com textura gel com alto poder hidratante e brilho transparente e pode ser usado sobre outro produto que não altera a cor e adiciona somente brilho e um esmalte prisma com tecnologia Multichrome, que muda de cor conforme o ângulo da luz. Presente acompanha uma linda sacola mini que deixará tudo ainda mais especial.",
            ImagemUrl = "/Imagens/Categoria.Beleza.Produto4",
            Preco = 52.8m,
            Quantidade = 200,
            CategoriaId = 1
        });
        //Categoria 2
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 5,
            Nome = "Rack com Painel Para TV ate 72 Off White / Nature - Vivare Wood 1.8",
            Descricao = "Altura: 133cm x largura: 180cm x Profundidade: 21cm",
            ImagemUrl = "/Imagens/Categoria.Moveis.Produto1",
            Preco = 809m,
            Quantidade = 100,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 6,
            Nome = "Aparador Bar 4050 Jb Bechara Branco Brilho Sala de Jantar Branco",
            Descricao = "Aparador JB 4050 - JB Bechara Este lindo Aparador e mais uma criacao da JB Bechara com design moderno e diferenciado, agregando charme e beleza ao seu ambiente. Ele conta com estrutura em MDP de 12 e 15 mm, garantindo maior durabilidade do produto.",
            ImagemUrl = "/Imagens/Categoria.Moveis.Produto2",
            Preco = 230m,
            Quantidade = 50,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 7,
            Nome = "Armário Multiuso Napoles Lavanderia Branco 2 Portasmo",
            Descricao = "A Ofertamo vem trazendo este lindo armário com design compacto. Ele conta com estrutura em MDF/MDP, garantindo maior durabilidade do produto. Pensando na maior organização dos seus pertences, ele conta com ótimo espaço interno com prateleiras e suporte cabideiro, ideal para sua cozinha e lavanderia. Venha você também adquirir este lindo produto.",
            ImagemUrl = "/Imagens/Categoria.Moveis.Produto3",
            Preco = 348.21m,
            Quantidade = 150,
            CategoriaId = 2
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 8,
            Nome = "Aparador Café Drink com Portas Preto/Caramelo Pés em Madeira Pinus Ofertamo Preto Caramelo",
            Descricao = "Aparador Café Drink com Portas – Ofertamo O novo Aparador Café Drink, em versão retrô e com portas é produto exclusivo Ofertamo, e com características próprias. Multifuncional, para você que adora modificar os ambientes da casa. Pode ser utilizado como aparador bar para servir e organizar seus drinks, copos e bebidas transformando sua sala em um bar completo, ou para organizar seu cantinho do café, seus espaços permitem uma melhor acomodação de utensílios e objetos. Estrutura em MDP de 12mm, adega para até sete garrafas, bandeja fixa, 2 portas e pés em madeira maciça Pinus.",
            ImagemUrl = "/Imagens/Categoria.Moveis.Produto4",
            Preco = 271.26m,
            Quantidade = 30,
            CategoriaId = 2
        });
        //Categoria 3
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 9,
            Nome = "Vestido curto de tule poá manga bufante verde",
            Descricao = "Vestido desenvolvido em tule estampado de poá. A modelagem é ampla com comprimento curto e recorte inferior formando franzido. Possui recorte sob o busto e decote V. As mangas são 3/4 e bufantes com elástico embutido nos punhos. Tem forro em malha nas partes inferior e frontal.",
            ImagemUrl = "/Imagens/Categoria.Roupas.Produto1",
            Preco = 159.99m,
            Quantidade = 40,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 10,
            Nome = "Vestido midi decote reto alça franzida off white",
            Descricao = "Vestido confeccionado em tecido plano de viscose. A peça possui decote reto, alças médias elásticas com efeito fru fru, caimento reto, comprimento midi, recortes franzidos e fechamento posterior por zíper invisível.",
            ImagemUrl = "/Imagens/Categoria.Roupas.Produto2",
            Preco = 189.99m,
            Quantidade = 50,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 11,
            Nome = "Vestido midi de laise com lastex e babado off white",
            Descricao = "Vestido confeccionado em malha laise, com bordados e vazados. O modelo tem comprimento midi, parte superior ajustada com aplicação de lastex, parte inferior rodada com babado. As alças são finas com aplicação de babados. O decote é reto. Possui forro em malha.",
            ImagemUrl = "/Imagens/Categoria.Roupas.Produto3",
            Preco = 149.99m,
            Quantidade = 80,
            CategoriaId = 3
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 12,
            Nome = "Vestido midi de viscose decote amarração praia off white",
            Descricao = "Sem descrição de produto",
            ImagemUrl = "/Imagens/Categoria.Roupas.Produto4",
            Preco = 259.99m,
            Quantidade = 50,
            CategoriaId = 3
        });
        //Categoria 4
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 13,
            Nome = "Tênis Nike Revolution 6 FlyEase Next Nature Feminino",
            Descricao = "Para novos começos entre você e o asfalto. Sabemos que conforto é essencial para uma corrida de sucesso. Sendo assim, nos certificamos de amortecer os seus passos e torná-los flexíveis, proporcionando uma passada macia. Com faixa e zíper, esse tênis é fácil de calçar e tirar.",
            ImagemUrl = "/Imagens/Categoria.Tenis.Produto1",
            Preco = 399.99m,
            Quantidade = 50,
            CategoriaId = 4
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 14,
            Nome = "Tênis Nike Air Max Excee Feminino",
            Descricao = "Inspirado no Nike Air Max 90, o Nike Air Max Excee comemora um clássico com um visual repaginado. O design de linhas alongadas e proporções distorcidas na parte de cima elevam um ícone a um patamar moderno.",
            ImagemUrl = "/Imagens/Categoria.Tenis.Produto2",
            Preco = 499.99m,
            Quantidade = 100,
            CategoriaId = 4
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 15,
            Nome = "Tênis Nike Air Force 1 Infantil",
            Descricao = "Relace com o conforto do Nike Air Force 1. A sensação do couro clássico e os detalhes que fizeram deste tênis um ícone certamente farão com que seu estilo de tênis se destaque nas ruas.",
            ImagemUrl = "/Imagens/Categoria.Tenis.Produto3",
            Preco = 699.99m,
            Quantidade = 50,
            CategoriaId = 4
        });
        modelBuilder.Entity<Produto>().HasData(new Produto
        {
            Id = 16,
            Nome = "Tênis Nike Revolution 6 Next Nature Feminino",
            Descricao = "Feitos com pelo menos 2% de material reciclado por peso, os materiais antigos encontram novos começos. Agora você pode encontrar o seu. Defina o ritmo no início da sua corrida com a sensação de maciez do Nike Revolution 6 Next Nature. Sabemos que o conforto é a chave para uma corrida bem-sucedida, então adicionamos amortecimento e flexibilidade para uma passada mais macia. É a evolução de um favorito com um design ventilado.",
            ImagemUrl = "/Imagens/Categoria.Tenis.Produto4",
            Preco = 399.99m,
            Quantidade = 300,
            CategoriaId = 4
        });

        //Incluir Usuarios
        modelBuilder.Entity<Usuario>().HasData(new Usuario
        {
            Id = 1,
            NomeUsuario = "Claudia"
        });
        modelBuilder.Entity<Usuario>().HasData(new Usuario
        {
            Id = 2,
            NomeUsuario = "Patricia"
        });

        //Incluir Carrinho
        modelBuilder.Entity<Carrinho>().HasData(new Carrinho
        {
            Id = 1,
            UsuarioId = 1
        });
    }
}
