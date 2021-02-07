using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class SalesManager : ISalesService
    {
        public void Buy(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu" + game.GamePrice + " tutarındaki " + game.GameName + " adlı oyunu satın aldı.");
        }

        public void BuyWithCampaign(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + " adlı oyuncu" + game.GamePrice + " tutarındaki " + game.GameName + " adlı oyunu " + campaign.CampaignRate + " indirimle satın aldı.\nYeni Fiyat:" + (game.GamePrice / 100) * campaign.CampaignRate);
        }
    }
}
