using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp.Builder
{
	internal class HTMLElement
	{
		public string Name, Text;
		public List<HTMLElement> Elements = new	List<HTMLElement>();
        private const int indentSize = 2;

        public HTMLElement(string name, string text)
        {
            Name = name ?? throw new ArgumentNullException(paramName: nameof(name));
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }

		public HTMLElement()
		{
		}

		private string ToStringImpl(int indent) 
        {
            var sb = new StringBuilder();
            var i = new string(' ', indentSize * indent);
            sb.AppendLine($"{i}<{Name}>");

            if (!string.IsNullOrWhiteSpace(Text))
            {
                sb.Append(new string(' ', indentSize * indent));
                sb.AppendLine(Text);
            }

            foreach (var element in Elements)
            {
                sb.Append(element.ToStringImpl(indent + 1));
            }

			sb.AppendLine($"{i}</{Name}>");

            return sb.ToString();
		}

		public override string ToString()
		{
			return ToStringImpl(0);
		}
	}
}
