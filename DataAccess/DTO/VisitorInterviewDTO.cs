using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DTO
{
    public class VisitorInterviewDTO
    {
        public int VisitorInterviewId { get; set; }
        public Nullable<int> PersonId { get; set; }
        public Nullable<bool> InterestedInBibleStudy { get; set; }
        public Nullable<DateTime> VisitationDate { get; set; }
        public string StreetAddress { get; set; }
        public Nullable<int> CityId { get; set; }
        public string Zip { get; set; }
        public Nullable<bool> PreferredMethodOfContact_Phone { get; set; }
        public Nullable<bool> PreferredMethodOfContact_Mail { get; set; }
        public Nullable<bool> PreferredMethodOfContact_Email { get; set; }
        public Nullable<System.TimeSpan> BestTimeToCall { get; set; }
        public Nullable<bool> FirstTimeGuest { get; set; }
        public Nullable<bool> SecondTimeGuest { get; set; }
        public Nullable<bool> ThirdTimeGuest { get; set; }
        public Nullable<int> AgeGroupId { get; set; }
        public Nullable<int> MaritalStatusId { get; set; }
        public Nullable<int> VisitorInterestsId { get; set; }
        public DateTime LastModified { get; set; }
        public int LastModifiedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
