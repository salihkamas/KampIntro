using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GamerManager : IGamerService
    {
        //MicroService

        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true)
            {
                Console.WriteLine("User Added!");
            }
            else
            {
                Console.WriteLine("Error!");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer Deleted!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Gamer Updated!");
        }
    }
}
