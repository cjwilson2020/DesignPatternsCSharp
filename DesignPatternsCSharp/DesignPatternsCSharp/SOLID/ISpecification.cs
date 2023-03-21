using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.SOLID
{
    public interface ISpecification<T>
    {
        // allows users to implement whether an object T satisfies some type of criteria 
        bool IsSatisfied(T t);
    }
}
