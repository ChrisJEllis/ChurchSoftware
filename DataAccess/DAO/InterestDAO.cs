using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;

namespace DataAccess.DAO
{
    public class InterestDAO
    {
        ChurchEntities ctx = new ChurchEntities();
        public List<InterestDTO> GetInterests()
        {
            var i = (from c in ctx.interests
                      select new InterestDTO()
                          {
                              InterestId = c.InterestId,
                              InterestCode = c.InterestCode,
                              LastModified = c.LastModified,
                              LastModifiedBy = c.LastModifiedBy,
                              CreatedDate = c.CreatedDate,
                              CreatedBy = c.CreatedBy
                          });
            return i.ToList();
        }

        public int AddInterest(string interestCode) {
            var i = ctx.interests.Create();
            i.InterestCode = interestCode;
            i.LastModified = DateTime.Now;
            i.LastModifiedBy = 1;
            i.CreatedDate = DateTime.Now;
            i.CreatedBy = 1;
            ctx.interests.Add(i);
            ctx.SaveChanges();
            return i.InterestId;
        }
    }
}
