using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer
            {
                Id = 1,
                FirstName = "ANIL",
                LastName = "BÜYÜKAŞIK",
                BirthYear = 1995,
                IdentityNumber = 50000000000
            };
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidationManager());
            gamerManager.Add(gamer);

            Console.WriteLine("----------------------------------------------------------");

            Game game1 = new Game
            {
                GameId = 1,
                GameName = "Assassin's Creed",
                GamePrice = 279.99
            };
            Game game2 = new Game
            {
                GameId = 2,
                GameName = "The Forest",
                GamePrice = 39.99
            };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Add(game2);

            Console.WriteLine("----------------------------------------------------------");

            Campaign campaign1 = new Campaign
            {
                CampaignId = 1,
                CampaignName = "Black Friday",
                CampaignRate = 70
            };
            Campaign campaign2 = new Campaign
            {
                CampaignId = 2,
                CampaignName = "Kış indirimleri",
                CampaignRate = 60
            };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);

            Console.WriteLine("----------------------------------------------------------");

            SalesManager sales = new SalesManager();
            sales.Buy(game1, gamer);
            sales.BuyWithCampaign(game1, gamer, campaign1);
        }
    }
}
