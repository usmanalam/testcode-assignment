using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TelenorTest.Logic.Contracts;
using TelenorTest.Logic.Model;

namespace TelenorTest.ExternalApi.Controllers
{

	[Route("api/[controller]")]
	[ApiController]
	public class CellPhonesController : ControllerBase
	{
		private readonly IProductService _productService;

		public CellPhonesController(IProductService service)
		{
			this._productService = service;
		}

		// GET api/values
		[HttpGet]
		public IEnumerable<Product> Get()
		{
			return _productService.GetAll();
		}

		// GET api/values/5
		[HttpGet("{id}")]
		[ProducesResponseType(200)]
		[ProducesResponseType(404)]
		public ActionResult<Product> Get([FromRoute] int id)
		{
			if (!_productService.TryGetById(id, out var product))
			{
				return NotFound();
			}

			return product;
		}

		
	}
}
