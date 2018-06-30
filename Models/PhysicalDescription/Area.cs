using System.Collections.Generic;

namespace GeviRpg.Models 
{
    public class Area 
    {
        public string Description { get; set; }
        public Dictionary<System.Enum, Area> Exits { get; set; }
        public Dimensions Size { get; set; }

        public Area() 
        {
            Description = "";
            Exits = new Dictionary<System.Enum, Area>();
        }

        public Area(string description) 
        {
            Description = description;
            Exits = new Dictionary<System.Enum, Area>();
        }

        public Area(string description, Dictionary<System.Enum, Area> exits) 
        {
            Description = description;
            Exits = exits;
        }
    }
}