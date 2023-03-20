using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp
{
	// This class violates the Open Close Principle
	public class ProductFilter
	{
		public  IEnumerable<Product> FilterBySize(IEnumerable<Product> products,
			Constants.Size size)
		{
			foreach (Product product in products) 
			{
				if (product.Size == size)
				{
					yield return product;
				}
			}
		}

		public  IEnumerable<Product> FilterByColor(IEnumerable<Product> products,
			Constants.Color color)
		{
			foreach (Product product in products)
			{
				if (product.Color == color)
				{
					yield return product;
				}
			}
		}

		public  IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products,
			Constants.Size size, Constants.Color color)
		{
			foreach (Product product in products)
			{
				if (product.Size == size && product.Color == color)
				{
					yield return product;
				}
			}
		}
	}
}
