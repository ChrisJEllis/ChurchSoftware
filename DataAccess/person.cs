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
    
    public partial class person
    {
        public person()
        {
            this.attendances = new HashSet<attendance>();
            this.biblestudyevents = new HashSet<biblestudyevent>();
            this.biblestudyevents1 = new HashSet<biblestudyevent>();
            this.ministries = new HashSet<ministry>();
            this.staffs = new HashSet<staff>();
            this.visitorinterviews = new HashSet<visitorinterview>();
        }
    
        public int PersonId { get; set; }
        public string First_Name { get; set; }
        public string Middle_Initial { get; set; }
        public string Last_Name { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<System.DateTime> Holy_Ghost { get; set; }
        public Nullable<System.DateTime> Baptized { get; set; }
        public Nullable<sbyte> ChurchMember { get; set; }
        public Nullable<int> MaritalStatusId { get; set; }
        public System.DateTime LastModified { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string Gender { get; set; }
    
        public virtual address address { get; set; }
        public virtual ICollection<attendance> attendances { get; set; }
        public virtual ICollection<biblestudyevent> biblestudyevents { get; set; }
        public virtual ICollection<biblestudyevent> biblestudyevents1 { get; set; }
        public virtual maritalstatu maritalstatu { get; set; }
        public virtual ICollection<ministry> ministries { get; set; }
        public virtual ICollection<staff> staffs { get; set; }
        public virtual ICollection<visitorinterview> visitorinterviews { get; set; }
    }
}