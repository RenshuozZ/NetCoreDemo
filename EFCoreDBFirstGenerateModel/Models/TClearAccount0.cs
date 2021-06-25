using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TClearAccount0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string Leader { get; set; }
        public string Employees { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
