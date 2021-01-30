﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1998 && gamer.FirstName == "Salih" && gamer.LastName == "Kamaş" && gamer.IdentityNumber == 11111111111) 
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
