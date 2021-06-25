using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TJudicialFreezes0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string BeExecutedPerson { get; set; }
        public string Amount { get; set; }
        public string ExecutiveCourt { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public string Type { get; set; }
        public string FreEid { get; set; }
        public string SourceEid { get; set; }
        public string LoseEfficacyReason { get; set; }
        public string LoseEfficacyDate { get; set; }
        public string Detail { get; set; }
        public string UnFreezeDetail { get; set; }
        public string PcFreezeDetail { get; set; }
        public string UnFreezeDetails { get; set; }
        public string ContinueFreezeDetails { get; set; }
        public int Tags { get; set; }
        public string LoseEfficacy { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
