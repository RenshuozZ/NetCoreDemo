using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TLastIndustry0
    {
        public long Id { get; set; }
        public string Md5 { get; set; }
        public string Eid { get; set; }
        public string IndustryCode { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public sbyte IsValid { get; set; }
        public sbyte Source { get; set; }
        public long? CreateTime { get; set; }
        public long? UpdateTime { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
