using System.Collections.Generic;


namespace TelenorTest.Logic.Model
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public decimal Price { get; set; }
		public string Description { get; set; }
		public string Category { get; set; }
		public List<ProductSpecs> Specs { get; set; }
		public ProductCampaign Campaign { get; set; }
	}
}
