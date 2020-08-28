using CompulsoryPetshop.Core.DomainService;
using CompulsoryPetshop.UI;
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
                PetName = "petname1",
                PetType = "gato",
                Price = 1,
                // PetBirthDate = 23/04/2016,
                //PetPrevOwner = someone1,
                PetColor = "petcolor1"
            }) ;

            _petList.Add(new Pet()
            {
                PetId = 2,
                PetName = "petname2",
                PetType = "perro",
                Price = 109,
                // PetBirthDate = 23/04/2016,
                //PetPrevOwner = someone2
                PetColor = "petcolor2"
            });

            _petList.Add(new Pet()
            {
                PetId = 3,
                PetName = "petname3",
                PetType = "caballo",
                Price = 56,
                // PetBirthDate = 23/04/2016,
                //PetPrevOwner = someone1,
                PetColor = "petcolor3"
            });

            _petList.Add(new Pet()
            {
                PetId = 4,
                PetName = "petname4",
                PetType = "periquito",
                Price = 200,
                // PetBirthDate = 23/04/2016,
                //PetPrevOwner = someone1,
                PetColor = "petcolor1"
            });

            _petList.Add(new Pet()
            {
                PetId = 5,
                PetName = "petname5",
                PetType = "escorpion",
                Price = 8000,
                // PetBirthDate = 23/04/2016,
                //PetPrevOwner = someone2
                PetColor = "petcolor2"
            });

            _petList.Add(new Pet()
            {
                PetId = 6,
                PetName = "petname6",
                PetType = "caballo",
                Price = 790,
                // PetBirthDate = 23/04/2016,
                //PetPrevOwner = someone1,
                PetColor = "petcolor3"
            });

        }
    }
}
