using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TChangeRecords0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string AfterContent { get; set; }
        public string BeforeContent { get; set; }
        public string ChangeDate { get; set; }
        public string ChangeItem { get; set; }
        public string Type { get; set; }
        public DateTime? RowUpdateTime { get; set; }
        public string Source { get; set; }
    }
}
