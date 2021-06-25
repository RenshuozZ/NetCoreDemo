using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace EFCoreDBFirstGenerateModel.Models
{
    public partial class data_serviceContext : DbContext
    {
        public data_serviceContext()
        {
        }

        public data_serviceContext(DbContextOptions<data_serviceContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TAbnormal0> TAbnormal0 { get; set; }
        public virtual DbSet<TAddress0> TAddress0 { get; set; }
        public virtual DbSet<TAdministrativePunishment0> TAdministrativePunishment0 { get; set; }
        public virtual DbSet<TAuctions> TAuctions { get; set; }
        public virtual DbSet<TAuctionsRelations0> TAuctionsRelations0 { get; set; }
        public virtual DbSet<TBranches0> TBranches0 { get; set; }
        public virtual DbSet<TCases> TCases { get; set; }
        public virtual DbSet<TCasesRelations0> TCasesRelations0 { get; set; }
        public virtual DbSet<TChangeRecords0> TChangeRecords0 { get; set; }
        public virtual DbSet<TCheckups0> TCheckups0 { get; set; }
        public virtual DbSet<TClearAccount0> TClearAccount0 { get; set; }
        public virtual DbSet<TDoubleCheckups0> TDoubleCheckups0 { get; set; }
        public virtual DbSet<TEmails0> TEmails0 { get; set; }
        public virtual DbSet<TEmigrationStatus0> TEmigrationStatus0 { get; set; }
        public virtual DbSet<TEmployees0> TEmployees0 { get; set; }
        public virtual DbSet<TEnterprise0> TEnterprise0 { get; set; }
        public virtual DbSet<TEquityquality0> TEquityquality0 { get; set; }
        public virtual DbSet<TExecutedpersons> TExecutedpersons { get; set; }
        public virtual DbSet<TExecutions> TExecutions { get; set; }
        public virtual DbSet<TJudicialFreezes0> TJudicialFreezes0 { get; set; }
        public virtual DbSet<TKaitinggonggaos0> TKaitinggonggaos0 { get; set; }
        public virtual DbSet<TKaitinggonggaosRelations0> TKaitinggonggaosRelations0 { get; set; }
        public virtual DbSet<TKnowledgeProperties0> TKnowledgeProperties0 { get; set; }
        public virtual DbSet<TLastIndustry0> TLastIndustry0 { get; set; }
        public virtual DbSet<TLawsuitsRelations0> TLawsuitsRelations0 { get; set; }
        public virtual DbSet<TLicenseInfo0> TLicenseInfo0 { get; set; }
        public virtual DbSet<TMortgages0> TMortgages0 { get; set; }
        public virtual DbSet<TNotices> TNotices { get; set; }
        public virtual DbSet<TNoticesRelations0> TNoticesRelations0 { get; set; }
        public virtual DbSet<TOtherInfomation0> TOtherInfomation0 { get; set; }
        public virtual DbSet<TPartners0> TPartners0 { get; set; }
        public virtual DbSet<TReportDetail20170> TReportDetail20170 { get; set; }
        public virtual DbSet<TReportDetailOther0> TReportDetailOther0 { get; set; }
        public virtual DbSet<TReports0> TReports0 { get; set; }
        public virtual DbSet<TSeriousIllegal0> TSeriousIllegal0 { get; set; }
        public virtual DbSet<TSimpleCancellationAnnouncement0> TSimpleCancellationAnnouncement0 { get; set; }
        public virtual DbSet<TStockholderPercentageNew0> TStockholderPercentageNew0 { get; set; }
        public virtual DbSet<TTelephones0> TTelephones0 { get; set; }
        public virtual DbSet<TWebsites0> TWebsites0 { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseMySql("Server=localhost;User Id=root;Password=qq123456;Database=data_service");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAbnormal0>(entity =>
            {
                entity.ToTable("t_abnormal_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_abnormal");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.InDate)
                    .HasColumnName("in_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InReason)
                    .HasColumnName("in_reason")
                    .HasColumnType("text");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("last_update_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ObjId)
                    .HasColumnName("obj_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OpsFlag)
                    .HasColumnName("ops_flag")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OutDate)
                    .HasColumnName("out_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OutDepartment)
                    .HasColumnName("out_department")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OutReason)
                    .HasColumnName("out_reason")
                    .HasColumnType("text");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegNo)
                    .HasColumnName("reg_no")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TAddress0>(entity =>
            {
                entity.ToTable("t_address_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_address");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.AddressCode)
                    .HasColumnName("address_code")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Postcode)
                    .HasColumnName("postcode")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TAdministrativePunishment0>(entity =>
            {
                entity.ToTable("t_administrative_punishment_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_administrative_punishment");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.BasedOn)
                    .HasColumnName("based_on")
                    .HasColumnType("text");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.IllegalType)
                    .IsRequired()
                    .HasColumnName("illegal_type")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OperName)
                    .HasColumnName("oper_name")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PublicDate)
                    .HasColumnName("public_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegNo)
                    .HasColumnName("reg_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("text");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TAuctions>(entity =>
            {
                entity.ToTable("t_auctions");

                entity.HasIndex(e => e.LastUpdatedTime)
                    .HasName("key_last_updated_time");

                entity.HasIndex(e => e.Md5)
                    .HasName("md5_index");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Area)
                    .HasColumnName("area")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Basis)
                    .HasColumnName("basis")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Certificate)
                    .HasColumnName("certificate")
                    .HasColumnType("text");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Document)
                    .HasColumnName("document")
                    .HasColumnType("text");

                entity.Property(e => e.EstPrice)
                    .HasColumnName("est_price")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Flag)
                    .HasColumnName("flag")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsRelated)
                    .HasColumnName("is_related")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("last_update_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.LastUpdatedTime)
                    .HasColumnName("last_updated_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Md5)
                    .HasColumnName("md5")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OpsFlag)
                    .HasColumnName("ops_flag")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'8'");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PubDate)
                    .HasColumnName("pub_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelatedCompanies)
                    .HasColumnName("related_companies")
                    .HasColumnType("text");

                entity.Property(e => e.Relatives)
                    .HasColumnName("relatives")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Restrict)
                    .HasColumnName("_restrict")
                    .HasColumnType("text");

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.StartPrice)
                    .HasColumnName("start_price")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("transaction_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TransactionPrice)
                    .HasColumnName("transaction_price")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TAuctionsRelations0>(entity =>
            {
                entity.ToTable("t_auctions_relations_0");

                entity.HasIndex(e => e.LastUpdatedTime)
                    .HasName("key_last_updated_time");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.HasIndex(e => new { e.Eid, e.ObjId })
                    .HasName("eid_obj_id_index")
                    .IsUnique();

                entity.HasIndex(e => new { e.Eid, e.OrderDate })
                    .HasName("eid_order_date_index");

                entity.HasIndex(e => new { e.Eid, e.Role })
                    .HasName("eid_role_index");

                entity.HasIndex(e => new { e.Eid, e.Type })
                    .HasName("eid_type_index");

                entity.HasIndex(e => new { e.Eid, e.UTags, e.Type })
                    .HasName("eid_u_tags_type_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Basis)
                    .HasColumnName("basis")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Certificate)
                    .HasColumnName("certificate")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("text");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.Document)
                    .HasColumnName("document")
                    .HasColumnType("text");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EstPrice)
                    .HasColumnName("est_price")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastUpdatedTime)
                    .HasColumnName("last_updated_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.ObjId)
                    .IsRequired()
                    .HasColumnName("obj_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("date");

                entity.Property(e => e.Owner)
                    .HasColumnName("owner")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelatedCompanies)
                    .HasColumnName("related_companies")
                    .HasColumnType("text");

                entity.Property(e => e.Restrict)
                    .HasColumnName("_restrict")
                    .HasColumnType("text");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.StartPrice)
                    .HasColumnName("start_price")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TransactionDate)
                    .HasColumnName("transaction_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TransactionPrice)
                    .HasColumnName("transaction_price")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TBranches0>(entity =>
            {
                entity.ToTable("t_branches_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_branches");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.BelongOrg)
                    .HasColumnName("belong_org")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OperName)
                    .HasColumnName("oper_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegNo)
                    .IsRequired()
                    .HasColumnName("reg_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SubEid)
                    .HasColumnName("sub_eid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TCases>(entity =>
            {
                entity.ToTable("t_cases");

                entity.HasIndex(e => e.LastUpdatedTime)
                    .HasName("key_last_updated_time");

                entity.HasIndex(e => e.Md5)
                    .HasName("md5_index");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Assistant)
                    .HasColumnName("assistant")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseNo)
                    .HasColumnName("case_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseStatus)
                    .HasColumnName("case_status")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HearingDate)
                    .HasColumnName("hearing_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IsRelated)
                    .HasColumnName("is_related")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastUpdatedTime)
                    .HasColumnName("last_updated_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Md5)
                    .HasColumnName("md5")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OpsFlag)
                    .HasColumnName("ops_flag")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'8'");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelatedCompanies)
                    .HasColumnName("related_companies")
                    .HasColumnType("text");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TCasesRelations0>(entity =>
            {
                entity.ToTable("t_cases_relations_0");

                entity.HasIndex(e => e.LastUpdatedTime)
                    .HasName("key_last_updated_time");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.HasIndex(e => new { e.Eid, e.ObjId })
                    .HasName("eid_obj_id_index")
                    .IsUnique();

                entity.HasIndex(e => new { e.Eid, e.OrderDate })
                    .HasName("eid_order_date_index");

                entity.HasIndex(e => new { e.Eid, e.Role })
                    .HasName("eid_role_index");

                entity.HasIndex(e => new { e.Eid, e.Type })
                    .HasName("eid_type_index");

                entity.HasIndex(e => new { e.Eid, e.UTags, e.Type })
                    .HasName("eid_u_tags_type_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Assistant)
                    .HasColumnName("assistant")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseNo)
                    .HasColumnName("case_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseStatus)
                    .HasColumnName("case_status")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HearingDate)
                    .HasColumnName("hearing_date")
                    .HasColumnType("date");

                entity.Property(e => e.LastUpdatedTime)
                    .HasColumnName("last_updated_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.ObjId)
                    .IsRequired()
                    .HasColumnName("obj_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("date");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelatedCompanies)
                    .HasColumnName("related_companies")
                    .HasColumnType("text");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TChangeRecords0>(entity =>
            {
                entity.ToTable("t_change_records_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_change_records");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.AfterContent)
                    .HasColumnName("after_content")
                    .HasColumnType("text");

                entity.Property(e => e.BeforeContent)
                    .HasColumnName("before_content")
                    .HasColumnType("text");

                entity.Property(e => e.ChangeDate)
                    .IsRequired()
                    .HasColumnName("change_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChangeItem)
                    .IsRequired()
                    .HasColumnName("change_item")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TCheckups0>(entity =>
            {
                entity.ToTable("t_checkups_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_checkups");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("last_update_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ObjId)
                    .HasColumnName("obj_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegNo)
                    .HasColumnName("reg_no")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Result)
                    .IsRequired()
                    .HasColumnName("result")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TClearAccount0>(entity =>
            {
                entity.ToTable("t_clear_account_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_clear_account");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Employees)
                    .HasColumnName("employees")
                    .HasColumnType("varchar(6000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Leader)
                    .HasColumnName("leader")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TDoubleCheckups0>(entity =>
            {
                entity.ToTable("t_double_checkups_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("eid_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Details)
                    .HasColumnName("details")
                    .HasColumnType("text");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.InsAuth)
                    .HasColumnName("insAuth")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InsDate)
                    .HasColumnName("insDate")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RaninsPlanId)
                    .HasColumnName("raninsPlanId")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RaninsPlaneName)
                    .HasColumnName("raninsPlaneName")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RaninsTaskId)
                    .HasColumnName("raninsTaskId")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RaninsTaskName)
                    .HasColumnName("raninsTaskName")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RaninsTypeName)
                    .HasColumnName("raninsTypeName")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TEmails0>(entity =>
            {
                entity.ToTable("t_emails_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_emails");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TEmigrationStatus0>(entity =>
            {
                entity.ToTable("t_emigration_status_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("eid_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.MoveEid)
                    .HasColumnName("move_eid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MoveName)
                    .HasColumnName("move_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MoveType)
                    .HasColumnName("move_type")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TEmployees0>(entity =>
            {
                entity.ToTable("t_employees_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_employees");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CerNo)
                    .HasColumnName("cer_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.JobTitle)
                    .HasColumnName("job_title")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NamePid)
                    .HasColumnName("name_pid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NameType)
                    .HasColumnName("name_type")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TEnterprise0>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PRIMARY");

                entity.ToTable("t_enterprise_0");

                entity.HasIndex(e => e.Category)
                    .HasName("key_category");

                entity.HasIndex(e => e.CreatedTime)
                    .HasName("key_created_time");

                entity.HasIndex(e => e.Id)
                    .HasName("key_id");

                entity.HasIndex(e => e.LastUpdateTime)
                    .HasName("key_last_update_time");

                entity.HasIndex(e => e.Province)
                    .HasName("key_province");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ActualCapi)
                    .HasColumnName("actual_capi")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BelongOrg)
                    .HasColumnName("belong_org")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BelongOrgCode)
                    .HasColumnName("belong_org_code")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CheckDate)
                    .IsRequired()
                    .HasColumnName("check_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ColleguesNum)
                    .HasColumnName("collegues_num")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.CreditAreaCode)
                    .HasColumnName("credit_area_code")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreditNo)
                    .HasColumnName("credit_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CurrencyUnit)
                    .HasColumnName("currency_unit")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Department)
                    .IsRequired()
                    .HasColumnName("department")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasColumnType("text");

                entity.Property(e => e.EconKind)
                    .HasColumnName("econ_kind")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EconKindCode)
                    .HasColumnName("econ_kind_code")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EconType)
                    .IsRequired()
                    .HasColumnName("econ_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasColumnName("end_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GdLatitude)
                    .HasColumnName("gd_latitude")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.GdLongitude)
                    .HasColumnName("gd_longitude")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.GroupAbbreviation)
                    .HasColumnName("group_abbreviation")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GroupName)
                    .HasColumnName("group_name")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("last_update_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Latitude)
                    .HasColumnName("latitude")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.LogoUrl)
                    .IsRequired()
                    .HasColumnName("logo_url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LogoutDate)
                    .HasColumnName("logout_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LogoutReason)
                    .HasColumnName("logout_reason")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Longitude)
                    .HasColumnName("longitude")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ObjId)
                    .IsRequired()
                    .HasColumnName("obj_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OperName)
                    .HasColumnName("oper_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OperNameId)
                    .HasColumnName("oper_name_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OperType)
                    .HasColumnName("oper_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrgNo)
                    .HasColumnName("org_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrgType)
                    .HasColumnName("org_type")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProvinceCode)
                    .HasColumnName("province_code")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegNo)
                    .HasColumnName("reg_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegistCapi)
                    .HasColumnName("regist_capi")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegistCapiNew)
                    .HasColumnName("regist_capi_new")
                    .HasColumnType("double(18,6)");

                entity.Property(e => e.RevokeDate)
                    .HasColumnName("revoke_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RevokeReason)
                    .HasColumnName("revoke_reason")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RevokedCertificates)
                    .HasColumnName("revoked_certificates")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Scope)
                    .HasColumnName("scope")
                    .HasColumnType("text");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StatusCode)
                    .IsRequired()
                    .HasColumnName("status_code")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TaxNo)
                    .HasColumnName("tax_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TermEnd)
                    .IsRequired()
                    .HasColumnName("term_end")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TermStart)
                    .IsRequired()
                    .HasColumnName("term_start")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.TypeDesc)
                    .HasColumnName("type_desc")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TEquityquality0>(entity =>
            {
                entity.ToTable("t_equityquality_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_equityquality");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CancelItems)
                    .HasColumnName("cancel_items")
                    .HasColumnType("text");

                entity.Property(e => e.ChangeItems)
                    .HasColumnName("change_items")
                    .HasColumnType("text");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ObjectCompany)
                    .IsRequired()
                    .HasColumnName("object_company")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ObjectCompanyEid)
                    .IsRequired()
                    .HasColumnName("object_company_eid")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pawnee)
                    .HasColumnName("pawnee")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PawneeEid)
                    .IsRequired()
                    .HasColumnName("pawnee_eid")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PawneeIdentifyNo)
                    .HasColumnName("pawnee_identify_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PawneeIdentifyType)
                    .HasColumnName("pawnee_identify_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pledgor)
                    .HasColumnName("pledgor")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PledgorAmount)
                    .HasColumnName("pledgor_amount")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PledgorCurrency)
                    .HasColumnName("pledgor_currency")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PledgorEid)
                    .IsRequired()
                    .HasColumnName("pledgor_eid")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PledgorIdentifyNo)
                    .HasColumnName("pledgor_identify_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PledgorIdentifyType)
                    .HasColumnName("pledgor_identify_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PledgorUnit)
                    .HasColumnName("pledgor_unit")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PublicDate)
                    .HasColumnName("public_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TExecutedpersons>(entity =>
            {
                entity.ToTable("t_executedpersons");

                entity.HasIndex(e => e.CaseNumber)
                    .HasName("case_number_index");

                entity.HasIndex(e => e.Number)
                    .HasName("number_index");

                entity.HasIndex(e => e.Pid)
                    .HasName("pid_index");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("row_update_time_index");

                entity.HasIndex(e => e.Type)
                    .HasName("type_index");

                entity.HasIndex(e => new { e.Eid, e.CaseDate })
                    .HasName("key_eid_case_date");

                entity.HasIndex(e => new { e.Eid, e.UTags })
                    .HasName("key_eid_utags");

                entity.HasIndex(e => new { e.Name, e.Number })
                    .HasName("key_name_number");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CaseDate)
                    .HasColumnName("case_date")
                    .HasColumnType("date");

                entity.Property(e => e.CaseId)
                    .HasColumnName("case_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseNumber)
                    .HasColumnName("case_number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseRelation)
                    .HasColumnName("case_relation")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("last_update_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OpsFlag)
                    .HasColumnName("ops_flag")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'8'");

                entity.Property(e => e.PEid)
                    .HasColumnName("p_eid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PEname)
                    .HasColumnName("p_ename")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTagsUpdate)
                    .HasColumnName("u_tags_update")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TExecutions>(entity =>
            {
                entity.ToTable("t_executions");

                entity.HasIndex(e => e.CaseNumber)
                    .HasName("case_number_index");

                entity.HasIndex(e => e.ExId)
                    .HasName("ex_id_index");

                entity.HasIndex(e => e.Number)
                    .HasName("number_index");

                entity.HasIndex(e => e.Pid)
                    .HasName("pid_index");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("row_update_time_index");

                entity.HasIndex(e => e.Type)
                    .HasName("type_index");

                entity.HasIndex(e => new { e.Eid, e.PublishDate })
                    .HasName("eid_publish_date_index");

                entity.HasIndex(e => new { e.Eid, e.UTags })
                    .HasName("eid_u_tags_index");

                entity.HasIndex(e => new { e.Name, e.Number })
                    .HasName("name_number_index");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Age)
                    .HasColumnName("age")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CaseNumber)
                    .HasColumnName("case_number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseRelation)
                    .HasColumnName("case_relation")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConcernCount)
                    .HasColumnName("concern_count")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DocNumber)
                    .HasColumnName("doc_number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExDepartment)
                    .HasColumnName("ex_department")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExId)
                    .HasColumnName("ex_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExecutionDesc)
                    .HasColumnName("execution_desc")
                    .HasColumnType("text");

                entity.Property(e => e.ExecutionStatus)
                    .HasColumnName("execution_status")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FinalDuty)
                    .HasColumnName("final_duty")
                    .HasColumnType("text");

                entity.Property(e => e.ImportDate)
                    .HasColumnName("import_date")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.IsRelated)
                    .HasColumnName("is_related")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastUpdateTime)
                    .HasColumnName("last_update_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OperName)
                    .HasColumnName("oper_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OpsFlag)
                    .HasColumnName("ops_flag")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'8'");

                entity.Property(e => e.PEid)
                    .HasColumnName("p_eid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PEname)
                    .HasColumnName("p_ename")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pid)
                    .HasColumnName("pid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PublishDate)
                    .HasColumnName("publish_date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelatedCompanies)
                    .HasColumnName("related_companies")
                    .HasColumnType("text");

                entity.Property(e => e.Relatives)
                    .HasColumnName("relatives")
                    .HasColumnType("text");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Sex)
                    .HasColumnName("sex")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TJudicialFreezes0>(entity =>
            {
                entity.ToTable("t_judicial_freezes_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_judicial_freezes");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.BeExecutedPerson)
                    .HasColumnName("be_executed_person")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ContinueFreezeDetails)
                    .HasColumnName("continue_freeze_details")
                    .HasColumnType("text");

                entity.Property(e => e.Detail)
                    .HasColumnName("detail")
                    .HasColumnType("text");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ExecutiveCourt)
                    .HasColumnName("executive_court")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FreEid)
                    .HasColumnName("fre_eid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoseEfficacy)
                    .HasColumnName("lose_efficacy")
                    .HasColumnType("text");

                entity.Property(e => e.LoseEfficacyDate)
                    .HasColumnName("lose_efficacy_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LoseEfficacyReason)
                    .HasColumnName("lose_efficacy_reason")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PcFreezeDetail)
                    .HasColumnName("pc_freeze_detail")
                    .HasColumnType("text");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.SourceEid)
                    .HasColumnName("source_eid")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UnFreezeDetail)
                    .HasColumnName("un_freeze_detail")
                    .HasColumnType("text");

                entity.Property(e => e.UnFreezeDetails)
                    .HasColumnName("un_freeze_details")
                    .HasColumnType("text");
            });

            modelBuilder.Entity<TKaitinggonggaos0>(entity =>
            {
                entity.ToTable("t_kaitinggonggaos_0");

                entity.HasIndex(e => e.LastUpdatedTime)
                    .HasName("key_last_updated_time");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.Author)
                    .HasColumnName("author")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseNo)
                    .HasColumnName("case_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseReason)
                    .HasColumnName("case_reason")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CauseAction)
                    .HasColumnName("cause_action")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CodeSource)
                    .HasColumnName("code_source")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Defendant)
                    .HasColumnName("defendant")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HearingDate)
                    .HasColumnName("hearing_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Judge)
                    .HasColumnName("judge")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JudgeType)
                    .HasColumnName("judge_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastUpdatedTime)
                    .HasColumnName("last_updated_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Md5Id)
                    .IsRequired()
                    .HasColumnName("md5_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OpsFlag)
                    .HasColumnName("ops_flag")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'8'");

                entity.Property(e => e.People)
                    .HasColumnName("people")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Plaintiff)
                    .HasColumnName("plaintiff")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelatedCompanies)
                    .HasColumnName("related_companies")
                    .HasColumnType("text");

                entity.Property(e => e.ReleaseTime)
                    .HasColumnName("release_time")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tribunal)
                    .HasColumnName("tribunal")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TKaitinggonggaosRelations0>(entity =>
            {
                entity.ToTable("t_kaitinggonggaos_relations_0");

                entity.HasIndex(e => e.LastUpdatedTime)
                    .HasName("key_last_updated_time");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.HasIndex(e => new { e.Eid, e.CauseAction })
                    .HasName("eid_cause_action_index");

                entity.HasIndex(e => new { e.Eid, e.HearingDate })
                    .HasName("eid_date_index");

                entity.HasIndex(e => new { e.Eid, e.Md5Id })
                    .HasName("eid_md5_id_index")
                    .IsUnique();

                entity.HasIndex(e => new { e.Eid, e.MonthDate })
                    .HasName("eid_month_date_index");

                entity.HasIndex(e => new { e.Eid, e.ObjId })
                    .HasName("eid_obj_id_index");

                entity.HasIndex(e => new { e.Eid, e.OrderDate })
                    .HasName("eid_order_date_index");

                entity.HasIndex(e => new { e.Eid, e.PureRole })
                    .HasName("eid_pure_role_index");

                entity.HasIndex(e => new { e.Eid, e.YearDate })
                    .HasName("eid_year_date_index");

                entity.HasIndex(e => new { e.Eid, e.UTags, e.MonthDate })
                    .HasName("eid_u_tags_month_date_index");

                entity.HasIndex(e => new { e.Eid, e.UTags, e.YearDate })
                    .HasName("eid_u_tags_year_date_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CaseNo)
                    .HasColumnName("case_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CauseAction)
                    .HasColumnName("cause_action")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HearingDate)
                    .HasColumnName("hearing_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Judge)
                    .HasColumnName("judge")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.JudgeType)
                    .HasColumnName("judge_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastUpdatedTime)
                    .HasColumnName("last_updated_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Md5Id)
                    .HasColumnName("md5_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.MonthDate)
                    .HasColumnName("month_date")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ObjId)
                    .IsRequired()
                    .HasColumnName("obj_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("date");

                entity.Property(e => e.PureRole)
                    .HasColumnName("pure_role")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelatedCompanies)
                    .HasColumnName("related_companies")
                    .HasColumnType("text");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tribunal)
                    .HasColumnName("tribunal")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YearDate)
                    .HasColumnName("year_date")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TKnowledgeProperties0>(entity =>
            {
                entity.ToTable("t_knowledge_properties_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_knowledge_properties");

                entity.HasIndex(e => e.PawneeEid)
                    .HasName("key_pawnee_eid");

                entity.HasIndex(e => e.PledgorEid)
                    .HasName("key_pledgor_eid");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.HasIndex(e => e.Status)
                    .HasName("key_status");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pawnee)
                    .HasColumnName("pawnee")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PawneeEid)
                    .HasColumnName("pawnee_eid")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PawneeType)
                    .HasColumnName("pawnee_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Period)
                    .HasColumnName("period")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pledgor)
                    .HasColumnName("pledgor")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PledgorEid)
                    .HasColumnName("pledgor_eid")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PledgorType)
                    .HasColumnName("pledgor_type")
                    .HasColumnType("int(11)");

                entity.Property(e => e.PublicDate)
                    .HasColumnName("public_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TLastIndustry0>(entity =>
            {
                entity.ToTable("t_last_industry_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("key_eid")
                    .IsUnique();

                entity.HasIndex(e => e.Md5)
                    .HasName("md5")
                    .IsUnique();

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.HasIndex(e => e.Source)
                    .HasName("key_source");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreateTime)
                    .HasColumnName("create_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IndustryCode)
                    .IsRequired()
                    .HasColumnName("industry_code")
                    .HasColumnType("char(5)");

                entity.Property(e => e.IsValid)
                    .HasColumnName("is_valid")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.Md5)
                    .IsRequired()
                    .HasColumnName("md5")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("tinyint(4)");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasColumnName("start_date")
                    .HasColumnType("char(10)");

                entity.Property(e => e.UpdateTime)
                    .HasColumnName("update_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<TLawsuitsRelations0>(entity =>
            {
                entity.ToTable("t_lawsuits_relations_0");

                entity.HasIndex(e => e.LastUpdatedTime)
                    .HasName("key_last_updated_time");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.HasIndex(e => new { e.Eid, e.CaseCause })
                    .HasName("eid_case_cause");

                entity.HasIndex(e => new { e.Eid, e.CauseAction })
                    .HasName("eid_cause_action_index");

                entity.HasIndex(e => new { e.Eid, e.Date })
                    .HasName("eid_date_index");

                entity.HasIndex(e => new { e.Eid, e.Md5 })
                    .HasName("eid_md5_index")
                    .IsUnique();

                entity.HasIndex(e => new { e.Eid, e.ObjId })
                    .HasName("eid_obj_id_index");

                entity.HasIndex(e => new { e.Eid, e.Role })
                    .HasName("eid_role_index");

                entity.HasIndex(e => new { e.Eid, e.SubAmount })
                    .HasName("eid_sub_amount_index");

                entity.HasIndex(e => new { e.Eid, e.Type })
                    .HasName("eid_type_index");

                entity.HasIndex(e => new { e.Eid, e.YearDate })
                    .HasName("eid_year_date_index");

                entity.HasIndex(e => new { e.Eid, e.UTags, e.CauseAction })
                    .HasName("eid_u_tags_cause_action_index");

                entity.HasIndex(e => new { e.Eid, e.UTags, e.Role })
                    .HasName("eid_u_tags_role_index");

                entity.HasIndex(e => new { e.Eid, e.UTags, e.Type })
                    .HasName("eid_u_tags_type_index");

                entity.HasIndex(e => new { e.Eid, e.UTags, e.YearDate })
                    .HasName("eid_u_tags_year_date_index");

                entity.HasIndex(e => new { e.Eid, e.CaseType, e.DocType, e.CaseCause })
                    .HasName("eid_case_doc_case_cause");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CaseCause)
                    .HasColumnName("case_cause")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseCauses)
                    .HasColumnName("case_causes")
                    .HasColumnType("text");

                entity.Property(e => e.CaseNo)
                    .HasColumnName("case_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseRelation)
                    .HasColumnName("case_relation")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CaseStatus)
                    .HasColumnName("case_status")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CaseType)
                    .HasColumnName("case_type")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CauseAction)
                    .HasColumnName("cause_action")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Defendants)
                    .HasColumnName("defendants")
                    .HasColumnType("text");

                entity.Property(e => e.DocId)
                    .HasColumnName("doc_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DocType)
                    .HasColumnName("doc_type")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FreezingInfo)
                    .HasColumnName("freezing_info")
                    .HasColumnType("text");

                entity.Property(e => e.Judgeresult)
                    .HasColumnName("judgeresult")
                    .HasColumnType("text");

                entity.Property(e => e.LastUpdatedTime)
                    .HasColumnName("last_updated_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.LawFirm)
                    .HasColumnName("law_firm")
                    .HasColumnType("text");

                entity.Property(e => e.LegalBase)
                    .HasColumnName("legal_base")
                    .HasColumnType("text");

                entity.Property(e => e.Md5)
                    .HasColumnName("md5")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ObjId)
                    .IsRequired()
                    .HasColumnName("obj_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Plaintiffs)
                    .HasColumnName("plaintiffs")
                    .HasColumnType("text");

                entity.Property(e => e.PubDate)
                    .HasColumnName("pub_date")
                    .HasColumnType("date");

                entity.Property(e => e.RelatedCompanies)
                    .HasColumnName("related_companies")
                    .HasColumnType("text");

                entity.Property(e => e.RelatedRelation)
                    .HasColumnName("related_relation")
                    .HasColumnType("text");

                entity.Property(e => e.RelationDetails)
                    .HasColumnName("relation_details")
                    .HasColumnType("text");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SubAmount)
                    .HasColumnName("sub_amount")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YearDate)
                    .HasColumnName("year_date")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YearPubdate)
                    .HasColumnName("year_pubdate")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TLicenseInfo0>(entity =>
            {
                entity.ToTable("t_license_info_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_license_info");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("text");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("varchar(20)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TMortgages0>(entity =>
            {
                entity.ToTable("t_mortgages_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_mortgages");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Amount)
                    .HasColumnName("amount")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ChangeInfo)
                    .HasColumnName("changeInfo")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.CloseDate)
                    .HasColumnName("close_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CloseReason)
                    .IsRequired()
                    .HasColumnName("close_reason")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DebitAmount)
                    .HasColumnName("debit_amount")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DebitCurrency)
                    .HasColumnName("debit_currency")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DebitPeriod)
                    .HasColumnName("debit_period")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DebitRemarks)
                    .IsRequired()
                    .HasColumnName("debit_remarks")
                    .HasColumnType("varchar(5000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DebitScope)
                    .IsRequired()
                    .HasColumnName("debit_scope")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DebitType)
                    .HasColumnName("debit_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ExId)
                    .HasColumnName("ex_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Guarantees)
                    .HasColumnName("guarantees")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Mortgagees)
                    .HasColumnName("mortgagees")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Number)
                    .HasColumnName("number")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Period)
                    .HasColumnName("period")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.PublicDate)
                    .HasColumnName("public_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Remarks)
                    .HasColumnName("remarks")
                    .HasColumnType("varchar(5000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Scope)
                    .HasColumnName("scope")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tags)
                    .HasColumnName("tags")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TNotices>(entity =>
            {
                entity.ToTable("t_notices");

                entity.HasIndex(e => e.Court)
                    .HasName("court_index");

                entity.HasIndex(e => e.ExId)
                    .HasName("ex_id_index");

                entity.HasIndex(e => e.LastUpdatedTime)
                    .HasName("key_last_updated_time");

                entity.HasIndex(e => e.Md5)
                    .HasName("md5_index");

                entity.HasIndex(e => e.OpsFlag)
                    .HasName("ops_flag_index");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.HasIndex(e => e.Type)
                    .HasName("type_index");

                entity.Property(e => e.Id)
                    .HasColumnName("_id")
                    .HasColumnType("varchar(50)");

                entity.Property(e => e.CaseReason)
                    .HasColumnName("case_reason")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExId)
                    .IsRequired()
                    .HasColumnName("ex_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastUpdatedTime)
                    .HasColumnName("last_updated_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Md5)
                    .IsRequired()
                    .HasColumnName("md5")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OpsFlag)
                    .HasColumnName("ops_flag")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'8'");

                entity.Property(e => e.Pdf)
                    .HasColumnName("pdf")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.People)
                    .HasColumnName("people")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelatedCheck)
                    .HasColumnName("related_check")
                    .HasColumnType("text");

                entity.Property(e => e.RelatedCompanies)
                    .HasColumnName("related_companies")
                    .HasColumnType("text");

                entity.Property(e => e.RelationDetails)
                    .HasColumnName("relation_details")
                    .HasColumnType("text");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(4)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TNoticesRelations0>(entity =>
            {
                entity.ToTable("t_notices_relations_0");

                entity.HasIndex(e => e.LastUpdatedTime)
                    .HasName("key_last_updated_time");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.HasIndex(e => new { e.Eid, e.Date })
                    .HasName("eid_date_index");

                entity.HasIndex(e => new { e.Eid, e.ObjId })
                    .HasName("eid_obj_id_index")
                    .IsUnique();

                entity.HasIndex(e => new { e.Eid, e.OrderDate })
                    .HasName("eid_order_date_index");

                entity.HasIndex(e => new { e.Eid, e.Role })
                    .HasName("eid_role_index");

                entity.HasIndex(e => new { e.Eid, e.Type })
                    .HasName("eid_type_index");

                entity.HasIndex(e => new { e.Eid, e.YearDate })
                    .HasName("eid_year_date_index");

                entity.HasIndex(e => new { e.Eid, e.UTags, e.Type })
                    .HasName("eid_u_tags_type_index");

                entity.HasIndex(e => new { e.Eid, e.UTags, e.YearDate })
                    .HasName("eid_u_tags_year_date_index");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Content)
                    .HasColumnName("content")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Court)
                    .HasColumnName("court")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreatedTime)
                    .HasColumnName("created_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Ename)
                    .HasColumnName("ename")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastUpdatedTime)
                    .HasColumnName("last_updated_time")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.ObjId)
                    .IsRequired()
                    .HasColumnName("obj_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("order_date")
                    .HasColumnType("date");

                entity.Property(e => e.People)
                    .HasColumnName("people")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RelatedCompanies)
                    .HasColumnName("related_companies")
                    .HasColumnType("text");

                entity.Property(e => e.Role)
                    .HasColumnName("role")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.Type)
                    .HasColumnName("type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.YearDate)
                    .HasColumnName("year_date")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TOtherInfomation0>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PRIMARY");

                entity.ToTable("t_other_infomation_0");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Abnormals)
                    .HasColumnName("abnormals")
                    .HasColumnType("text");

                entity.Property(e => e.AdministrativePunishmentsAlls)
                    .HasColumnName("administrative_punishments_alls")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Auctions)
                    .HasColumnName("auctions")
                    .HasColumnType("text");

                entity.Property(e => e.BranchesOrigin)
                    .HasColumnName("branches_origin")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Brands)
                    .HasColumnName("brands")
                    .HasColumnType("text");

                entity.Property(e => e.ChangerecordsAlls)
                    .HasColumnName("changerecords_alls")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.ChangerecordsHidden)
                    .HasColumnName("changerecords_hidden")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Checkups)
                    .HasColumnName("checkups")
                    .HasColumnType("text");

                entity.Property(e => e.CollectedCount)
                    .HasColumnName("collected_count")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EquityQualitiesAlls)
                    .HasColumnName("equity_qualities_alls")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.EquityQualitiesOrigin)
                    .HasColumnName("equity_qualities_origin")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.EquityQualitiesOther)
                    .HasColumnName("equity_qualities_other")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Estimate)
                    .HasColumnName("estimate")
                    .HasColumnType("text");

                entity.Property(e => e.Executions)
                    .HasColumnName("executions")
                    .HasColumnType("text");

                entity.Property(e => e.ExtraPhones)
                    .HasColumnName("extra_phones")
                    .HasColumnType("text");

                entity.Property(e => e.Faxes)
                    .HasColumnName("faxes")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HistoryNames)
                    .HasColumnName("history_names")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.HistoryPartners)
                    .HasColumnName("history_partners")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.HistroyOperNames)
                    .HasColumnName("histroy_oper_names")
                    .HasColumnType("text");

                entity.Property(e => e.HistroyRegistCapis)
                    .HasColumnName("histroy_regist_capis")
                    .HasColumnType("text");

                entity.Property(e => e.JudicialFreezesAlls)
                    .HasColumnName("judicial_freezes_alls")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.JudicialFreezesHidden)
                    .HasColumnName("judicial_freezes_hidden")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.JudicialFreezesOrigin)
                    .HasColumnName("judicial_freezes_origin")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.JudicialFreezesOther)
                    .HasColumnName("judicial_freezes_other")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.KnowledgePropertiesHidden)
                    .HasColumnName("knowledge_properties_hidden")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Lawsuits)
                    .HasColumnName("lawsuits")
                    .HasColumnType("text");

                entity.Property(e => e.LicensesAlls)
                    .HasColumnName("licenses_alls")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.MoPhones)
                    .HasColumnName("mo_phones")
                    .HasColumnType("text");

                entity.Property(e => e.MortgagesAlls)
                    .HasColumnName("mortgages_alls")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.MortgagesHidden)
                    .HasColumnName("mortgages_hidden")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Parameters)
                    .HasColumnName("parameters")
                    .HasColumnType("text");

                entity.Property(e => e.Products)
                    .HasColumnName("products")
                    .HasColumnType("text");

                entity.Property(e => e.QgParameters)
                    .HasColumnName("qg_parameters")
                    .HasColumnType("text");

                entity.Property(e => e.Relation)
                    .HasColumnName("relation")
                    .HasColumnType("text");

                entity.Property(e => e.RelationFlag)
                    .IsRequired()
                    .HasColumnName("relation_flag")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.ShortNames)
                    .HasColumnName("short_names")
                    .HasColumnType("varchar(3000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Stocks)
                    .HasColumnName("stocks")
                    .HasColumnType("text");

                entity.Property(e => e.Tags)
                    .IsRequired()
                    .HasColumnName("tags")
                    .HasColumnType("varchar(1000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Trademarks)
                    .HasColumnName("trademarks")
                    .HasColumnType("text");

                entity.Property(e => e.UpdateRecordsHidden)
                    .HasColumnName("update_records_hidden")
                    .HasColumnType("mediumtext");
            });

            modelBuilder.Entity<TPartners0>(entity =>
            {
                entity.ToTable("t_partners_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_partners");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Category)
                    .HasColumnName("category")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.EntityType)
                    .IsRequired()
                    .HasColumnName("entity_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExId)
                    .IsRequired()
                    .HasColumnName("ex_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IdentifyNo)
                    .HasColumnName("identify_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IdentifyType)
                    .HasColumnName("identify_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RealCapiItems)
                    .HasColumnName("real_capi_items")
                    .HasColumnType("text");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.ShouldCapiItems)
                    .HasColumnName("should_capi_items")
                    .HasColumnType("text");

                entity.Property(e => e.StockId)
                    .HasColumnName("stock_id")
                    .HasColumnType("varchar(50)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StockName)
                    .HasColumnName("stock_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StockPercent)
                    .HasColumnName("stock_percent")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StockType)
                    .HasColumnName("stock_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Tag)
                    .HasColumnName("tag")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TotalRealCapi)
                    .HasColumnName("total_real_capi")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TotalShouldCapi)
                    .HasColumnName("total_should_capi")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TReportDetail20170>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PRIMARY");

                entity.ToTable("t_report_detail_2017_0");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .HasColumnName("branch")
                    .HasColumnType("text");

                entity.Property(e => e.ChangeRecords)
                    .HasColumnName("change_records")
                    .HasColumnType("text");

                entity.Property(e => e.ColleguesNum)
                    .HasColumnName("collegues_num")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreditNo)
                    .HasColumnName("credit_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DebitAmount)
                    .HasColumnName("debit_amount")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EmailTags)
                    .HasColumnName("email_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EnterpriseHoldingSituation)
                    .HasColumnName("enterprise_holding_situation")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExId)
                    .HasColumnName("ex_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExternalGuarantees)
                    .HasColumnName("external_guarantees")
                    .HasColumnType("text");

                entity.Property(e => e.FareScope)
                    .HasColumnName("fare_scope")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FemaleColleguesNum)
                    .HasColumnName("female_collegues_num")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GuaranteeItems)
                    .HasColumnName("guarantee_items")
                    .HasColumnType("text");

                entity.Property(e => e.IfEquity)
                    .HasColumnName("if_equity")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IfExternalGuarantee)
                    .HasColumnName("if_external_guarantee")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IfInvest)
                    .HasColumnName("if_invest")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IfWebsite)
                    .HasColumnName("if_website")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IndivFormMode)
                    .HasColumnName("indiv_form_mode")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InvestItems)
                    .HasColumnName("invest_items")
                    .HasColumnType("text");

                entity.Property(e => e.InvestSituation)
                    .HasColumnName("invest_situation")
                    .HasColumnType("text");

                entity.Property(e => e.JsonData)
                    .HasColumnName("json_data")
                    .HasColumnType("text");

                entity.Property(e => e.MatterRecord)
                    .HasColumnName("matter_record")
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NetAmount)
                    .HasColumnName("net_amount")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OperName)
                    .HasColumnName("oper_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Partners)
                    .HasColumnName("partners")
                    .HasColumnType("text");

                entity.Property(e => e.PracPersonNum)
                    .HasColumnName("prac_person_num")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProfitReta)
                    .HasColumnName("profit_reta")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProfitTotal)
                    .HasColumnName("profit_total")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegCapi)
                    .HasColumnName("reg_capi")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegNo)
                    .HasColumnName("reg_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegistCapiInfo)
                    .HasColumnName("regist_capi_info")
                    .HasColumnType("text");

                entity.Property(e => e.ReportDate)
                    .HasColumnName("report_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportName)
                    .HasColumnName("report_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportYear)
                    .HasColumnName("report_year")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SaleIncome)
                    .HasColumnName("sale_income")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ServFareIncome)
                    .HasColumnName("serv_fare_income")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SocialSecurity)
                    .HasColumnName("social_security")
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StockChanges)
                    .HasColumnName("stock_changes")
                    .HasColumnType("text");

                entity.Property(e => e.TaxTotal)
                    .HasColumnName("tax_total")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TelTags)
                    .HasColumnName("tel_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TotalEquity)
                    .HasColumnName("total_equity")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UpdateRecords)
                    .HasColumnName("update_records")
                    .HasColumnType("text");

                entity.Property(e => e.Websites)
                    .HasColumnName("websites")
                    .HasColumnType("text");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zip_code")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TReportDetailOther0>(entity =>
            {
                entity.ToTable("t_report_detail_other_0");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.HasIndex(e => new { e.Eid, e.ReportYear })
                    .HasName("unique_key_eid")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Branch)
                    .HasColumnName("branch")
                    .HasColumnType("text");

                entity.Property(e => e.ChangeRecords)
                    .HasColumnName("change_records")
                    .HasColumnType("text");

                entity.Property(e => e.ColleguesNum)
                    .HasColumnName("collegues_num")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreateDate)
                    .HasColumnName("create_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreditNo)
                    .HasColumnName("credit_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DebitAmount)
                    .HasColumnName("debit_amount")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EmailTags)
                    .HasColumnName("email_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.EnterpriseHoldingSituation)
                    .HasColumnName("enterprise_holding_situation")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExId)
                    .HasColumnName("ex_id")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ExternalGuarantees)
                    .HasColumnName("external_guarantees")
                    .HasColumnType("text");

                entity.Property(e => e.FareScope)
                    .HasColumnName("fare_scope")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.FemaleColleguesNum)
                    .HasColumnName("female_collegues_num")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.GuaranteeItems)
                    .HasColumnName("guarantee_items")
                    .HasColumnType("text");

                entity.Property(e => e.IfEquity)
                    .HasColumnName("if_equity")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IfExternalGuarantee)
                    .HasColumnName("if_external_guarantee")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IfInvest)
                    .HasColumnName("if_invest")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IfWebsite)
                    .HasColumnName("if_website")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.IndivFormMode)
                    .HasColumnName("indiv_form_mode")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.InvestItems)
                    .HasColumnName("invest_items")
                    .HasColumnType("text");

                entity.Property(e => e.InvestSituation)
                    .HasColumnName("invest_situation")
                    .HasColumnType("text");

                entity.Property(e => e.JsonData)
                    .HasColumnName("json_data")
                    .HasColumnType("text");

                entity.Property(e => e.MatterRecord)
                    .HasColumnName("matter_record")
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NetAmount)
                    .HasColumnName("net_amount")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.OperName)
                    .HasColumnName("oper_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Partners)
                    .HasColumnName("partners")
                    .HasColumnType("text");

                entity.Property(e => e.PracPersonNum)
                    .HasColumnName("prac_person_num")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProfitReta)
                    .HasColumnName("profit_reta")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ProfitTotal)
                    .HasColumnName("profit_total")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegCapi)
                    .HasColumnName("reg_capi")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegNo)
                    .HasColumnName("reg_no")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RegistCapiInfo)
                    .HasColumnName("regist_capi_info")
                    .HasColumnType("text");

                entity.Property(e => e.ReportDate)
                    .HasColumnName("report_date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportName)
                    .HasColumnName("report_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ReportYear)
                    .HasColumnName("report_year")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SaleIncome)
                    .HasColumnName("sale_income")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ServFareIncome)
                    .HasColumnName("serv_fare_income")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SocialSecurity)
                    .HasColumnName("social_security")
                    .HasColumnType("text");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StockChanges)
                    .HasColumnName("stock_changes")
                    .HasColumnType("text");

                entity.Property(e => e.TaxTotal)
                    .HasColumnName("tax_total")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TelTags)
                    .HasColumnName("tel_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Telephone)
                    .HasColumnName("telephone")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TotalEquity)
                    .HasColumnName("total_equity")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UpdateRecords)
                    .HasColumnName("update_records")
                    .HasColumnType("text");

                entity.Property(e => e.Websites)
                    .HasColumnName("websites")
                    .HasColumnType("text");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("zip_code")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TReports0>(entity =>
            {
                entity.HasKey(e => e.Eid)
                    .HasName("PRIMARY");

                entity.ToTable("t_reports_0");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Eid)
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ReportYear)
                    .HasColumnName("report_year")
                    .HasColumnType("varchar(10000)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();
            });

            modelBuilder.Entity<TSeriousIllegal0>(entity =>
            {
                entity.ToTable("t_serious_illegal_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_serious_illegal");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.ExecutedPerson)
                    .HasColumnName("executed_person")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.Execution)
                    .HasColumnName("execution")
                    .HasColumnType("text");

                entity.Property(e => e.MajorTaxViolatio)
                    .HasColumnName("major_tax_violatio")
                    .HasColumnType("text");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");
            });

            modelBuilder.Entity<TSimpleCancellationAnnouncement0>(entity =>
            {
                entity.ToTable("t_simple_cancellation_announcement_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_simple_cancellation_announcement");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.CreditRegNo)
                    .HasColumnName("credit_reg_no")
                    .HasColumnType("varchar(100)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Department)
                    .HasColumnName("department")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.GsScaObjections)
                    .HasColumnName("gs_sca_objections")
                    .HasColumnType("text");

                entity.Property(e => e.GsScaResult)
                    .HasColumnName("gs_sca_result")
                    .HasColumnType("text");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NoticePeriod)
                    .HasColumnName("notice_period")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Url)
                    .HasColumnName("url")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TStockholderPercentageNew0>(entity =>
            {
                entity.ToTable("t_stockholder_percentage_new_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_stockholder_percentage_new");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Percentage)
                    .HasColumnName("percentage")
                    .HasColumnType("mediumtext");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'-1'");

                entity.Property(e => e.SpDate)
                    .HasColumnName("sp_date")
                    .HasColumnType("bigint(20)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpSource)
                    .HasColumnName("sp_source")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TTelephones0>(entity =>
            {
                entity.ToTable("t_telephones_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_telephones");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.UTags)
                    .HasColumnName("u_tags")
                    .HasColumnType("varchar(10)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TWebsites0>(entity =>
            {
                entity.ToTable("t_websites_0");

                entity.HasIndex(e => e.Eid)
                    .HasName("index_eid_on_t_websites");

                entity.HasIndex(e => e.RowUpdateTime)
                    .HasName("key_row_update_time");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasColumnType("bigint(20)");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Eid)
                    .IsRequired()
                    .HasColumnName("eid")
                    .HasColumnType("char(36)");

                entity.Property(e => e.RowUpdateTime)
                    .HasColumnName("row_update_time")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("'CURRENT_TIMESTAMP'")
                    .ValueGeneratedOnAddOrUpdate();

                entity.Property(e => e.SeqNo)
                    .HasColumnName("seq_no")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WebName)
                    .HasColumnName("web_name")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WebType)
                    .HasColumnName("web_type")
                    .HasColumnType("varchar(255)")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.WebUrl)
                    .IsRequired()
                    .HasColumnName("web_url")
                    .HasColumnType("varchar(2000)")
                    .HasDefaultValueSql("''");
            });
        }
    }
}
