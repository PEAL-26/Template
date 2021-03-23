using Template.Domain.Entidades;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Template.Infra.Data.Seeds
{

    public static class ExemploSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            var exemplo = new List<Exemplo>
            {
                new Exemplo (1),
                new Exemplo (2)
            };

            modelBuilder.Entity<Exemplo>().HasData(exemplo);

        }
    }
}
