using CompulsoryPetshop.Core.ApplicationService;
using CompulsoryPetshop.Core.ApplicationService.Service;
using CompulsoryPetshop.Core.DomainService;
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace CompulsoryPetshop.UI
{
    public class Program
    {
       // static Printer printer;
        static List<Pet> petList;
        public static int id = 1;
        public static void Main(string[] args)
        {
            var petRepo = new PetRepository();
            petRepo.InitData();
            PetService _petService = new PetService(petRepo);
            petList = petRepo.ReadPets();

            var serviceCollection = new ServiceCollection();
            serviceCollection.AddScoped<IPetRepository, PetRepository>();
            serviceCollection.AddScoped<IPetService, PetService>();
            serviceCollection.AddScoped<IPrinter, Printer>();

            var serviceProvider = serviceCollection.BuildServiceProvider();
            var printer = serviceProvider.GetRequiredService<IPrinter>();
            var selection = printer.PrintMenuItems();
               
            //int selection = printer.PrintMenuItems();

            while (selection != 8)
            {
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        printer.PrintListOfPets();
                        break;
                    case 2:
                        Console.Clear();
                        printer.FindPetByType(petList);
                        break;
                    case 3:
                        Console.Clear();
                        Pet newPet = printer.PrintCreatePet();
                        newPet.PetId = petList.Count+1;
                        petList.Add(newPet);
                        break;
                    case 4:
                        Console.Clear();
                        var petFound = printer.PetFound(petList);
                        if (petFound != null)
                        {
                            petList.Remove(petFound);
                        }
                        break;
                    case 5:
                        Console.Clear();
                        var pet = printer.PetFound(petList);
                        if (pet != null)
                        {
                            petFound = printer.PrintUpdatePet(pet);
                        }
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
    }
}
