using System.Collections.Generic;
using TelenorTest.Logic.Model;

namespace TelenorTest.Logic.Infrastructure
{
	public static class MockSeeder
	{
		public static Dictionary<int, Product> Products = new Dictionary<int, Product>();
		public static Dictionary<string, ProductSpecs> Specs = new Dictionary<string, ProductSpecs>();
		public static Dictionary<string, ProductCampaign> Campaigns = new Dictionary<string, ProductCampaign>();

		//This is a static constructor, it will be run the first time this class is accessed
		static MockSeeder()
		{
			Campaigns.Add("IPhone 8", GetIphoneCampaign());
			Campaigns.Add("Galaxy Note 9", GetGalaxyNote9Campaign());
			Campaigns.Add("Huawei P20", GetHuaweiP20Campaign());
			Campaigns.Add("Sony Xperia", GetSonyXperiaCampaign());

			Products.Add(1, GetIphone(1));
			Products.Add(2, GetGalaxyNote9(2));
			Products.Add(3, GetHuaweiP20(3));
			Products.Add(4, GetSonyXperia(4));

			Specs.Add("IPhone 8", GetIphoneSpecs());
			Specs.Add("Galaxy Note 9", GetGalaxyNote9Specs());
			Specs.Add("Huawei P20", GetHuaweiP20Specs());
			Specs.Add("Sony Xperia", GetSonyXperiaSpecs());

		}

		private static Product GetIphone(int id)
		{
			Product product = new Product();

			product.Id = id;
			product.Name = "IPhone 8";
			product.Category = "CellPhone";
			product.Price = 399M;
			product.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
			return product;
		}

		private static Product GetGalaxyNote9(int id)
		{
			Product product = new Product();

			product.Id = id;
			product.Name = "Galaxy Note 9";
			product.Category = "CellPhone";
			product.Price = 599M;
			product.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
			return product;
		}

		private static Product GetHuaweiP20(int id)
		{
			Product product = new Product();

			product.Id = id;
			product.Name = "Huawei P20";
			product.Category = "CellPhone";
			product.Price = 499M;
			product.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
			return product;
		}

		private static Product GetSonyXperia(int id)
		{
			Product product = new Product();

			product.Id = id;
			product.Name = "Sony Xperia";
			product.Category = "CellPhone";
			product.Price = 299M;
			product.Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.";
			return product;
		}

		private static ProductSpecs GetIphoneSpecs()
		{
			return new ProductSpecs
			{
				Size = "5.45 x 2.65 x 0.29 inches (138.4 x 67.3 x 7.3 mm)",
				Weight = "5.22 ounces (148 grams)",
				Connectivity = "4G LTE, GSM, CDMA, HSPA+, 802.11ac/b/g/n/ac Wi-Fi",
				OS = "iOS 11",
				Processor = "A11 Bionic chip with 64-bit architecture, M11 motion coprocessor",
				RAM = "2GB",
				Resolution = "1,334 × 750 pixels",
				Screen = "4.7-inch Retina HD IPS LCD",
				Storage = "64/256GB"
			};
		}

		private static ProductSpecs GetGalaxyNote9Specs()
		{
			return new ProductSpecs
			{
				Size = "6.4-inch",
				Weight = "5.22 ounces (148 grams)",
				Connectivity = "4G LTE, GSM, CDMA, HSPA+, 802.11ac/b/g/n/ac Wi-Fi",
				OS = "Android 8.1 Oreo",
				Processor = "Qualcomm Snapdragon 845",
				RAM = "6/8GB",
				Resolution = "1,334 × 750 pixels",
				Screen = "6.4-inch Super AMOLED, 2960x1440 (18.5:9)",
				Storage = "64/256GB"
			};
		}

		private static ProductSpecs GetHuaweiP20Specs()
		{
			return new ProductSpecs
			{
				Size = "6.4-inch",
				Weight = "165g",
				Connectivity = "4G LTE, GSM, CDMA, HSPA+, 802.11ac/b/g/n/ac Wi-Fi",
				OS = "Android 8.1",
				Processor = "Kirin 970",
				RAM = "6/8GB",
				Resolution = "1,334 × 750 pixels",
				Screen = "6.4-inch Super AMOLED",
				Storage = "64/256GB"
			};
		}

		private static ProductSpecs GetSonyXperiaSpecs()
		{
			return new ProductSpecs
			{
				Size = "6.4-inch",
				Weight = "165g",
				Connectivity = "4G LTE, GSM, CDMA, HSPA+, 802.11ac/b/g/n/ac Wi-Fi",
				OS = "Android 8.1",
				Processor = "Kirin 970",
				RAM = "6/8GB",
				Resolution = "1,334 × 750 pixels",
				Screen = "6.4-inch Super AMOLED",
				Storage = "64/256GB"
			};
		}

		private static ProductCampaign GetIphoneCampaign()
		{
			return new ProductCampaign
			{
				DomesticCalls = "Free calls",
				DomesticSMS = "Free SMS",
				DomesticDataSurf = "30 GB Data in Sweden",
				RoamingDataSurf = "15 GB Data in EU"
			};
		}

		private static ProductCampaign GetGalaxyNote9Campaign()
		{
			return new ProductCampaign
			{
				DomesticCalls = "Free calls",
				DomesticSMS = "Free SMS",
				DomesticDataSurf = "50 GB Data in Sweden",
				RoamingDataSurf = "15 GB Data in EU"
			};
		}

		private static ProductCampaign GetHuaweiP20Campaign()
		{
			return new ProductCampaign
			{
				DomesticCalls = "Free calls",
				DomesticSMS = "Free SMS",
				DomesticDataSurf = "Unlimited GB Data in Sweden",
				RoamingDataSurf = "10 GB Data in EU"
			};
		}

		private static ProductCampaign GetSonyXperiaCampaign()
		{
			return new ProductCampaign
			{
				DomesticCalls = "Free calls",
				DomesticSMS = "Free SMS",
				DomesticDataSurf = "20 GB Data in Sweden",
				RoamingDataSurf = "5 GB Data in EU"
			};
		}
	}
}
