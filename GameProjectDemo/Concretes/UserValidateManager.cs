using GameProjectDemo.Abstracts;
using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Concretes
{
    class UserValidateManager : IValidateService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Name=="Yusuf" && gamer.LastName=="Deniz")
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
