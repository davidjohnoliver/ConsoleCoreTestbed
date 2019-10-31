using System;
using System.IO;

namespace ConsoleCoreTestbed
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			var path = System.IO.Directory.GetCurrentDirectory();
			var root = Path.GetPathRoot(path);
			;
		}
	}
}
