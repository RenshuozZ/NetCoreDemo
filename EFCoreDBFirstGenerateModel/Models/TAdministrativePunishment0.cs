using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TAdministrativePunishment0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string Number { get; set; }
        public string IllegalType { get; set; }
        public string Content { get; set; }
        public string Department { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string RegNo { get; set; }
        public string OperName { get; set; }
        public string Description { get; set; }
        public string BasedOn { get; set; }
        public string Remark { get; set; }
        public string PublicDate { get; set; }
        public int Tags { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
