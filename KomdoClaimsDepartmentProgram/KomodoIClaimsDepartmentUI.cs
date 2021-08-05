using KomodoClaimsDepartmentUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomdoClaimsDepartmentProgram
{
    class KomodoIClaimsDepartmentUI
    {
        public KomodoClaimsDepartmentRepository _itemsRepo = new KomodoClaimsDepartmentRepository();
        public void Run()
        {
            SeedItemsList();
            StartupMenu();
        }
        private void StartupMenu()
        {
            bool keepRunning = true;
            while (keepRunning) 
            {


                Console.WriteLine("Select A Menu Option:\n" +
                    "1. See All Claims\n" +
                    "2. Take Care of Next Claim\n" +
                    "3. Enter A New Claim\n" +
                    "4. Exit");

                string input = Console.ReadLine();

                switch (input)
                {//Create
                    case "1":
                        DisplayAllClaims();
                        break;
                    //Read
                    case "2":
                        CreateNewClaims();
                        break;
                    //Read specific
                    case "3":
                        DisplayContentByClaimID();
                        break;
                    //Delete
                    case "4":
                        DeleteExistingItems();
                        break;
                    
                    default:
                        Console.WriteLine("Please enter a valid number.");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
}
        //Create
        private void CreateNewClaims()
        {
            Console.Clear();
            ClaimProperties newClaims = new ClaimProperties();

            //Claim #
            Console.WriteLine("Enter the Claim Number:");
            newClaims.ClaimID = Console.ReadLine();


            //Claim Type
            Console.WriteLine("Enter the Claim Type:");
            newClaims.TypeOfClaim = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the Description of the Claim:");
            newClaims.Description = Console.ReadLine();

            //Claim Amount 
            Console.WriteLine("Enter the the Claim Amount:");
            newClaims.ClaimAmount = Console.ReadLine();

            //Price
            Console.WriteLine("Enter the the Date of Accident:");
            newClaims.DateOfIncident = Console.ReadLine();

            //Date of Claim
            Console.WriteLine("Enter the the Date of Claim:");
            newClaims.DateOfClaim = Console.ReadLine();

            //Price
            Console.WriteLine("Is the Claim Valid?:");
            newClaims.IsValid = Console.ReadLine();

            _itemsRepo.AddItemsToClaims(newClaims);

        }

        //Read
        private void DisplayAllClaims()
        {
            Console.Clear();
            List<ClaimProperties> listofClaimProperties = _itemsRepo.GetListofClaimProperties();

            foreach (ClaimProperties items in listofClaimProperties)
            {
                Console.WriteLine($"ClaimID: {items.ClaimID}\n" +
                    $"Meal Number: {items.ClaimID}\n");
            }
        }
        //Read specific
        private void DisplayContentByClaimID()
        {
            Console.Clear();
            Console.WriteLine("Please enter the Claim ID you would like to see.");
            string ClaimID = Console.ReadLine();
            ClaimProperties items = _itemsRepo.GetContentByClaimID(ClaimID);

            if (items != null)
            {
                Console.WriteLine($"Claim ID: {items.ClaimID}\n" +
                    $"Type of Claim: {items.TypeOfClaim}\n" +
                    $"Description: {items.Description}\n" +
                    $"Claim Amount: {items.ClaimAmount}\n" +
                    $"Date of Incident: {items.DateOfIncident}\n" +
                    $"Date of Claim: {items.DateOfClaim}\n" +
                    $"Is Claim Valid?: {items.IsValid}");

            }

            else
            {
                Console.WriteLine("Nothing found by that Claim ID");
            }
        }

        private void UpdateExistingItems()
        {

        }
        //Delete
        private void DeleteExistingItems()
        {

            DisplayAllClaims();
            Console.WriteLine("\nEnter the claim ID you would like to delete.");

            string input = Console.ReadLine();
            bool wasDeleted = _itemsRepo.RemoveContentfromClaims(input);
            if (wasDeleted)
            {
                Console.WriteLine("Claim has been succesflly deleted.");
            }
            else
            {
                Console.WriteLine("Claim could not be deleted.");
            }
        }

        private void SeedItemsList()
        {
            ClaimProperties 1 = new ClaimProperties(1, ClaimType.Car, "Car accident on 465.", 400.00, 4 / 25 / 18, 4 / 27 / 18, true);
            ClaimProperties 2 = new ClaimProperties(2, ClaimType.Home, "House fire in kitchen.", 4000.00, 4 / 11 / 18, 4 / 12 / 18, true);
            ClaimProperties 3 = new ClaimProperties(3, ClaimType.Theft, "Stolen pancakes.", 4.00, 4 / 27 / 18, 6 / 01 / 18, false);
            ClaimProperties 4 = new ClaimProperties(4, , "", , , , , );
            

            _itemsRepo.AddItemsToClaims(1);
            _itemsRepo.AddItemsToClaims(2);
            _itemsRepo.AddItemsToClaims(3);
            _itemsRepo.AddItemsToClaims(4);
            
        }
