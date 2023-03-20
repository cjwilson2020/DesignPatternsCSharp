using DesignPatternsCSharp;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace DesignPatterns
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Design Patterns, SOLID Principles.");

			/* Single Responsibility Principle
			 * 
			  * Any particular class should have a single reason to change and have methods with a Single responsiblity.
			 * EX. Journal can be a collection of strings
			 *	AddEntry, RemoveEntry, ToString, SaveJournal, LoadJournal
			 *	HOWEVER, Save and Load are a different responsibility than adding and removing from the journal. Now have to manage persistance
			 *	Should add a new class for Saving and Loading
			 *	
			 *	Make a new Persistance Class, where you can save all sorts of objects, not just Journals
			 */

			var j = new Journal();
			j.AddEntry("I worked out today.");
			j.AddEntry("I ate a bug");
			Console.WriteLine(j);

			var memoryCard = new Persistence();
			string filename = "text.txt";
			
			memoryCard.SaveToFile(j, filename, false);

			/*	Open-Close Principle
			 *	
			 *	Ordering System
			 *	different categories of products
			 *	
			 *	Classes should be Open for Extension but should be Closed for Modification
			 *	Utilize interfaces to extend
			 *	
			 *	Specification Pattern
			 */

			var apple = new Product("Apple", Constants.Color.Green, Constants.Size.Small);
			var tree = new Product("Tree", Constants.Color.Green, Constants.Size.Large);
			var house = new Product("House", Constants.Color.Blue, Constants.Size.Large);

			Product[] products = new Product[] {apple, tree, house};

			var pf = new ProductFilter();
			Console.WriteLine("Green products (old):");
			foreach (var p in pf.FilterByColor(products, Constants.Color.Green))
			{
				Console.WriteLine($" - {p.Name} is green");
			}

			// Better Filter using interfaces and specxification pattern
			var bf = new BetterFilter();
			Console.WriteLine("Green products (new): ");
			foreach (var p in bf.Filter(products, new ColorSpecification<Product>(Constants.Color.Green)))
			{
				Console.WriteLine($" - {p.Name} is green");
			}

			Console.WriteLine("Large Blue items: ");
			foreach (var p in bf.Filter(
				products,
				new AndSpecification<Product>(
					new ColorSpecification<Product>(Constants.Color.Blue),
					new SizeSpecification<Product>(Constants.Size.Large)
				)
				))
			{
				Console.WriteLine($" - {p.Name} is large and blue");
			}

		}
	}
}