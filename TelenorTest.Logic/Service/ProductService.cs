using System.Collections.Generic;
using System.Linq;
using TelenorTest.Logic.Contracts;
using TelenorTest.Logic.Infrastructure;
using TelenorTest.Logic.Model;

namespace TelenorTest.Logic.Service
{
	public class ProductService : IProductService
	{
		public IEnumerable<Product> GetAll()
		{
			var products = MockSeeder.Products.Values?.ToList();

			return products.Select(p => new Product {
				Id = p.Id,
				Description = p.Description,
				Name = p.Name,
				Price = p.Price,
				Campaign = MockSeeder.Campaigns.SingleOrDefault(c => c.Key == p.Name).Value,
			});
		}

		public bool TryGetById(int id, out Product product)
		{
			var products = MockSeeder.Products.Values?.ToList();

			product = products.Where(x => x.Id == id)
						.Select(p => new Product
						{
							Id = p.Id,
							Description = p.Description,
							Name = p.Name,
							Price = p.Price,
							Specs = MockSeeder.Specs
								.Where(s => s.Key == p.Name)
								.Select(s => 
								 new ProductSpecs {
									Connectivity = s.Value.Connectivity,
									OS = s.Value.OS,
									Processor = s.Value.Processor,
									RAM = s.Value.RAM,
									Resolution = s.Value.Resolution,
									Screen = s.Value.Screen,
									Size = s.Value.Size,
									Storage = s.Value.Storage,
									Weight = s.Value.Weight
								}).ToList(),
						}).SingleOrDefault();

			return product == null ? false : true;
		}

	}

}
