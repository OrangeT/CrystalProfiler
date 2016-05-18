using System.Collections.Generic;
using CommandLine;

namespace CrystalProfiler
{
    class Options
    {
        [Option('h', "help", HelpText = "Show This Help Message")]
        public bool Help { get; set; }

        [Option('p', "params", HelpText = "List Parameters")]
        public bool ListParameters { get; set; }

        [Option('a', "all", HelpText = "Show All")]
        public bool All { get; set; }

        [ValueList(typeof(List<string>))]
        public IList<string> InputFilenames { get; set; }
    }
}