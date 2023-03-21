using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.Builder
{
	public class HTMLBuilder
	{
        private readonly string rootName;
		HTMLElement root = new HTMLElement();

        public HTMLBuilder(string rootName)
        {
            this.rootName = rootName;  
            root.Name = rootName;
        }


        public void AddChild(string childName, string childText)
        {
            var e = new HTMLElement(childName, childText);
            root.Elements.Add(e);
        }

        public override string ToString()
        {
            return root.ToString();
        }

        public void Clear()
        {
            root = new HTMLElement { Name = rootName };
        }
    }
}
