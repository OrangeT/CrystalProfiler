using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using CrystalDecisions.CrystalReports.Engine;

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
                    try
                    {
                        var profile = new CrystalProfile(file);

                        Utility.WriteHeading("Filename: " + Path.GetFileName(file));

                        if (options.All || options.ListParameters)
                        {
                            Utility.WriteSubHeading("Parameters");
                            profile.Parameters.ToList().ForEach(Console.WriteLine);
                        }

                        if (options.All || options.ConnectionStrings)
                        {
                            Utility.WriteSubHeading("Connection Strings");
                            profile.ConnectionStrings.ToList().ForEach(Console.WriteLine);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Error while attempting to process file: {0}, exception: {1}",
                            file, 
                            ex.Message);
                    }

                    Console.WriteLine();
                }
            }
        }
    }
}
