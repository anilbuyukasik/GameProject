using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ICampaignService
    {
        void Add(Campaign compaign);
        void Update(Campaign compaign);
        void Delete(Campaign compaign);
    }
}
