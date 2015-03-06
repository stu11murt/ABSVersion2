using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSDAL
{
    public class VenueRepository : GenericRepository<ABSEntities, Venue>, IVenueRepository 
    {
        public Venue GetSingle(int venueId)
        {
            var query = GetAll().FirstOrDefault(x => x.VenueId == venueId);
            return query;
        }
    }
}
