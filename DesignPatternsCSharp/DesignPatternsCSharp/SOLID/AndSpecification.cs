using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.SOLID
{
    // A Combinator
    public class AndSpecification<T> : ISpecification<T>
    {
        ISpecification<T> first, second;
        public AndSpecification(ISpecification<T> first, ISpecification<T> second)
        {
            if (first == null)
            {
                throw new ArgumentNullException(paramName: nameof(first));
            }
            if (second == null)
            {
                throw new ArgumentNullException(paramName: nameof(second));
            }
            this.first = first;
            this.second = second;
        }
        public bool IsSatisfied(T t)
        {
            return first.IsSatisfied(t) && second.IsSatisfied(t);
        }
    }
}
