using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess.DTO;

namespace DataAccess.DAO
{
    public class StateDAO
    {
        public List<StateDTO> GetStates() {
            ChurchEntities ctx = new ChurchEntities();
            var states = (from s in ctx.states
                         select new StateDTO()
            {
                StateId = s.StateId,
                StateName = s.StateName,
                LastModified = s.LastModified,
                LastModifiedBy = s.LastModifiedBy,
                CreatedDate = s.CreatedDate,
                CreatedBy = s.CreatedBy
            });
            return states.ToList();
        }
    }
}
