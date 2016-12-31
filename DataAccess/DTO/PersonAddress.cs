using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public partial class PersonAddress
    {
        public int PersonId { get; set; }
        public string First_Name { get; set; }
        public string Middle_Initial { get; set; }
        public string Last_Name { get; set; }
        public string Gender { get; set; }
        public Nullable<int> AddressId { get; set; }
        public Nullable<System.DateTime> Holy_Ghost { get; set; }
        public Nullable<System.DateTime> Baptized { get; set; }
        public Nullable<sbyte> ChurchMember { get; set; }
        public Nullable<int> MaritalStatusId { get; set; }
        public System.DateTime LastModified { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }

        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
