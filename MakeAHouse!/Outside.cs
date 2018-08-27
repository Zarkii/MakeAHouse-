using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAHouse_
{
    class Outside:Location
    {
        private bool hot;
        public Outside(string name,bool hot) : base(name)
        {
            this.hot = hot;
        }

        public override string Description
        {
            get
            {
                if (hot)
                {
                    return "goraco tu";
                }
                else
                {
                    return "jest tu calkiem chlodno";
                    
                }
            }

        }
    }

    class OutsideWithDoor : Outside,IHasExteriorDoor
    {
        public string DoorDescription { get; }
        public Location DoorLocation { get; set; }

        public OutsideWithDoor(string name, bool hot) : base(name, hot)
        {
        }
    }
}
