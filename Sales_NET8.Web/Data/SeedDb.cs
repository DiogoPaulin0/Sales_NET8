using Sales_NET8.Web.Data.Entities;
using System;

namespace Sales_NET8.Web.Data
{
    public class SeedDb
    {
        private readonly DataContext _context;

        public SeedDb(DataContext context)
        {
            _context = context;
        }

        public async Task SeedAsync()
        {
            await _context.Database.EnsureCreatedAsync();

            if (!_context.Countries.Any())
            {
                AddCountry("Argentina");
                AddCountry("Colombia");
                AddCountry("Peru");
                AddCountry("Venezuela");
                AddCountry("Brasil");
                AddCountry("Chile");
                AddCountry("Uruguai");
                AddCountry("Paraguai");
                AddCountry("Equador");
                AddCountry("Bolívia");
                AddCountry("Guiana");
                AddCountry("Suriname");
                AddCountry("México");
                AddCountry("Panamá");
                AddCountry("Costa Rica");
                AddCountry("Guatemala");
                AddCountry("El Salvador");
                AddCountry("Honduras");
                AddCountry("Nicarágua");
                AddCountry("Cuba");
                AddCountry("Jamaica");
                AddCountry("Trinidad e Tobago");
                AddCountry("Haiti");
                AddCountry("República Dominicana");
                AddCountry("Belize");

                await _context.SaveChangesAsync();
            }

            if (!_context.Categories.Any())
            {
                AddCategory("Categoria 1");
                AddCategory("Categoria 2");
                AddCategory("Categoria 3");
                AddCategory("Categoria 4");
                AddCategory("Categoria 5");

                await _context.SaveChangesAsync();
            }
        }

        private void AddCountry(string name)
        {
            _context.Countries.Add(new Country
            {
                Name = name
            });
        }

        private void AddCategory(string name)
        {
            _context.Categories.Add(new Category
            {
                Name = name
            });
        }
    }
}
