using GameProject.Abstracts;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concretes
{
    class ICheckIfRealPersonManager : ICheckIfRealPerson
    {
        public bool Check(Gamer gamer)
        {
            return true;
        }
    }
}
