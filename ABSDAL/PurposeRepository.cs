using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSDAL
{
    public class PurposeRepository : GenericRepository<ABSEntities, Purpose>, IPurposeRepository {

        public Purpose GetSingle(int purposeId)
        {
            var query = GetAll().FirstOrDefault(x => x.PurposeId == purposeId);
            return query;
        }
    }
}
