using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.SOLID
{
    public class SizeSpecification<T> : ISpecification<Product>
    {
        private Constants.Size size;
        public SizeSpecification(Constants.Size size)
        {
            this.size = size;

        }

        public bool IsSatisfied(Product t)
        {
            return t.Size == size;
        }
    }
}
