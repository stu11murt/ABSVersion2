using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSDAL
{
    public class SourceRepository : GenericRepository<ABSEntities, Source>, ISourceRepository {

        public Source GetSingle(int sourceId)
        {
            var query = GetAll().FirstOrDefault(x => x.SourceId == sourceId);
            return query;
        }
    }
   
}
