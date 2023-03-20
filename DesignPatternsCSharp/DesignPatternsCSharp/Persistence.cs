using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsCSharp
{
	public class Persistence
	{
		public void SaveToFile(Journal j, string filename, bool overwrite = false)
		{
			if (overwrite || !File.Exists(filename))
			{
				File.WriteAllText(filename, j.ToString());
			}
		}
	}
}
