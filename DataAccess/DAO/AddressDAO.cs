using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    public class AddressDAO
    {

        public bool AddAddress(string addressLine1, string addressLine2, int? cityId, int? stateId, string zip5, string zip4, int lastModifiedBy, int createdBy) {
            ChurchEntities ctx = new ChurchEntities();
            address a = ctx.addresses.Create();
            a.AddressLine1 = addressLine1;
            a.AddressLine2 = addressLine2;
            a.CityId = cityId;
            a.StateId = stateId;
            a.Zip5 = zip5;
            a.Zip4 = zip4;
            a.LastModified = DateTime.Now;
            a.LastModifiedBy = lastModifiedBy;
            a.CreatedDate = DateTime.Now;
            a.CreatedBy = createdBy;
            ctx.addresses.Add(a);
            ctx.SaveChanges();
            return true;
        }
    }
}
