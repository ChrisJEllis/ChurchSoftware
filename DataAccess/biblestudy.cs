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
    
    public partial class biblestudy
    {
        public biblestudy()
        {
            this.biblestudyevents = new HashSet<biblestudyevent>();
        }
    
        public int BibleStudyId { get; set; }
        public string BibleStudyName { get; set; }
        public System.DateTime LastModified { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    
        public virtual ICollection<biblestudyevent> biblestudyevents { get; set; }
    }
}