using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface ISalesService
    {
        void Buy(Game game, Gamer gamer);
        void BuyWithCampaign(Game game, Gamer gamer, Campaign campaign);
    }
}
