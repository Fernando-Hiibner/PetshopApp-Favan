using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace PetshopApp.Models
{
    public static class SeedData
    {
        public static void Inicializar(IServiceProvider serviceProvider)
        {
            using (var context = new PetShopAppContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<PetShopAppContext>>()))
            {
                // verificar se há dados no banco
                if (!context.Proprietario.Any())
                {
                    context.Proprietario.AddRange(
                        new Proprietario
                        {
                            Nome = "Agatha Esther da Rocha",
                            Cpf = "081.878.098-33",
                            Endereco = "Rua Independência, 600",
                            Telefone = "(14) 98524-1532",
                            Email = "agatha.esther.darocha@granvale.com.br",
                            DtNascimento = DateTime.Parse("1983-04-01"),
                        },
                        new Proprietario
                        {
                            Nome = "Edson Mateus Pires",
                            Cpf = "64815432821",
                            Endereco = "Jardim Santa Maria, 552",
                            Telefone = "1137434016",
                            Email = "edson.mateus.pires@yahoo.de",
                            DtNascimento = DateTime.Parse("1967-03-11"),
                        },
                        new Proprietario
                        {
                            Nome = "Lucca Luiz Martin da Costa",
                            Cpf = "11379633877",
                            Endereco = "Rua Trombetas, 603",
                            Telefone = "11379633877",
                            Email = "lucca_luiz_dacosta@cpfl.com.br",
                            DtNascimento = DateTime.Parse("1999-02-16"),
                        },
                        new Proprietario
                        {
                            Nome = "Bárbara Vanessa Castro",
                            Cpf = "46112068826",
                            Endereco = "Cidade Nova I, 928",
                            Telefone = "11997048759",
                            Email = "barbara-castro85@conexao.com",
                            DtNascimento = DateTime.Parse("1944-03-15"),
                        },
                        new Proprietario
                        {
                            Nome = "Turbante Caminhoneiro Louco Maluco Psicopata Pedófilo",
                            Cpf = "56286685286",
                            Endereco = "Caminhão do Amor Infante, 69",
                            Telefone = "14774267282",
                            Email = "turbante@amorinfante.com",
                            DtNascimento = DateTime.Parse("1969-06-09")
                        }
                    );
                }

                if(!context.Produto.Any())
                {
                    context.Produto.AddRange(
                        new Produto
                        {
                            Nome="Ração 10Kg",
                            Descricao="Ração da melhor qualidade para seu Pet.",
                            QuantidadeEstoque=13,
                            PrecoCompra=40.0f,
                            PrecoVenda=59.99f
                        },
                        new Produto
                        {
                            Nome="Ração 5kg",
                            Descricao="Ração da melhor qualidade para seu Pet.",
                            QuantidadeEstoque=5,
                            PrecoCompra=20.0f,
                            PrecoVenda=29.99f
                        },
                        new Produto
                        {
                            Nome="Ração 1Kg",
                            Descricao="Ração da melhor qualidade para seu Pet.",
                            QuantidadeEstoque=37,
                            PrecoCompra=10.0f,
                            PrecoVenda=13.99f
                        }
                    );
                }



                context.SaveChanges();
            }
        }
    }
}