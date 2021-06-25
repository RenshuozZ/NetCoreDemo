using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TNotices
    {
        public string Id { get; set; }
        public string ExId { get; set; }
        public string Type { get; set; }
        public string People { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
        public string Court { get; set; }
        public string Url { get; set; }
        public int? OpsFlag { get; set; }
        public string RelatedCompanies { get; set; }
        public string UTags { get; set; }
        public string Pdf { get; set; }
        public string CaseReason { get; set; }
        public string RelationDetails { get; set; }
        public long? CreatedTime { get; set; }
        public long? LastUpdatedTime { get; set; }
        public string RelatedCheck { get; set; }
        public string Md5 { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
