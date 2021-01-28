using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class CampaignManager : ICampaignService
    {
        List<Campaign> campaigns = new List<Campaign>();
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya eklendi");
            campaigns.Add(campaign);
            Console.ReadLine();
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya silindi");
            campaigns.Remove(campaign);
            Console.ReadLine();
        }

        public void List()
        {
            Console.WriteLine("---- Campaigns-----");
            foreach (var campaign in campaigns)
            {
                Console.WriteLine(campaign.Id+" "+campaign.Name);
            }
        }

        public void Update(Campaign campaign1, Campaign campaign2)
        {
            Console.WriteLine("Kampanya güncellendi");
            campaigns.Remove(campaign1);
            campaigns.Add(campaign2); Console.ReadLine();
        }
        
    }
}
