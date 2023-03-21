using DesignPatternsCSharp;
using DesignPatternsCSharp.Builder;
using DesignPatternsCSharp.SOLID;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks.Dataflow;

namespace DesignPatterns
{
    public class Program
	{
		static void Main(string[] args)
		{
			//SolidProgram.Run(args);
			BuilderProgram.Run(args);

		}
	}
}