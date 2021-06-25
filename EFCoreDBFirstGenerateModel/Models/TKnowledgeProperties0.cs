using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TKnowledgeProperties0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Pledgor { get; set; }
        public string Pawnee { get; set; }
        public string Period { get; set; }
        public string Status { get; set; }
        public string PublicDate { get; set; }
        public DateTime? RowUpdateTime { get; set; }
        public string PledgorEid { get; set; }
        public int? PledgorType { get; set; }
        public string PawneeEid { get; set; }
        public int? PawneeType { get; set; }
    }
}
