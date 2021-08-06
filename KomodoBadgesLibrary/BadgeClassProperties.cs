using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadgesLibrary
{
    public abstract class BadgeClassProperties
    {
        //Properties
        public int ID { get; set; }
        public string Name { get; set; }

        //Constructors
        public BadgeClassProperties() { }
        public BadgeClassProperties(int, string)
        {
            ID = id;
            Name = name;
        }

        public class Door : BadgeClassProperties
        {
            //Properties
            public bool HasAccess { get; set; }

            //Constructors
            public Door() { }

            public Door(int id, string name, bool DoorAccess)
                : base(id, name)
            {
                HasAccess = DoorAccess;
            }
        }

        public class Badges : BadgeClassProperties
        {
            //Properties
            public List<Door> DoorName { get; set; }

            //Constructors
            public Badges() { }

            public Badges(List<Door> doorList, int id, string name)
                : base(id, name)
            {
                DoorName = doorList;
            }

            

            public bool AddBadges(List<Badges> BadgesToAddToDoorList)
            {
                if (BadgesToAddToDoorList.Count > 0)
                {
                    foreach (Badges badg in BadgesToAddToDoorList)
                    {
                        DoorName.Add(badg);
                    }
                    return true;
                }
                else
                {
                    DoorName = new List<Door>();
                    return false;
                }
            }

            public bool RemoveDoorById(int id)
            {
                var devToRemove = GetDoorById(id);
                if (devToRemove != null)
                {
                    DoorName.Remove(devToRemove);
                    return true;
                }
                return false;
            }

            //Private Helper Methods:
            private Door GetDoorById(int id)
            {
                foreach (var dev in DoorName)
                {
                    if (dev.ID == id)
                    {
                        return dev;
                    }
                }
                return null;
            }



        }
}
