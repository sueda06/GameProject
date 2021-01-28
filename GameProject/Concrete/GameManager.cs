using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GameManager :IGameService
    {
        public MernisServiceAdapter _mernisServiceAdapter;
        CampaignManager _campaignManager;
        public GameManager(MernisServiceAdapter mernisServiceAdapter, CampaignManager campaignManager)
        {
            _mernisServiceAdapter = mernisServiceAdapter;
            _campaignManager = campaignManager;
        }
        List<Game> games = new List<Game>();
        public void Add(Game game)
        {
            Console.WriteLine("Oyun eklendi");
            games.Add(game);
            Console.ReadLine();
        }

        public void Buy(Game game, Campaign campaign, Player player)
        {
            if (_mernisServiceAdapter.CheckIfRealPerson(player))
            {
                foreach (var item in _campaignManager.campaigns)
                {
                    foreach (var item2 in games)
                    {
                        if (campaign.Id == item.Id && game.Name== item2.Name)
                        {
                            Console.WriteLine(player.FirstName + " isimli oyuncu için " + game.Name + " oyununu satın aldınız \n" +
                        "Ödemeniz kampanya dahilinde " + (item2.Price - (item2.Price * item.DiscountRate)) + " TL");
                        }
                    }
                }
            }
            else { throw new Exception("Not a valid person"); }
        }

        public void Delete(Game game)
        {
            Console.WriteLine("Oyun silindi");
            games.Remove(game); Console.ReadLine();
        }

        public void List()
        {
            Console.WriteLine("---- Games-----");
            foreach (var game in games)
            {
                Console.WriteLine(game.Id + " " + game.Name+" "+game.Price);
            }
        }

        public void Update(Game game1, Game game2)
        {
            Console.WriteLine("Oyun güncellendi");
            games.Remove(game1);
            games.Add(game2); Console.ReadLine();
        }
    }
}
