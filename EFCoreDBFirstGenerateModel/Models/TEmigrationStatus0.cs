using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TEmigrationStatus0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public string MoveType { get; set; }
        public string MoveEid { get; set; }
        public string MoveName { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
