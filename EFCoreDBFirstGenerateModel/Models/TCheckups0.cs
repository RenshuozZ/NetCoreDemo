using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TCheckups0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Province { get; set; }
        public string Department { get; set; }
        public string Type { get; set; }
        public string Date { get; set; }
        public string Result { get; set; }
        public long? LastUpdateTime { get; set; }
        public int UTags { get; set; }
        public string ObjId { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
