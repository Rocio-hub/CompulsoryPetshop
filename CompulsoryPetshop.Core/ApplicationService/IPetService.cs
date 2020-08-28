using CompulsoryPetshop.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace CompulsoryPetshop.Core.ApplicationService
{
    public interface IPetService
    {
        public List<Pet> GetPets();
    }
}
