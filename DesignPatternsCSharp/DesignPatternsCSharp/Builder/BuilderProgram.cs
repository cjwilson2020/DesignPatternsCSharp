using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;
using static System.Console;

namespace DesignPatternsCSharp.Builder
{
	public class BuilderProgram
	{
		public static void Run(string[] args)
		{
			Console.WriteLine("Builder Design Principal");

			WriteLine("=======");
			WriteLine("Life without Builders");
			WriteLine("- - - -");

			WriteLine("Suppose we want to turn the string, \"hello\", into an html paragraph string");
			
			var hello = "hello";
			
			WriteLine("We can utilize a built in string builder to \"Append\" each tag, then the text.\n");
			var sb = new StringBuilder();
			sb.Append("<p>");
			sb.Append(hello);
			sb.Append("</p>");
			WriteLine(sb);


			WriteLine("\nLet's say we want to show Hello world as an unordered list. Things get more tedious quickly.\n");
			var words = new[] { "hello", "world" };
			sb.Clear();
			sb.Append("<ul>");
			foreach(var word in words)
			{
				sb.AppendFormat("<li>{0}</li>", word);
			}
			sb.Append("/<ul>");
			WriteLine(sb);

			WriteLine($"\nNow, using an HTML Builder, we are able to make the same html string, but\n" +
				$"prettier and object oriented into a tree using recursion.\n");	
			// construct an HTML Builder


			var builer = new HTMLBuilder("ul");
			builer.AddChild("li", "hello");
			builer.AddChild("li", "world");
			WriteLine(builer);
		}
	}
}
