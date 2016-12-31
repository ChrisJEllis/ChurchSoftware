using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class PersonDTO
    {
        public int PersonId { get; set; }
        public string First_Name { get; set; }
        public string Middle_Initial { get; set; }
        public string Last_Name { get; set; }
        public string FullName { get; set; }
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
    }
}
