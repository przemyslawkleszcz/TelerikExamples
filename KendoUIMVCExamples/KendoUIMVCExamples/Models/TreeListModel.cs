using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoUIMVCExamples.Models
{
    public class TreeListModel
    {
        public IEnumerable<TreeListData> TreeListData { get; set; }
    }

    public class TreeListData
    {
        public int Id { get; set; }
        public int? ReportsTo { get; set; }
        public string Name { get; set; }
    }
}