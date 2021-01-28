using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IGameService
    {
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game1, Game game2);
        void Buy(Game game,Campaign campaign, Player player);
        void List();
    }
}

