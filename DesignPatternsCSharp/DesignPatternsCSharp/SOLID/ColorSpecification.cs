using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.SOLID
{
    public class ColorSpecification<T> : ISpecification<Product>
    {
        private Constants.Color color;

        public ColorSpecification(Constants.Color color)
        {
            this.color = color;
        }

        public bool IsSatisfied(Product t)
        {
            if (t.Color == color)
                return true;
            return false;
        }
    }
}
