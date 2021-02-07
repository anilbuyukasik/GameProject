using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1995 && gamer.FirstName == "ANIL" && gamer.LastName == "BÜYÜKAŞIK" && gamer.IdentityNumber == 50000000000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
