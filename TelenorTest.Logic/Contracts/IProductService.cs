using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TelenorTest.Logic.Model;

namespace TelenorTest.Logic.Contracts
{
	public interface IProductService
	{
		IEnumerable<Product> GetAll();
		bool TryGetById(int id, out Product product);
	}
}
