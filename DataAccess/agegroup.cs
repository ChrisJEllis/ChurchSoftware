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
    
    public partial class agegroup
    {
        public agegroup()
        {
            this.visitorinterviews = new HashSet<visitorinterview>();
        }
    
        public int AgeGroupId { get; set; }
        public string AgeGroupCode { get; set; }
        public System.DateTime LastModified { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    
        public virtual ICollection<visitorinterview> visitorinterviews { get; set; }
    }
}