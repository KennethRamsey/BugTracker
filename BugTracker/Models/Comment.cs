//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BugTracker.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Comment
    {
        public int ID { get; set; }
        public int TicketID { get; set; }
        public int CommentorID { get; set; }
        public System.DateTime CommentDate { get; set; }
        public string Comment1 { get; set; }
    
        public virtual Ticket Ticket { get; set; }
        public virtual User User { get; set; }
    }
}
