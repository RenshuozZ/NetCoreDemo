using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TMortgages0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string ExId { get; set; }
        public string Number { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }
        public string Amount { get; set; }
        public string Period { get; set; }
        public string Scope { get; set; }
        public string Remarks { get; set; }
        public string DebitType { get; set; }
        public string DebitCurrency { get; set; }
        public string DebitAmount { get; set; }
        public string DebitScope { get; set; }
        public string DebitPeriod { get; set; }
        public string DebitRemarks { get; set; }
        public string CloseDate { get; set; }
        public string CloseReason { get; set; }
        public string PublicDate { get; set; }
        public int Tags { get; set; }
        public string Mortgagees { get; set; }
        public string Guarantees { get; set; }
        public string ChangeInfo { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
