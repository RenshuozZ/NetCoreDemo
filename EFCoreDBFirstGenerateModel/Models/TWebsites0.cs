using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TWebsites0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string WebType { get; set; }
        public string WebName { get; set; }
        public string WebUrl { get; set; }
        public string Source { get; set; }
        public string Date { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
