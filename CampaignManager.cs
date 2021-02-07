using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign compaign)
        {
            Console.WriteLine(compaign.CampaignName + " kampanyası eklendi.");
        }

        public void Delete(Campaign compaign)
        {
            Console.WriteLine(compaign.CampaignName + " kampanyası silindi.");
        }

        public void Update(Campaign compaign)
        {
            Console.WriteLine(compaign.CampaignName + " kampanyası guncellendi.");
        }
    }
}
