//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataLibrary
{
    using System;
    using System.Collections.Generic;
    
    public partial class Feedback
    {
        public int Id { get; set; }
        public string Comments { get; set; }
        public Nullable<bool> Recommend { get; set; }
        public int UserId { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime UpdatedOn { get; set; }
        public int FacultyId { get; set; }
    
        public virtual User User { get; set; }
        public virtual User User1 { get; set; }
    }
}
