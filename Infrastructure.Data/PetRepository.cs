using CompulsoryPetshop.Core.DomainService;
using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;

namespace Infrastructure.Data
{
    public class PetRepository : IPetRepository
    {
        private static List<Pet> _petList = new List<Pet>();

        public List<Pet> ReadPets()
        {
            return _petList;
        }

        public void InitData()
        {
            _petList.Add(new Pet()
            {
                PetId = 1,
                PetName = "Charlie",
                PetType = "cat",
                Price = 1,
                PetBirthDate = new DateTime(2016, 04, 23),
                PetPrevOwner = "Jimmy Simpson",
                PetColor = "black"
            });

            _petList.Add(new Pet()
            {
                PetId = 2,
                PetName = "Max",
                PetType = "cat",
                Price = 109,
                PetBirthDate = new DateTime(2018, 07, 05),
                PetPrevOwner = "Maxim Marsh",
                PetColor = "brown"
            });

            _petList.Add(new Pet()
            {
                PetId = 3,
                PetName = "Buddy",
                PetType = "dog",
                Price = 56,
                PetBirthDate = new DateTime(2017, 01, 29),
                PetPrevOwner = "Raylee Hill",
                PetColor = "grey"
            });

            _petList.Add(new Pet()
            {
                PetId = 4,
                PetName = "Coco",
                PetType = "bird",
                Price = 200,
                PetBirthDate = new DateTime(2019, 08, 16),
                PetPrevOwner = "Cedric Knight",
                PetColor = "white"
            });

            _petList.Add(new Pet()
            {
                PetId = 5,
                PetName = "Lucy",
                PetType = "dog",
                Price = 8000,
                PetBirthDate = new DateTime(2016, 02, 07),
                PetPrevOwner = "Gabby Mcdonald",
                PetColor = "black"
            });

            _petList.Add(new Pet()
            {
                PetId = 6,
                PetName = "Chloe",
                PetType = "horse",
                Price = 790,
                PetBirthDate = new DateTime(2015, 04, 02),
                PetPrevOwner = "Billie Doyle",
                PetColor = "grey"
            });

        }
    }
}
