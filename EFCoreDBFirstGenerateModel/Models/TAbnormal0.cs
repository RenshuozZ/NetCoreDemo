using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TAbnormal0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string Province { get; set; }
        public string InReason { get; set; }
        public string InDate { get; set; }
        public string OutReason { get; set; }
        public string OutDate { get; set; }
        public string Department { get; set; }
        public long? LastUpdateTime { get; set; }
        public int? OpsFlag { get; set; }
        public int UTags { get; set; }
        public string ObjId { get; set; }
        public DateTime? RowUpdateTime { get; set; }
        public string OutDepartment { get; set; }
    }
}
