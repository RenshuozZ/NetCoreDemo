using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TLicenseInfo0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string Number { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string Department { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public string Status { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
