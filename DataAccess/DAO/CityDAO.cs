using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;

namespace DataAccess.DAO
{
    public class CityDAO
    {
        public List<CityDTO> GetCities() {
            ChurchEntities ctx = new ChurchEntities();
            var cities = (from c in ctx.cities 
                         select new CityDTO() { 
                             CityId = c.CityId,
                             CityName = c.CityName,
                             LastModified = c.LastModified,
                             LastModifiedBy = c.LastModifiedBy,
                             CreatedDate = c.CreatedDate,
                             CreatedBy = c.CreatedBy
                         });
            return cities.ToList();
        }
    }
}
