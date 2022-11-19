using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorShop1.Api.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorias",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IconCSS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeUsuario = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(700)", maxLength: 200, nullable: false),
                    ImagemUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Preco = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Produtos_Categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "Categorias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carrinhos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UsuarioId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carrinhos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Carrinhos_Usuarios_UsuarioId",
                        column: x => x.UsuarioId,
                        principalTable: "Usuarios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CarrinhoItens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarrinhoId = table.Column<int>(type: "int", nullable: false),
                    ProdutoId = table.Column<int>(type: "int", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarrinhoItens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Carrinhos_CarrinhoId",
                        column: x => x.CarrinhoId,
                        principalTable: "Carrinhos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarrinhoItens_Produtos_ProdutoId",
                        column: x => x.ProdutoId,
                        principalTable: "Produtos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categorias",
                columns: new[] { "Id", "IconCSS", "Nome" },
                values: new object[,]
                {
                    { 1, "fas fa-spa", "Beleza" },
                    { 2, "fas fa-couch", "Móveis" },
                    { 3, "fas fa-clothes-hanger", "Roupas" },
                    { 4, "fas fa-shoe-prints", "Tênis" }
                });

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "Id", "NomeUsuario" },
                values: new object[,]
                {
                    { 1, "Claudia" },
                    { 2, "Patricia" }
                });

            migrationBuilder.InsertData(
                table: "Carrinhos",
                columns: new[] { "Id", "UsuarioId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "CategoriaId", "Descricao", "ImagemUrl", "Nome", "Preco", "Quantidade" },
                values: new object[,]
                {
                    { 1, 1, "Um trio infalível que salva qualquer pessoa que precisa de uma make rápida e marcante! Com a máscara de cílios que possui o efeito de máximo volume para os cílios, com o Batom queridinho a sua escolha e o lápis que é super prático e portátil que pode ser usado na sobrancelha e nos olhos é um combo que não tem como errar no look make! O presente vem com uma linda sacola presenteável.", "/Imagens/Categoria.Beleza.Produto1", "Presente Natura Faces Look com Nécessaire - Marsala", 79.90m, 100 },
                    { 2, 1, "Um combo para quem tá pra jogo, com look completo para ganhar qualquer partida. Para as unhas, Esmalte Faces Azul Santiago; para olhar todos os lances com impacto, Paleta de Sombra Faces Ecovibes e, para gritar gol, Batom Color Hidra FPS 8 Faces Rosa 280. Tá na cara que é bem melhor torcer assim!", "/Imagens/Categoria.Beleza.Produto2", "Combo Faces Tá Pra Jogo", 69.9m, 50 },
                    { 3, 1, "O combo que vai marcar um gol de placa! Junte o Delineador Peel Off Una Azul Equilíbrio, que é ultra pigmentado, ao Esmalte 3D Gel Una Equilíbrio 480 e Gloss labial FPS 15 Una Rose 100, que o time da vitória está formado.", "/Imagens/Categoria.Beleza.Produto3", "Combo Una Look Brilho No Olhar", 94.9m, 25 },
                    { 4, 1, "Um presente que pode ser uma ótima lembrancinha para quem adora make com 2 itens que não tem quem não goste ou não use: Um gloss multifuncional que pode ser usado nos olhos, rosto e lábios com acabamento de brilho laqueado com textura gel com alto poder hidratante e brilho transparente e pode ser usado sobre outro produto que não altera a cor e adiciona somente brilho e um esmalte prisma com tecnologia Multichrome, que muda de cor conforme o ângulo da luz. Presente acompanha uma linda sacola mini que deixará tudo ainda mais especial.", "/Imagens/Categoria.Beleza.Produto4", "Presente Natura Una Brilho", 52.8m, 200 },
                    { 5, 2, "Altura: 133cm x largura: 180cm x Profundidade: 21cm", "/Imagens/Categoria.Moveis.Produto1", "Rack com Painel Para TV ate 72 Off White - Nature - Vivare Wood 1.8", 809m, 100 },
                    { 6, 2, "Aparador JB 4050 - JB Bechara Este lindo Aparador e mais uma criacao da JB Bechara com design moderno e diferenciado, agregando charme e beleza ao seu ambiente. Ele conta com estrutura em MDP de 12 e 15 mm, garantindo maior durabilidade do produto.", "/Imagens/Categoria.Moveis.Produto2", "Aparador Bar 4050 Jb Bechara Branco Brilho Sala de Jantar Branco", 230m, 50 },
                    { 7, 2, "A Ofertamo vem trazendo este lindo armário com design compacto. Ele conta com estrutura em MDF/MDP, garantindo maior durabilidade do produto. Pensando na maior organização dos seus pertences, ele conta com ótimo espaço interno com prateleiras e suporte cabideiro, ideal para sua cozinha e lavanderia. Venha você também adquirir este lindo produto.", "/Imagens/Categoria.Moveis.Produto3", "Armário Multiuso Napoles Lavanderia Branco 2 Portasmo", 348.21m, 150 },
                    { 8, 2, "Aparador Café Drink com Portas – Ofertamo O novo Aparador Café Drink, em versão retrô e com portas é produto exclusivo Ofertamo, e com características próprias. Multifuncional, para você que adora modificar os ambientes da casa. Pode ser utilizado como aparador bar para servir e organizar seus drinks, copos e bebidas transformando sua sala em um bar completo, ou para organizar seu cantinho do café, seus espaços permitem uma melhor acomodação de utensílios e objetos. Estrutura em MDP de 12mm, adega para até sete garrafas, bandeja fixa, 2 portas e pés em madeira maciça Pinus.", "/Imagens/Categoria.Moveis.Produto4", "Aparador Café Drink com Portas Preto/Caramelo Pés em Madeira Pinus Ofertamo Preto Caramelo", 271.26m, 30 },
                    { 9, 3, "Vestido desenvolvido em tule estampado de poá. A modelagem é ampla com comprimento curto e recorte inferior formando franzido. Possui recorte sob o busto e decote V. As mangas são 3/4 e bufantes com elástico embutido nos punhos. Tem forro em malha nas partes inferior e frontal.", "/Imagens/Categoria.Roupas.Produto1", "Vestido curto de tule poá manga bufante verde", 159.99m, 40 },
                    { 10, 3, "Vestido confeccionado em tecido plano de viscose. A peça possui decote reto, alças médias elásticas com efeito fru fru, caimento reto, comprimento midi, recortes franzidos e fechamento posterior por zíper invisível.", "/Imagens/Categoria.Roupas.Produto2", "Vestido midi decote reto alça franzida off white", 189.99m, 50 },
                    { 11, 3, "Vestido confeccionado em malha laise, com bordados e vazados. O modelo tem comprimento midi, parte superior ajustada com aplicação de lastex, parte inferior rodada com babado. As alças são finas com aplicação de babados. O decote é reto. Possui forro em malha.", "/Imagens/Categoria.Roupas.Produto3", "Vestido midi de laise com lastex e babado off white", 149.99m, 80 },
                    { 12, 3, "Sem descrição de produto", "/Imagens/Categoria.Roupas.Produto4", "Vestido midi de viscose decote amarração praia off white", 259.99m, 50 },
                    { 13, 4, "Para novos começos entre você e o asfalto. Sabemos que conforto é essencial para uma corrida de sucesso. Sendo assim, nos certificamos de amortecer os seus passos e torná-los flexíveis, proporcionando uma passada macia. Com faixa e zíper, esse tênis é fácil de calçar e tirar.", "/Imagens/Categoria.Tenis.Produto1", "Tênis Nike Revolution 6 FlyEase Next Nature Feminino", 399.99m, 50 },
                    { 14, 4, "Inspirado no Nike Air Max 90, o Nike Air Max Excee comemora um clássico com um visual repaginado. O design de linhas alongadas e proporções distorcidas na parte de cima elevam um ícone a um patamar moderno.", "/Imagens/Categoria.Tenis.Produto2", "Tênis Nike Air Max Excee Feminino", 499.99m, 100 },
                    { 15, 4, "Relace com o conforto do Nike Air Force 1. A sensação do couro clássico e os detalhes que fizeram deste tênis um ícone certamente farão com que seu estilo de tênis se destaque nas ruas.", "/Imagens/Categoria.Tenis.Produto3", "Tênis Nike Air Force 1 Infantil", 699.99m, 50 },
                    { 16, 4, "Feitos com pelo menos 2% de material reciclado por peso, os materiais antigos encontram novos começos. Agora você pode encontrar o seu. Defina o ritmo no início da sua corrida com a sensação de maciez do Nike Revolution 6 Next Nature. Sabemos que o conforto é a chave para uma corrida bem-sucedida, então adicionamos amortecimento e flexibilidade para uma passada mais macia. É a evolução de um favorito com um design ventilado.", "/Imagens/Categoria.Tenis.Produto4", "Tênis Nike Revolution 6 Next Nature Feminino", 399.99m, 300 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_CarrinhoId",
                table: "CarrinhoItens",
                column: "CarrinhoId");

            migrationBuilder.CreateIndex(
                name: "IX_CarrinhoItens_ProdutoId",
                table: "CarrinhoItens",
                column: "ProdutoId");

            migrationBuilder.CreateIndex(
                name: "IX_Carrinhos_UsuarioId",
                table: "Carrinhos",
                column: "UsuarioId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Produtos_CategoriaId",
                table: "Produtos",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarrinhoItens");

            migrationBuilder.DropTable(
                name: "Carrinhos");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "Usuarios");

            migrationBuilder.DropTable(
                name: "Categorias");
        }
    }
}
