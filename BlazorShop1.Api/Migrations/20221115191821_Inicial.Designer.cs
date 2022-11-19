﻿// <auto-generated />
using BlazorShop1.Api.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorShop1.Api.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20221115191821_Inicial")]
    partial class Inicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BlazorShop1.Api.Entities.Carrinho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("UsuarioId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioId")
                        .IsUnique();

                    b.ToTable("Carrinhos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            UsuarioId = 1
                        });
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.CarrinhoItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarrinhoId")
                        .HasColumnType("int");

                    b.Property<int>("ProdutoId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CarrinhoId");

                    b.HasIndex("ProdutoId");

                    b.ToTable("CarrinhoItens");
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Categorias");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            IconCSS = "fas fa-spa",
                            Nome = "Beleza"
                        },
                        new
                        {
                            Id = 2,
                            IconCSS = "fas fa-couch",
                            Nome = "Móveis"
                        },
                        new
                        {
                            Id = 3,
                            IconCSS = "fas fa-clothes-hanger",
                            Nome = "Roupas"
                        },
                        new
                        {
                            Id = 4,
                            IconCSS = "fas fa-shoe-prints",
                            Nome = "Tênis"
                        });
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaId")
                        .HasColumnType("int");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("ImagemUrl")
                        .IsRequired()
                        .HasMaxLength(700)
                        .HasColumnType("nvarchar(700)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(10,2");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoriaId");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoriaId = 1,
                            Descricao = "Um trio infalível que salva qualquer pessoa que precisa de uma make rápida e marcante! Com a máscara de cílios que possui o efeito de máximo volume para os cílios, com o Batom queridinho a sua escolha e o lápis que é super prático e portátil que pode ser usado na sobrancelha e nos olhos é um combo que não tem como errar no look make! O presente vem com uma linda sacola presenteável.",
                            ImagemUrl = "/Imagens/Categoria.Beleza.Produto1",
                            Nome = "Presente Natura Faces Look com Nécessaire - Marsala",
                            Preco = 79.90m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 2,
                            CategoriaId = 1,
                            Descricao = "Um combo para quem tá pra jogo, com look completo para ganhar qualquer partida. Para as unhas, Esmalte Faces Azul Santiago; para olhar todos os lances com impacto, Paleta de Sombra Faces Ecovibes e, para gritar gol, Batom Color Hidra FPS 8 Faces Rosa 280. Tá na cara que é bem melhor torcer assim!",
                            ImagemUrl = "/Imagens/Categoria.Beleza.Produto2",
                            Nome = "Combo Faces Tá Pra Jogo",
                            Preco = 69.9m,
                            Quantidade = 50
                        },
                        new
                        {
                            Id = 3,
                            CategoriaId = 1,
                            Descricao = "O combo que vai marcar um gol de placa! Junte o Delineador Peel Off Una Azul Equilíbrio, que é ultra pigmentado, ao Esmalte 3D Gel Una Equilíbrio 480 e Gloss labial FPS 15 Una Rose 100, que o time da vitória está formado.",
                            ImagemUrl = "/Imagens/Categoria.Beleza.Produto3",
                            Nome = "Combo Una Look Brilho No Olhar",
                            Preco = 94.9m,
                            Quantidade = 25
                        },
                        new
                        {
                            Id = 4,
                            CategoriaId = 1,
                            Descricao = "Um presente que pode ser uma ótima lembrancinha para quem adora make com 2 itens que não tem quem não goste ou não use: Um gloss multifuncional que pode ser usado nos olhos, rosto e lábios com acabamento de brilho laqueado com textura gel com alto poder hidratante e brilho transparente e pode ser usado sobre outro produto que não altera a cor e adiciona somente brilho e um esmalte prisma com tecnologia Multichrome, que muda de cor conforme o ângulo da luz. Presente acompanha uma linda sacola mini que deixará tudo ainda mais especial.",
                            ImagemUrl = "/Imagens/Categoria.Beleza.Produto4",
                            Nome = "Presente Natura Una Brilho",
                            Preco = 52.8m,
                            Quantidade = 200
                        },
                        new
                        {
                            Id = 5,
                            CategoriaId = 2,
                            Descricao = "Altura: 133cm x largura: 180cm x Profundidade: 21cm",
                            ImagemUrl = "/Imagens/Categoria.Moveis.Produto1",
                            Nome = "Rack com Painel Para TV ate 72\" Off White / Nature - Vivare Wood 1.8",
                            Preco = 809m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 6,
                            CategoriaId = 2,
                            Descricao = "Aparador JB 4050 - JB Bechara Este lindo Aparador e mais uma criacao da JB Bechara com design moderno e diferenciado, agregando charme e beleza ao seu ambiente. Ele conta com estrutura em MDP de 12 e 15 mm, garantindo maior durabilidade do produto.",
                            ImagemUrl = "/Imagens/Categoria.Moveis.Produto2",
                            Nome = "Aparador Bar 4050 Jb Bechara Branco Brilho Sala de Jantar Branco",
                            Preco = 230m,
                            Quantidade = 50
                        },
                        new
                        {
                            Id = 7,
                            CategoriaId = 2,
                            Descricao = "A Ofertamo vem trazendo este lindo armário com design compacto. Ele conta com estrutura em MDF/MDP, garantindo maior durabilidade do produto. Pensando na maior organização dos seus pertences, ele conta com ótimo espaço interno com prateleiras e suporte cabideiro, ideal para sua cozinha e lavanderia. Venha você também adquirir este lindo produto.",
                            ImagemUrl = "/Imagens/Categoria.Moveis.Produto3",
                            Nome = "Armário Multiuso Napoles Lavanderia Branco 2 Portasmo",
                            Preco = 348.21m,
                            Quantidade = 150
                        },
                        new
                        {
                            Id = 8,
                            CategoriaId = 2,
                            Descricao = "Aparador Café Drink com Portas – Ofertamo O novo Aparador Café Drink, em versão retrô e com portas é produto exclusivo Ofertamo, e com características próprias. Multifuncional, para você que adora modificar os ambientes da casa. Pode ser utilizado como aparador bar para servir e organizar seus drinks, copos e bebidas transformando sua sala em um bar completo, ou para organizar seu cantinho do café, seus espaços permitem uma melhor acomodação de utensílios e objetos. Estrutura em MDP de 12mm, adega para até sete garrafas, bandeja fixa, 2 portas e pés em madeira maciça Pinus.",
                            ImagemUrl = "/Imagens/Categoria.Moveis.Produto4",
                            Nome = "Aparador Café Drink com Portas Preto/Caramelo Pés em Madeira Pinus Ofertamo Preto Caramelo",
                            Preco = 271.26m,
                            Quantidade = 30
                        },
                        new
                        {
                            Id = 9,
                            CategoriaId = 3,
                            Descricao = "Vestido desenvolvido em tule estampado de poá. A modelagem é ampla com comprimento curto e recorte inferior formando franzido. Possui recorte sob o busto e decote V. As mangas são 3/4 e bufantes com elástico embutido nos punhos. Tem forro em malha nas partes inferior e frontal.",
                            ImagemUrl = "/Imagens/Categoria.Roupas.Produto1",
                            Nome = "Vestido curto de tule poá manga bufante verde",
                            Preco = 159.99m,
                            Quantidade = 40
                        },
                        new
                        {
                            Id = 10,
                            CategoriaId = 3,
                            Descricao = "Vestido confeccionado em tecido plano de viscose. A peça possui decote reto, alças médias elásticas com efeito fru fru, caimento reto, comprimento midi, recortes franzidos e fechamento posterior por zíper invisível.",
                            ImagemUrl = "/Imagens/Categoria.Roupas.Produto2",
                            Nome = "Vestido midi decote reto alça franzida off white",
                            Preco = 189.99m,
                            Quantidade = 50
                        },
                        new
                        {
                            Id = 11,
                            CategoriaId = 3,
                            Descricao = "Vestido confeccionado em malha laise, com bordados e vazados. O modelo tem comprimento midi, parte superior ajustada com aplicação de lastex, parte inferior rodada com babado. As alças são finas com aplicação de babados. O decote é reto. Possui forro em malha.",
                            ImagemUrl = "/Imagens/Categoria.Roupas.Produto3",
                            Nome = "Vestido midi de laise com lastex e babado off white",
                            Preco = 149.99m,
                            Quantidade = 80
                        },
                        new
                        {
                            Id = 12,
                            CategoriaId = 3,
                            Descricao = "Sem descrição de produto",
                            ImagemUrl = "/Imagens/Categoria.Roupas.Produto4",
                            Nome = "Vestido midi de viscose decote amarração praia off white",
                            Preco = 259.99m,
                            Quantidade = 50
                        },
                        new
                        {
                            Id = 13,
                            CategoriaId = 4,
                            Descricao = "Para novos começos entre você e o asfalto. Sabemos que conforto é essencial para uma corrida de sucesso. Sendo assim, nos certificamos de amortecer os seus passos e torná-los flexíveis, proporcionando uma passada macia. Com faixa e zíper, esse tênis é fácil de calçar e tirar.",
                            ImagemUrl = "/Imagens/Categoria.Tenis.Produto1",
                            Nome = "Tênis Nike Revolution 6 FlyEase Next Nature Feminino",
                            Preco = 399.99m,
                            Quantidade = 50
                        },
                        new
                        {
                            Id = 14,
                            CategoriaId = 4,
                            Descricao = "Inspirado no Nike Air Max 90, o Nike Air Max Excee comemora um clássico com um visual repaginado. O design de linhas alongadas e proporções distorcidas na parte de cima elevam um ícone a um patamar moderno.",
                            ImagemUrl = "/Imagens/Categoria.Tenis.Produto2",
                            Nome = "Tênis Nike Air Max Excee Feminino",
                            Preco = 499.99m,
                            Quantidade = 100
                        },
                        new
                        {
                            Id = 15,
                            CategoriaId = 4,
                            Descricao = "Relace com o conforto do Nike Air Force 1. A sensação do couro clássico e os detalhes que fizeram deste tênis um ícone certamente farão com que seu estilo de tênis se destaque nas ruas.",
                            ImagemUrl = "/Imagens/Categoria.Tenis.Produto3",
                            Nome = "Tênis Nike Air Force 1 Infantil",
                            Preco = 699.99m,
                            Quantidade = 50
                        },
                        new
                        {
                            Id = 16,
                            CategoriaId = 4,
                            Descricao = "Feitos com pelo menos 2% de material reciclado por peso, os materiais antigos encontram novos começos. Agora você pode encontrar o seu. Defina o ritmo no início da sua corrida com a sensação de maciez do Nike Revolution 6 Next Nature. Sabemos que o conforto é a chave para uma corrida bem-sucedida, então adicionamos amortecimento e flexibilidade para uma passada mais macia. É a evolução de um favorito com um design ventilado.",
                            ImagemUrl = "/Imagens/Categoria.Tenis.Produto4",
                            Nome = "Tênis Nike Revolution 6 Next Nature Feminino",
                            Preco = 399.99m,
                            Quantidade = 300
                        });
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("NomeUsuario")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            NomeUsuario = "Claudia"
                        },
                        new
                        {
                            Id = 2,
                            NomeUsuario = "Patricia"
                        });
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.Carrinho", b =>
                {
                    b.HasOne("BlazorShop1.Api.Entities.Usuario", null)
                        .WithOne("Carrinho")
                        .HasForeignKey("BlazorShop1.Api.Entities.Carrinho", "UsuarioId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.CarrinhoItem", b =>
                {
                    b.HasOne("BlazorShop1.Api.Entities.Carrinho", "Carrinho")
                        .WithMany("Itens")
                        .HasForeignKey("CarrinhoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorShop1.Api.Entities.Produto", "Produto")
                        .WithMany("Itens")
                        .HasForeignKey("ProdutoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrinho");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.Produto", b =>
                {
                    b.HasOne("BlazorShop1.Api.Entities.Categoria", "Categoria")
                        .WithMany("Produtos")
                        .HasForeignKey("CategoriaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categoria");
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.Carrinho", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.Categoria", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.Produto", b =>
                {
                    b.Navigation("Itens");
                });

            modelBuilder.Entity("BlazorShop1.Api.Entities.Usuario", b =>
                {
                    b.Navigation("Carrinho");
                });
#pragma warning restore 612, 618
        }
    }
}