using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeAHouse_
{
    abstract class Location
    {
        public String Name { get; private set; }

        public Location(string name)
        {
            Name = name;
        }

        public Location[] Exits;

        public virtual string Description
        {
            get
            {
                string description = "stoisz w: " + Name + "widzisz wyjscia do nastepujacych lokacji: ";
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;

                    if (i != Exits.Length - 1)
                        description += ",";



                }

                description += ".";
                return description;
            }
       

}
    }
}
