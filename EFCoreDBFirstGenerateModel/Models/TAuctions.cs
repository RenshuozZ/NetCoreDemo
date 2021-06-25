using System;
using System.Collections.Generic;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class TAuctions
    {
        public string Id { get; set; }
        public string Md5 { get; set; }
        public string Restrict { get; set; }
        public string Result { get; set; }
        public string FullName { get; set; }
        public string Owner { get; set; }
        public string Category { get; set; }
        public string StartPrice { get; set; }
        public string Court { get; set; }
        public string Certificate { get; set; }
        public string Area { get; set; }
        public string RelatedCompanies { get; set; }
        public int? OpsFlag { get; set; }
        public string Document { get; set; }
        public string Description { get; set; }
        public string EstPrice { get; set; }
        public string Flag { get; set; }
        public string Date { get; set; }
        public string PubDate { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Basis { get; set; }
        public string IsRelated { get; set; }
        public string Relatives { get; set; }
        public long? CreateTime { get; set; }
        public long? LastUpdateTime { get; set; }
        public long? CreatedTime { get; set; }
        public long? LastUpdatedTime { get; set; }
        public string UTags { get; set; }
        public string TransactionDate { get; set; }
        public string TransactionPrice { get; set; }
        public DateTime? RowUpdateTime { get; set; }
    }
}
