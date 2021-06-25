using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TAddress0
    {
        public long Id { get; set; }
        public string Eid { get; set; }
        public int SeqNo { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public string Postcode { get; set; }
        public string Date { get; set; }
        public string Source { get; set; }
        public string UpdateDate { get; set; }
        public DateTime? RowUpdateTime { get; set; }
        public string AddressCode { get; set; }
    }
}
