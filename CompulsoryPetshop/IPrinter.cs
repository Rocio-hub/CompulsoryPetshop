using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.UI
{
    public interface IPrinter
    {
        int PrintMenuItems();
        void PrintByPrice(List<Pet> petList);
        void UserLeaving();
        void PrintFiveCheapest(List<Pet> petList);
        void PrintListOfPets();
        Pet PrintCreatePet();
        Pet PrintUpdatePet(Pet updatePet);
        void FindPetByType(List<Pet> petList);
        Pet PetFound(List<Pet> petList);

    }
}
