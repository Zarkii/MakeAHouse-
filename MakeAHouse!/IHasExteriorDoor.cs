using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAHouse_
{
    interface IHasExteriorDoor
    {
        String DoorDescription { get; }
        Location DoorLocation { get; set; }


    }
}
