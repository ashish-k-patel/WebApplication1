using System.Collections.Generic;

namespace WebApplication1.Models
{
    public class Location
    {
        public Location()
        {
            ChildrenLocations = new List<Location>();
        }

        public string Name { get; set; }
        
        public List<Location> ChildrenLocations { get; set; }
    }
}
