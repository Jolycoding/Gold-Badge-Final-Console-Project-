using KomodoBadgesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomodoBadges
{
    class KomodoBadgesUI
    {
        private KomodoBadgesRepository BadgesRepo = new KomodoBadgesRepository();
        
        
        private Dictionary<int, string> BadgesOnTeam = new Dictionary<int, string>();

        //UI Run Method
        public void Run()
        {
            SeedContent();
            Menu();
        }

        //Menu Methods
        private void Menu()
        {
            bool keepGoing = true;
            while (keepGoing)
            {
                Console.Clear();
                Console.WriteLine("Main Menu\n" +
                    "Hello Security Admin! What would you like to do?\n" +
                    "1. Add a badge.\n" +
                    "2. Edit a badge.\n" +
                    "3. List all Badges.\n" +
                    "4. Delete All Door Access for a Badge.\n" +
                    "5. Exit the application.\n");

                string optionChosen = Console.ReadLine();

                Console.Clear();
                switch (optionChosen)
                {
                    case "1":
                        AddBadge();
                        break;
                    case "2":
                        EditBadge();
                        break;
                    case "3":
                        ListBadges();
                        break;
                    case "4":
                        DeleteAllDoorAccess();
                        break;
                    case "5":
                        Console.WriteLine("Make it a GREAT day at Komodo Insurance!\n" +
                            "Press any key to exit ...");
                        Console.ReadKey();
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine("You did not select a valid option. Please select an option by the number of the option.");
                        break;
                }
            }
        }

       
                {
                    //Add a new Badge
                    case "1":
                        AddBadge badgeToAdd = new Badge();

                        Console.WriteLine("Please provide the number on the badge.");
                        int newDevID = GetUserInputAsInt();
                        badgeToAdd.ID = newbadgeID;

                        Console.WriteLine("List a door that it needs access to.");
                        DoorToAdd.Name = Console.ReadLine();


                        Console.WriteLine("Any other doors? Y/N");
                        string userResponse = Console.ReadLine().ToUpper();

                        if (userResponse == "Y")
                        {
                            BadgeToAdd.HasAccess = true;
                        }
                        else
                        {
                            BadgeToAdd.HasAccess = false;
                        }

                        Door.AddDoorToRepository(DoorToAdd);
                        Console.WriteLine("The door has been added.");

                        PressAnyKeyToContinue();
                        break;

 //Edit A Badge
                    case "2":
                        Console.WriteLine("Please provide the ID of the badge you'd like to update.\n");
PrintBadgesInRepo();

int adminToUpdateId = GetUserInputAsInt();

if (!BadgeRepo.RepositoryContainsObject(adminToUpdateId))
{
    Console.WriteLine("A badge with that id doesn't exist.");
    PressAnyKeyToContinue();
    break;
}

Badge originalBadge = (Badge)BadgeRepo.GetBadgeClassPropertuesById(adminToUpdateId);

Badge newBAdge = new Badge(originalBadge.ID, originalDeveloper.Name, originalBadge.HasAccess);

Console.WriteLine("Would you like to update the badge ID? Y/N");
string userReply = Console.ReadLine().ToUpper();
if (userReply == "Y")
{
    Console.WriteLine("What is the new ID for the badge?");

    int newID = GetUserInputAsInt();
    if (newID == 0)
    {
        Console.WriteLine("Sorry but the provided value was not a value that can be used as an ID.");
    }
    else
    {
        newBadge.ID = newID;

        if (BadgeinRepo.ContainsKey(adminToUpdateId))
        {
            UpdateBadgeIdInDictionary(adminToUpdateId, newID);
        }
    }
}

                    

                    //View List of All Badges
                    case "3":
                        ListBadgesInRepo();

                        PressAnyKeyToContinue();
                        break;

                        

                   

                        Console.WriteLine("Would you like to update the badge's door access? Y/N");
                        string userReplyTwo = Console.ReadLine().ToUpper();
                        if (userReplyTwo == "Y")
                        {
                            Console.WriteLine("List a door that it needs access to.");
                            newDoor.Name = Console.ReadLine();
                        }

                        Console.WriteLine($"The user's current door access is set to {originalBadge.HasAccess}\n" +
                            $"Would you like to update badge's door access? Y/N");
                        string userReplyThree = Console.ReadLine().ToUpper();
                        if (userReplyThree == "Y")
                        {
                            newBadge.HasAccess = newBadge.HasAccess ? false : true;
                            Console.WriteLine($"Update access to {newDoor.HasAccess}");
                        }

                      

                    //Delete All Doors from an Existing Badge
                    case "4":
                        Console.WriteLine("Please select a badge ID that you would like to remove all door access to.\n");
                           
                        PrintBadgesInRepo();

                        int badgeToRemoveDoors = GetUserInputAsInt();
                        Badge doorsToRemove = (BadgeID)BadgeRepo.GetBadgeClassPropertiesById(Badges[idToRemoveDoor]);

                        if (doorsToRemove != null)
                        {
                            if (doorsToRemove.ContainsKey(badgeToRemoveDoors))
                            {
                                int Badge = BadgeID[doorsRemove.ID]; 
                                DevelopmentTeam devsDevelopmentTeam = DevTeamRepo.GetDevelopmentTeamById(badgeId); 
                                badgeDoorAcccess doorAcccess.RemoveDoorsById(doorsRemoveId); 
                                bool doorUpdate = DevTeamRepo.UpdateDoorAccessById(badgeId, doorAcccess); 
                                if (doorUpdate)
                                {
                                    Console.WriteLine($"Door access {doorAcccess.Name} has been removed from the Badge ID: {devsDevelopmentTeam.Name}.");
                                }
                            }
                            

                    
                    //Return to menu
                    case "5":
                        Console.WriteLine("Make it a GREAT day at Komodo Insurance!\n" +
                            "Press any key to exit ...");
                        Console.ReadKey();
                        keepGoing = false;
                            break;
                        default:
                        Console.WriteLine("You did not select a valid option. Please select an option by the number of the option.");
                            break;
                }
            }
        }

        

        //Helper Methods
        private void PressAnyKeyToContinue()
        {
            Console.WriteLine("\n" +
                "Press any key to continue ...");
            Console.ReadKey();
        }

        private void SeedContent()
        {
            //Badges Created
            Badge Green = new Badge(1, "A5, A7", true);
            Badge Yellow = new Badge(2, "A3, A2", true);
            Badge Red = new Badge(3, "B5", true);
            

            //Add Badges to Repo
            Badge.AddObjectToRepository(Green);
            Badge.AddObjectToRepository(Yellow);
            Badge.AddObjectToRepository(Red);
            

            
        

        //Dictionary Helper Methods
        private void UpdateBadgeIdInDictionary(int ID, int newID)
        {
            int Badge = Badge[ID];
            Badge.Add(newID, Badge);
            Badge.Remove(ID);
        }

        private int GetUserInputAsInt()
        {
            int returnValue = 0;
            bool keepGoing = true;
            while (keepGoing)
            {
                string userInput = Console.ReadLine();
                try
                {
                    returnValue = int.Parse(userInput);
                }
                catch
                {
                    returnValue = 0;
                }
                if (returnValue == 0)
                //Input isn't valid so continue.
                {
                    Console.Clear();
                    Console.WriteLine("Please provide a valid number for the response.");
                }
                else
                //else stop
                {
                    keepGoing = false;
                }
            }
            return returnValue;
        }


    }
}
