using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TEquityquality0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string Number { get; set; }
        public string Pledgor { get; set; }
        public string PledgorIdentifyType { get; set; }
        public string PledgorIdentifyNo { get; set; }
        public string PledgorAmount { get; set; }
        public string PledgorUnit { get; set; }
        public string PledgorCurrency { get; set; }
        public string Pawnee { get; set; }
        public string PawneeIdentifyType { get; set; }
        public string PawneeIdentifyNo { get; set; }
        public string Date { get; set; }
        public string Status { get; set; }
        public string Remark { get; set; }
        public string PublicDate { get; set; }
        public string ChangeItems { get; set; }
        public int Tags { get; set; }
        public string PawneeEid { get; set; }
        public string ObjectCompany { get; set; }
        public string PledgorEid { get; set; }
        public string ObjectCompanyEid { get; set; }
        public DateTime? RowUpdateTime { get; set; }
        public string CancelItems { get; set; }
    }
}
