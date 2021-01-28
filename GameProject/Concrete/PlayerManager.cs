using GameProject.Abstract;
using GameProject.Adapter;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    public class PlayerManager : IPlayerService
    {
        public MernisServiceAdapter _mernisServiceAdapter;
        List<Player> players = new List<Player>();
        public PlayerManager(MernisServiceAdapter mernisServiceAdapter)
        {
            _mernisServiceAdapter = mernisServiceAdapter;
        }
        public void Save(Player player) {
            if (_mernisServiceAdapter.CheckIfRealPerson(player))
            {
                Console.WriteLine("oyuncu eklendi"); players.Add(player);
            }
            else { throw new Exception("Not a valid person"); }
            Console.ReadLine();
        }
        public void Delete(Player player)
        {
            if (_mernisServiceAdapter.CheckIfRealPerson(player))
            {
                Console.WriteLine("oyuncu silindi");
                players.Remove(player);
            }
            else { throw new Exception("Not a valid person"); }
            Console.ReadLine();
        }
        public void Update(Player player)
        {
            if (_mernisServiceAdapter.CheckIfRealPerson(player))
            {
                Console.WriteLine("oyuncu guncellendi");
            }
            else { throw new Exception("Not a valid person"); }
            Console.ReadLine();
        }
        public void List()
        {
            Console.WriteLine("-----Players-----");
            foreach (var player in players)
            {
                Console.WriteLine(player.Id+" "+player.FirstName+" "+player.LastName+" "+player.NationalityId+" "+player.PhoneNumber);
            }
        }
    
    }
}
