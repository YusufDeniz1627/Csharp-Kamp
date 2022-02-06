using GameProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProjectDemo.Abstracts
{
    interface IValidateService
    {
        bool Validate(Gamer gamer);
    }
}
