using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IPlayerCheckService
    {
        bool CheckIfRealPerson(Player player);
    }
}
