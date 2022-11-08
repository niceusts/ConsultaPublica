using Microsoft.EntityFrameworkCore;
using ConsultaPublica.Data;

namespace RazorPagesMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ConsultaPublicaContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ConsultaPublicaContext>>()))
            {
                if (context == null || context.Movie == null)
                {
                    throw new ArgumentNullException("Null RazorPagesMovieContext");
                }

                // Look for any movies.
                if (context.Movie.Any())
                {
                    return;   // DB has been seeded
                }

                context.Movie.AddRange(
                    new Movie
                    {
                        Genero = "When Harry Met Sally",
                        Residencia = "When Harry Met Sally",
                        InterferenciaCidade = "Romantic Comedy",
                        InterferenciaComunidade = "When Harry Met Sally",
                        PrioridadePoderPublico = "When Harry Met Sally",
                        Confianca = "When Harry Met Sally",
                        AcoesRelevancia = "When Harry Met Sally",
                        Descreva = "When Harry Met Sally"
                    },

                    new Movie
                    {
                        Genero = "When Harry Met Sally",
                        Residencia = "When Harry Met Sally",
                        InterferenciaCidade = "Romantic Comedy",
                        InterferenciaComunidade = "When Harry Met Sally",
                        PrioridadePoderPublico = "When Harry Met Sally",
                        Confianca = "When Harry Met Sally",
                        AcoesRelevancia = "When Harry Met Sally",
                        Descreva = "When Harry Met Sally"
                    },

                    new Movie
                    {
                        Genero = "When Harry Met Sally",
                        Residencia = "When Harry Met Sally",
                        InterferenciaCidade = "Romantic Comedy",
                        InterferenciaComunidade = "When Harry Met Sally",
                        PrioridadePoderPublico = "When Harry Met Sally",
                        Confianca = "When Harry Met Sally",
                        AcoesRelevancia = "When Harry Met Sally",
                        Descreva = "When Harry Met Sally"
                    },

                    new Movie
                    {
                        Genero = "When Harry Met Sally",
                        Residencia = "When Harry Met Sally",
                        InterferenciaCidade = "Romantic Comedy",
                        InterferenciaComunidade = "When Harry Met Sally",
                        PrioridadePoderPublico = "When Harry Met Sally",
                        Confianca = "When Harry Met Sally",
                        AcoesRelevancia = "When Harry Met Sally",
                        Descreva = "When Harry Met Sally"
                    },

                    new Movie
                    {
                        Genero = "When Harry Met Sally",
                        Residencia = "When Harry Met Sally",
                        InterferenciaCidade = "Romantic Comedy",
                        InterferenciaComunidade = "When Harry Met Sally",
                        PrioridadePoderPublico = "When Harry Met Sally",
                        Confianca = "When Harry Met Sally",
                        AcoesRelevancia = "When Harry Met Sally",
                        Descreva = "When Harry Met Sally"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}