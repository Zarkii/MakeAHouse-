using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAHouse_
{
    
    class Room:Location
    {
        public String Decoration;
        public Room(String Name, String Decoration) : base(Name)
        {
            this.Decoration = Decoration;
        }

        public override string Description
        {
            get { return base.Description + "widzisz tutaj" + Decoration + "."; }
        }
    }

    class RoomWithDoor : Room,IHasExteriorDoor
    {
        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }

        public RoomWithDoor(string Name, string Decoration,string doorDescription) : base(Name, Decoration)
        {
           doorDescription = DoorDescription;
        }
    }
}
