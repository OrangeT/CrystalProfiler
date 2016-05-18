using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace CrystalProfiler
{
    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            if (Parser.Default.ParseArguments(args, options))
            {
                if (!options.InputFilenames.Any())
                {
                    Console.Error.WriteLine("Must provide at least one filename");
                    Environment.Exit(-1);
                }

                foreach (var file in options.InputFilenames)
                {
                }
            }
        }
    }
}
