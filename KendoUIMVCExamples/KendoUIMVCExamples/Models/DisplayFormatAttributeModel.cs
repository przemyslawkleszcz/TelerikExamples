using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KendoUIMVCExamples.Models
{
    public class DisplayFormatAttributeModel
    {
        [DisplayFormat(DataFormatString = "{0:N3}", ApplyFormatInEditMode = true)]
        public decimal? Amount1 { get; set; }
        public decimal? Amount2 { get; set; }
    }
}