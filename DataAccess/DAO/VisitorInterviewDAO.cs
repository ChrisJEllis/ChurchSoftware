using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;

namespace DataAccess.DAO
{
    public class VisitorInterviewDAO
    {
        ChurchEntities ctx = new ChurchEntities();
        public List<VisitorInterviewDTO> GetVisitorInterviews()
        {
            var vi = from cvi in ctx.visitorinterviews
                     select new VisitorInterviewDTO()
                    {
                        PersonId = cvi.PersonId,
                        InterestedInBibleStudy = cvi.InterestedInBibleStudy,
                        VisitationDate = cvi.VisitationDate,
                        StreetAddress = cvi.StreetAddress,
                        CityId = cvi.CityId,
                        Zip = cvi.Zip,
                        PreferredMethodOfContact_Email = cvi.PreferredMethodOfContact_Email,
                        PreferredMethodOfContact_Mail = cvi.PreferredMethodOfContact_Mail,
                        PreferredMethodOfContact_Phone = cvi.PreferredMethodOfContact_Phone,
                        BestTimeToCall = cvi.BestTimeToCall,
                        FirstTimeGuest = cvi.FirstTimeGuest,
                        SecondTimeGuest = cvi.SecondTimeGuest,
                        ThirdTimeGuest = cvi.ThirdTimeGuest,
                        AgeGroupId = cvi.AgeGroupId,
                        MaritalStatusId = cvi.MaritalStatusId,
                        VisitorInterestsId = cvi.VisitorInterestsId,
                        LastModified = cvi.LastModified,
                        LastModifiedBy = cvi.LastModifiedBy,
                        CreatedDate = cvi.CreatedDate,
                        CreatedBy = cvi.CreatedBy
                    };;
            return vi.ToList();
        }
        public int AddVisitorInterview(int personId, bool interestedInBibleStudy, DateTime visitationDate, 
            string streetAddress, int? cityId, string zip, bool preferredMethodOfContact_Phone, 
            bool preferredMethodOfContact_Mail, bool preferredMethodOfContact_Email, TimeSpan bestTimeToCall, 
            bool firstTimeGuest, bool secondTimeGuest, bool thirdTimeGuest, int? ageGroupId, int? maritalStatusId, 
            int? visitorInterestsId) {
            visitorinterview vi = ctx.visitorinterviews.Create();
            vi.PersonId = personId;
            vi.InterestedInBibleStudy = interestedInBibleStudy;
            vi.VisitationDate = visitationDate;
            vi.StreetAddress = streetAddress;
            vi.CityId = cityId;
            vi.Zip = zip;
            vi.PreferredMethodOfContact_Email = preferredMethodOfContact_Email;
            vi.PreferredMethodOfContact_Mail = preferredMethodOfContact_Mail;
            vi.PreferredMethodOfContact_Phone = preferredMethodOfContact_Phone;
            vi.BestTimeToCall = bestTimeToCall;
            vi.FirstTimeGuest = firstTimeGuest;
            vi.SecondTimeGuest = secondTimeGuest;
            vi.ThirdTimeGuest = thirdTimeGuest;
            vi.AgeGroupId = ageGroupId;
            vi.MaritalStatusId = maritalStatusId;
            vi.VisitorInterestsId = visitorInterestsId;
            vi.LastModified = DateTime.Now;
            vi.LastModifiedBy = 1;
            vi.CreatedDate = DateTime.Now;
            vi.CreatedBy = 1;
            ctx.visitorinterviews.Add(vi);
            ctx.SaveChanges();
            return vi.VisitorInterviewId;
        }

        public bool DeleteVisitorInterview(int visitorInterviewId) {
            visitorinterview vi = ctx.visitorinterviews.Find(visitorInterviewId);
            //ctx.visitorinterviews.del
            //ctx.SaveChanges();
            return true;
        }
    }
}
