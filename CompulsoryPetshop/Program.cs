using CompulsoryPetshop.Core.ApplicationService;
using CompulsoryPetshop.Core.ApplicationService.Service;
using CompulsoryPetshop.Core.DomainService;
using Infrastructure.Data;
using System;
using System.Collections.Generic;

namespace CompulsoryPetshop.UI
{
    public class Program
    {
        static int id = 1;

        static Printer printer;

        static List<Pet> petList;
        public static void Main(string[] args)
        {
            var petRepo = new PetRepository();
            petRepo.InitData();
            PetService _petService = new PetService(petRepo);
            printer = new Printer(_petService);

            petList = petRepo.ReadPets();

            int selection = printer.PrintMenuItems();

            while (selection != 8)
            {
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        printer.PrintListOfPets(); //DONE
                        break;
                    case 2:
                        Console.Clear();
                        printer.FindPetByType(petList); //DONE
                        break;
                    case 3:
                        Console.Clear();
                        CreatePet(); //DONE
                        break;
                    case 4:
                        Console.Clear();
                        DeletePet(); //DONE
                        break;
                    case 5:
                        Console.Clear();
                        UpdatePet(); //DONE?
                        break;
                    case 6:
                        Console.Clear();
                        printer.PrintByPrice(petList); //DONE
                        break;
                    case 7:
                        Console.Clear();
                        printer.PrintFiveCheapest(petList); //DONE
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                selection = printer.PrintMenuItems();
            }
            printer.UserLeaving();
        }

        private static void UpdatePet()
        {
            var petFound = printer.PetFound(petList);
            if (petFound != null)
            {
                petFound = printer.PrintUpdatePet(petFound);
            }
        }

        private static void DeletePet()
        {
            var petFound = printer.PetFound(petList);
            if (petFound != null)
            {
                petList.Remove(petFound);
            }
        }

        private static void CreatePet()
        {
            Pet newPet = printer.PrintCreatePet();
            newPet.PetId = id++;
            petList.Add(newPet);
        }
    }
}
