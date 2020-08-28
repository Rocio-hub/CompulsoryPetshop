using System;

namespace CompulsoryPetshop.UI
{
    public class Pet
    {
        public int PetId  { get; set; }
        public string PetName { get; set; }
        public string PetType { get; set; }
        public DateTime PetBirthDate { get; set; }
        public DateTime PetSoldDate { get; set; }
        public string PetColor { get; set; }
        public string PetPrevOwner { get; set; }
        public double Price { get; set; }

    }
}
