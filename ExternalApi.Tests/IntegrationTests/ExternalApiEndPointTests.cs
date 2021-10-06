using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TelenorTest.Logic.Model;
using Xunit;

namespace ExternalApi.Tests.IntegrationTests
{
	public class ExternalApiEndPointTests
	{
		private const string URI = "http://localhost:5000/api/cellphones";

		[Fact]
		public async Task Get_ShouldReturnsAllCellPhones()
		{
			HttpClient httpClient = new HttpClient();
			HttpResponseMessage response = await httpClient.GetAsync(URI);

			Assert.True(response.IsSuccessStatusCode, await this.ExpandMessageAsync("Result is supposed to be a successful one.", response));

			var json = await response.Content.ReadAsStringAsync();

			List<Product> products = JsonConvert.DeserializeObject<List<Product>>(json);

			Assert.NotNull(products);
			Assert.Equal(4, products.Count);
		}

		[Fact]
		public async Task GetById_ExitingId_ShouldReturnsRightCellPhone()
		{
			int testId = 2;

			HttpClient httpClient = new HttpClient();
			HttpResponseMessage response = await httpClient.GetAsync($"{URI}/{testId}");

			Assert.True(response.IsSuccessStatusCode, await this.ExpandMessageAsync("Result is supposed to be a successful one.", response));

			var json = await response.Content.ReadAsStringAsync();
			var product = JsonConvert.DeserializeObject<Product>(json);

			Assert.IsType<Product>(product);
			Assert.Equal(testId, product.Id);
		}

		[Fact]
		public async Task GetById_UnknownId_ShouldReturnsNotFound()
		{
			int testId = 0;

			HttpClient httpClient = new HttpClient();
			HttpResponseMessage response = await httpClient.GetAsync($"{URI}/{testId}");

			Assert.False(response.IsSuccessStatusCode, await this.ExpandMessageAsync("Result is supposed to be a false.", response));
			Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
		}

		private async Task<string> ExpandMessageAsync(string message, HttpResponseMessage response)
		{
			return message + $". Status: {response.StatusCode}, additional info: {await response.Content.ReadAsStringAsync()}";
		}
	}
}
