using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSDAL
{
    public interface IVenueRepository : IGenericRepository<Venue>
    {
        Venue GetSingle(int venueId);
    }
}
