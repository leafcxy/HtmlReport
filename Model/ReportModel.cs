using System.Collections.Generic;
using System.Drawing;

namespace HtmlReport.Model
{
    public class ReportModel
    {

        public Dictionary<string, object> Parameters = new Dictionary<string, object>();
        public Dictionary<string, Font> Fonts = new Dictionary<string, Font>();
        public object DataSource { get; set; }
        public object DetailReport { get; set; }
        public object DetailReport2 { get; set; }


        public int PageHeight { get; set; }
    }
}
