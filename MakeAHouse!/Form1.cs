using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakeAHouse_
{
    public partial class Form1 : Form
    {
        






        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            
            






        }

        public void CreateObjects()
        {
            RoomWithDoor livingRoom = new RoomWithDoor("salon", "antyczny dywan", "dębowe drzwi z mosiężną klamką");
            Room EatingRoom = new Room("jadalnia", "steampunkowy stól");
            RoomWithDoor Kitchen = new RoomWithDoor("kuchnia", "elektroniczna kuchenka", "szklane drzwi");
            OutsideWithDoor InFrontOfHouse = new OutsideWithDoor("podwórko przed domem", false);
            Outside garden = new Outside("ogrod", false);
            OutsideWithDoor BehindHouse = new OutsideWithDoor("za domem", true);

            InFrontOfHouse.Exits = new Location[]{BehindHouse,garden};
            garden.Exits = new Location[]{InFrontOfHouse,BehindHouse};
            BehindHouse.Exits = new Location[]{garden,InFrontOfHouse};
            livingRoom.Exits = new Location[]{InFrontOfHouse,EatingRoom};
            EatingRoom.Exits = new Location[]{Kitchen,livingRoom};
            Kitchen.Exits = new Location[]{BehindHouse,EatingRoom};

            CurrentLocation = livingRoom;





        }

        private void button1_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(CurrentLocation.Exits[Exits.SelectedIndex]);
        }

        void MoveToANewLocation(Location newLocation)
        {
            CurrentLocation = newLocation;
            Exits.Items.Clear();
            for (int i = 0; i < CurrentLocation.Exits.Length ; i++)
            {
                Exits.Items.Add(CurrentLocation.Exits[i].Name);
            }

            Exits.SelectedIndex = 0;
            Description.Text = CurrentLocation.Description;
            if (CurrentLocation is IHasExteriorDoor)
            {
                GoThroughTheDoor.Visible = true;
            }
            else
            {
                GoThroughTheDoor.Visible = false;

            }
        }
        Location CurrentLocation;

        private void GoThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor locationtogo = CurrentLocation as IHasExteriorDoor;
            MoveToANewLocation(locationtogo.DoorLocation);
        }
    }
}
