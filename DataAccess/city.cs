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
    
    public partial class city
    {
        public city()
        {
            this.addresses = new HashSet<address>();
            this.visitorinterviews = new HashSet<visitorinterview>();
        }
    
        public int CityId { get; set; }
        public string CityName { get; set; }
        public Nullable<int> StateId { get; set; }
        public System.DateTime LastModified { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    
        public virtual ICollection<address> addresses { get; set; }
        public virtual state state { get; set; }
        public virtual ICollection<visitorinterview> visitorinterviews { get; set; }
    }
}
