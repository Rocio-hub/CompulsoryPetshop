using CompulsoryPetshop.Core.DomainService;
using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Data
{
    public static class Database 
    {

        public static List<Pet> petList;

        public static void InitData()
        {
            //petList.Add(new Pet()
            //{
            //    PetId = 1,
            //    PetName = "petname1",
            //    PetType = "pettype1",
            //    PetBirthDate = 23 / 04 / 2016,
            //    PetPrevOwner = someone1,
            //    PetColor = "petcolor1"
            //});

            //petList.Add(new Pet()
            //{
            //    PetId = 2,
            //    PetName = "petname2",
            //    PetType = "pettype2",
            //    PetBirthDate = 23 / 04 / 2016,
            //    PetPrevOwner = someone2
            //    PetColor = "petcolor2"
            //});
        }

        public static List<Pet> ReadPets()
        {
            return petList;
        }
    }
}