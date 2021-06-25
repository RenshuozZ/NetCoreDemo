using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TCases
    {
        public string Id { get; set; }
        public string Md5 { get; set; }
        public string IsRelated { get; set; }
        public string Court { get; set; }
        public string EndDate { get; set; }
        public string Url { get; set; }
        public string Assistant { get; set; }
        public string Region { get; set; }
        public string CaseNo { get; set; }
        public string Agent { get; set; }
        public string HearingDate { get; set; }
        public string RelatedCompanies { get; set; }
        public int? OpsFlag { get; set; }
        public string CaseStatus { get; set; }
        public string StartDate { get; set; }
        public long? CreatedTime { get; set; }
        public long? LastUpdatedTime { get; set; }
        public string UTags { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
