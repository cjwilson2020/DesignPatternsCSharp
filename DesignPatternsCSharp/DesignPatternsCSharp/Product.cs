using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp
{
	public class Product
	{
		public string Name { get; set; }
		public Constants.Color Color { get; set; }
		public Constants.Size Size { get; set; }

		public Product(string name, Constants.Color coolor, Constants.Size size) 
		{
			if (name == null)
			{
				throw new ArgumentNullException(paramName: nameof(name));
			}
			Name = name;
			Color = coolor;
			Size = size;
		}
	}
}
