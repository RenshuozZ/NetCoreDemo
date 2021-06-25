using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TDoubleCheckups0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string RaninsPlanId { get; set; }
        public string RaninsPlaneName { get; set; }
        public string RaninsTaskId { get; set; }
        public string RaninsTaskName { get; set; }
        public string RaninsTypeName { get; set; }
        public string InsAuth { get; set; }
        public string InsDate { get; set; }
        public string Details { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
