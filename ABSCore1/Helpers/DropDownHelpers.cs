using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Web;
using ABSDAL;
using ABSCore1.Models;

namespace ABSCore1.Helpers
{
    public static class DropDownHelpers
    {

        public static IEnumerable<Source> GetSources()
        {   
            
            return GetSourcesData(new SourceRepository());
        }

        public static IEnumerable<Source> GetSourcesData(SourceRepository gp)
        {

            List<Source> sources = gp.GetAll().ToList();
            
            // add in please select option
            Source sb = new Source();
            sb.SourceType = "- Please Select -";
            sb.SourceId = 0;
            sources.Insert(0, sb);
            return sources;
        }


        public static IEnumerable<Venue> GetVenues()
        {

            return GetVenueData(new VenueRepository());
        }

        public static IEnumerable<Venue> GetVenueData(VenueRepository vp)
        {

            List<Venue> venues = vp.GetAll().ToList();

            // add in please select option
            Venue vb = new Venue();
            vb.VenueType = "- Please Select -";
            vb.VenueId = 0;
            venues.Insert(0, vb);
            return venues;
        }
    }
}