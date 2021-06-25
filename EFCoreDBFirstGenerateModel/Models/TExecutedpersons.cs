using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TExecutedpersons
    {
        public string Id { get; set; }
        public string Eid { get; set; }
        public string Name { get; set; }
        public string Ename { get; set; }
        public DateTime? CaseDate { get; set; }
        public string CaseNumber { get; set; }
        public string Type { get; set; }
        public string CaseId { get; set; }
        public string Number { get; set; }
        public long? Amount { get; set; }
        public string Court { get; set; }
        public string Status { get; set; }
        public string UTags { get; set; }
        public string UTagsUpdate { get; set; }
        public string Url { get; set; }
        public int? OpsFlag { get; set; }
        public long? CreatedTime { get; set; }
        public long? LastUpdateTime { get; set; }
        public DateTime? RowUpdateTime { get; set; }
        public string Pid { get; set; }
        public string PEid { get; set; }
        public string PEname { get; set; }
        public int CaseRelation { get; set; }
    }
}
