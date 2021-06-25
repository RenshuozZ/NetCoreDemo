using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TPartners0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string Category { get; set; }
        public string StockName { get; set; }
        public string StockId { get; set; }
        public string StockType { get; set; }
        public string StockPercent { get; set; }
        public string IdentifyType { get; set; }
        public string IdentifyNo { get; set; }
        public string TotalRealCapi { get; set; }
        public string TotalShouldCapi { get; set; }
        public string ShouldCapiItems { get; set; }
        public string RealCapiItems { get; set; }
        public string Tag { get; set; }
        public string ExId { get; set; }
        public string EntityType { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
