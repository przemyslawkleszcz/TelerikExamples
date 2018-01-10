using System.Collections.Generic;

namespace KendoUIMVCExamples.Models
{
    public class BaseModel
    {
        public IEnumerable<BaseData> Data { get; set; }
    }

    public class BaseData
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}