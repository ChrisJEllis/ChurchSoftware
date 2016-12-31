using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    class VisitorInterestsDTO
    {
        public int VisitorInterestsId { get; set; }
        public Nullable<int> InterestId { get; set; }
        public System.DateTime LastModified { get; set; }
        public int LastModifiedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
