using CrystalDecisions.CrystalReports.Engine;

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
    }
}