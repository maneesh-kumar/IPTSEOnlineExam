﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IPTSEOnlineExam.DAL
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IPTSE_EXAMEntities : DbContext
    {
        public IPTSE_EXAMEntities()
            : base("name=IPTSE_EXAMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tbl_Question> tbl_Question { get; set; }
        public virtual DbSet<tbl_Question_Category> tbl_Question_Category { get; set; }
        public virtual DbSet<tbl_Question_Choice> tbl_Question_Choice { get; set; }
        public virtual DbSet<tbl_Test> tbl_Test { get; set; }
        public virtual DbSet<tbl_Test_Question_Map> tbl_Test_Question_Map { get; set; }
        public virtual DbSet<tbl_Txn_Question_Duration_Map> tbl_Txn_Question_Duration_Map { get; set; }
        public virtual DbSet<tbl_Txn_Test_Result> tbl_Txn_Test_Result { get; set; }
    }
}
