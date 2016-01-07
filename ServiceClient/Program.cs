using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using ServiceClient.AuctionService;

namespace ServiceClient
{
    class Program
    {
        static void Main(string[] args)
        {
            AuctionService.AuctionServiceClient auctionservice = new AuctionServiceClient();

            Console.WriteLine("Velkommen til Patrick's Auktion");

            bool running = true;
            while (running)
            {
                Console.WriteLine("For at se alle auktioner igang, tryk 1");
                Console.WriteLine("For at finde en bestemt vare, tryk 2");
                Console.WriteLine("For at give et bud, tryk 3");
                Console.WriteLine("For at afslute, tryk Q");

                string input = Console.ReadLine();

                if (input == "1")
                {
                    var auctions = auctionservice.GetAuctions().ToList();

                    foreach (var auction in auctions)
                    {
                        Console.WriteLine("Auction: #"+auction.Varenummer+" \n "+auction.Varebetegnelse+" - $"+auction.BudPris);
                    }
                }
                else if (input == "2")
                {
                    Console.WriteLine("Skriv varenummeret for at finde auktionen");
                    string auctioninput = Console.ReadLine();

                    var auction = auctionservice.GetAuction(auctioninput);

                    if (auction != null)
                    {
                        Console.WriteLine("Auction: #" + auction.Varenummer + " \n " + auction.Varebetegnelse + " - $" + auction.BudPris + " ("+auction.BudKundeNavn+")");
                    }
                    else
                    {
                        Console.WriteLine("Kunne ikke finde auktion - går tilbage til menu");
                    }
                }
                else if (input == "3")
                {
                    Console.WriteLine("Skriv et varenummer du vil byde på");
                    string varenummerinput = Console.ReadLine();

                    Console.WriteLine("Skriv det bud du vil afgive på auktionen");
                    string offerinput = Console.ReadLine();

                    int offer = 0;
                    int.TryParse(offerinput, out offer);

                    if (offer > 0)
                    {
                        Console.WriteLine("Skriv venligst dit navn");
                        string consumername = Console.ReadLine();

                        Console.WriteLine(".. og dit nummer");
                        string consumernumber = Console.ReadLine();

                        string answer = auctionservice.Bid(varenummerinput, offer, consumername, consumernumber);

                        // Her kunne man have en switch med de forskellige svar der kom og så håndtere dem for brugeren
                        Console.WriteLine(answer);
                    }
                    else
                    {
                        Console.WriteLine("Bud ikke gyldigt - går tilbage til menuen");
                    }
                }
                else if (input == "Q")
                {
                    Console.WriteLine("Tak fordi du brugte Patrick's auktionshus");
                    running = false;
                }
                else
                {
                    Console.WriteLine("Kommando ikke forstået - prøv igen");
                }
            }

            Console.ReadKey();
        }
    }
}
