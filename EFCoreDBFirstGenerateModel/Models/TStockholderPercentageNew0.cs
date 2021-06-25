using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TStockholderPercentageNew0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string SpSource { get; set; }
        public long? SpDate { get; set; }
        public string Percentage { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
