//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class ministry
    {
        public ministry()
        {
            this.ministryevents = new HashSet<ministryevent>();
        }
    
        public int MinistryId { get; set; }
        public string MinistryName { get; set; }
        public Nullable<int> MinistryLeaderId { get; set; }
        public System.DateTime LastModified { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    
        public virtual person person { get; set; }
        public virtual ICollection<ministryevent> ministryevents { get; set; }
    }
}