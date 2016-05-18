using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace CrystalProfiler
{
    public class CrystalProfile
    {
        private string _filename;
        private ReportDocument _doc;

        public CrystalProfile(string filename)
        {
            _filename = filename;

            _doc = new ReportDocument();
            _doc.Load(filename);
        }

        public IEnumerable<CrystalProfileParameter> Parameters
        {
            get
            {
                return _doc.ParameterFields
                    .Cast<ParameterField>()
                    .Select(field => new CrystalProfileParameter(field));
            }
        }
    }
}