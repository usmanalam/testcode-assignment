using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TelenorTest.ExternalApi.Controllers;
using TelenorTest.Logic.Contracts;
using TelenorTest.Logic.Model;
using TelenorTest.Logic.Service;
using Xunit;

namespace ExternalApi.Tests.Services
{
	public class CellPhonesControllerTests
	{
		private CellPhonesController _controller;
		private IProductService _productService;

		public CellPhonesControllerTests()
		{
			_productService = new ProductService();
			_controller = new CellPhonesController(_productService);
		}

		[Fact]
		public void Get_ShouldReturnsAllCellPhones()
		{
			var products = _controller.Get();
			Assert.Equal(4, products.Count());
		}

		[Fact]
		public void GetById_UnknownId_ShouldReturnsNotFound()
		{
			var notFoundResult = _controller.Get(0);
			Assert.IsType<NotFoundResult>(notFoundResult.Result);
		}

		[Fact]
		public void GetById_ExitingId_ShouldReturnsRightCellPhone()
		{
			int testId = 2;

			var product = _controller.Get(testId);

			Assert.IsType<Product>(product.Value);
			Assert.Equal(testId, (product.Value).Id);
		}
	}
}
