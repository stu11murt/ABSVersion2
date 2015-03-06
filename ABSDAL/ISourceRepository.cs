using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSDAL
{
    public interface ISourceRepository : IGenericRepository<Source>
    {
        Source GetSingle(int sourceId);
    }
}
