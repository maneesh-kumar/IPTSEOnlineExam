//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class tbl_Test_Question_Map
    {
        public int ID { get; set; }
        public Nullable<int> TestId { get; set; }
        public string QuestionId { get; set; }
        public Nullable<int> QuestionSeqNo { get; set; }
        public Nullable<int> AnswerChoiceId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
    }
}
