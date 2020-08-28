using CompulsoryPetshop.Core.ApplicationService;
using CompulsoryPetshop.Core.ApplicationService.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CompulsoryPetshop.UI
{
    public class Printer
    {
        private IPetService _petService;

        public Printer(IPetService petService)
        {
            _petService = petService;
        }

        //Print menu items

        public int PrintMenuItems()
        {
            string[] menuItems =    {
                "Show list of pets",
                "Search pets by type",
                "Create a new pet",
                "Delete a pet",
                "Update a pet",
                "Show a list of all pets sorted by price",
                "Show the 5 cheapest pets",
                "Exit"
            };

            Console.WriteLine("Insert a number to select what you want to do: \n");

            for (int i = 0; i < menuItems.Length; i++)
            {
                Console.WriteLine($"{i + 1}: {menuItems[i]}");
            }
            Console.WriteLine("");

            int selection;
            while (!int.TryParse(Console.ReadLine(), out selection)
                || selection < 1 || selection > 8)
            {
                Console.WriteLine("Please, select a number between 1-8");
            }
            Console.WriteLine($"You selected: {selection}");

            return selection;
        }

        public void PrintByPrice(List<Pet> petList)
        {
            List<Pet> SortedList = petList.OrderBy(o => o.Price).ToList();

            foreach (var pet in SortedList)
            {
                Console.WriteLine(pet.PetName+" "+pet.Price);
            }
        }

        internal void UserLeaving()
        {
            Console.WriteLine("Bye bye!");
        }

        public void PrintFiveCheapest(List<Pet> petList)
        {
            List<Pet> SortedList = petList.OrderBy(o => o.Price).ToList();

            var cheapPetList = SortedList.Take(5);

            foreach (var pet in cheapPetList)
            {
                Console.WriteLine(pet.PetName + " " + pet.Price);
            }
        }

        //Print list of pets
        public void PrintListOfPets()
        {
            List<Pet> petList = _petService.GetPets();

            Console.WriteLine("List of pets: \n");
            foreach (var pet in petList)
            {
                Console.WriteLine(pet.PetName+"\n");
            }
        }

        public Pet PrintCreatePet()
        {
            Pet newPet = new Pet();
            Console.WriteLine("Insert name: ");
            newPet.PetName = Console.ReadLine();
            Console.WriteLine("Insert type: ");
            newPet.PetType = Console.ReadLine();
            Console.WriteLine("Insert birth date: ");
            //newPet.PetBirthDate = Console.ReadLine();
            Console.WriteLine("Insert sold date: ");
            //newPet.PetSoldDate = Console.ReadLine();
            Console.WriteLine("Insert color: ");
            newPet.PetColor = Console.ReadLine();
            Console.WriteLine("Insert previous owner: ");
            newPet.PetPrevOwner = Console.ReadLine();
            Console.WriteLine("Insert price: ");
            // newPet.Price = Console.ReadLine();

            return newPet;
        }

        public Pet PrintUpdatePet(Pet updatePet)
        {
            Console.WriteLine("Insert name: ");
            updatePet.PetName = Console.ReadLine();
            Console.WriteLine("Insert type: ");
            updatePet.PetType = Console.ReadLine();
            Console.WriteLine("Insert birth date: ");
            //newPet.PetBirthDate = Console.ReadLine();
            Console.WriteLine("Insert sold date: ");
            //newPet.PetSoldDate = Console.ReadLine();
            Console.WriteLine("Insert color: ");
            updatePet.PetColor = Console.ReadLine();
            Console.WriteLine("Insert previous owner: ");
            updatePet.PetPrevOwner = Console.ReadLine();
            Console.WriteLine("Insert price: ");
            // newPet.Price = Console.ReadLine();

            return updatePet;
        }

        public Pet PetFound(List<Pet> petList)
        {
            Console.WriteLine("Insert the ID of the pet");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Please, insert a valid value");
            }
            foreach (var pet in petList)
            {
                if (pet.PetId == id)
                {
                    return pet;
                }
            }
            return null;
        }

        public void FindPetByType(List<Pet> petList)
        {
            List<Pet> petByType = new List<Pet>(); 
            Console.WriteLine("Insert the type of the pet");
            int notALetter;
            var typeInserted = Console.ReadLine();
            while (int.TryParse(typeInserted, out notALetter))
            {
                Console.WriteLine("Please, insert a valid type");
                typeInserted = Console.ReadLine();
            }
            foreach (var pet in petList)
            {
                if (typeInserted.ToLower() == pet.PetType.ToLower())
                {
                    petByType.Add(pet);
                }
            }

            foreach (var petFound in petByType)
            {
                Console.WriteLine(petFound.PetName);
            }
            Console.WriteLine(" ");
        }
    }
}
