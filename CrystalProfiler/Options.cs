using System.Collections.Generic;
using CommandLine;

namespace CrystalProfiler
{
    class Options
    {
        [Option('p', "params")]
        public bool ListParameters { get; set; }

        [Option('a', "all")]
        public bool All { get; set; }

        [ValueList(typeof(List<string>))]
        public IList<string> InputFilenames { get; set; }
    }
}