using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TExecutions
    {
        public string Id { get; set; }
        public string ExId { get; set; }
        public string Name { get; set; }
        public string OperName { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string Number { get; set; }
        public string Court { get; set; }
        public string Type { get; set; }
        public string Province { get; set; }
        public string DocNumber { get; set; }
        public string Date { get; set; }
        public string CaseNumber { get; set; }
        public string ExDepartment { get; set; }
        public string FinalDuty { get; set; }
        public string ExecutionStatus { get; set; }
        public string ExecutionDesc { get; set; }
        public string PublishDate { get; set; }
        public string ConcernCount { get; set; }
        public int? OpsFlag { get; set; }
        public string Relatives { get; set; }
        public string IsRelated { get; set; }
        public string RelatedCompanies { get; set; }
        public string UTags { get; set; }
        public double? Amount { get; set; }
        public string Source { get; set; }
        public string Eid { get; set; }
        public long? CreateDate { get; set; }
        public long? ImportDate { get; set; }
        public long? LastUpdateTime { get; set; }
        public long? CreatedTime { get; set; }
        public DateTime? RowUpdateTime { get; set; }
        public string Pid { get; set; }
        public string PEid { get; set; }
        public string PEname { get; set; }
        public string Status { get; set; }
        public int CaseRelation { get; set; }
    }
}
