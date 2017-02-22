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
            new Program().Run();
        }

        private static AuctionServiceClient _auctionService;

        public void Run()
        {
            // Reference: Service References > AuctionService (Discovered from WcfPrøveEksamen project (Service)
            _auctionService = new AuctionServiceClient();

            Console.WriteLine("Welcome to Patrick's Auctions");

            bool running = true;
            while (running)
            {
                Console.WriteLine("To see all current auctions, press 1");
                Console.WriteLine("To see specific auction, press 2");
                Console.WriteLine("To offer on a product, press 3");
                Console.WriteLine("To (q)uit, press q");

                var input = Console.ReadLine();

                switch (input?.ToLower())
                {
                    case "1":
                        PrintAllAuctions();
                        break;
                    case "2":
                        PrintAllProducts();
                        break;
                    case "3":
                        BidOnProduct();
                        break;
                    case "q":
                        Console.WriteLine("Thanks for using Patrick's Auctionhouse");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Command not understood");
                        break;
                }
            }
        }

        private static void PrintAllAuctions()
        {
            var auctions = _auctionService.GetAuctions().ToList();

            foreach (var auction in auctions)
            {
                Console.WriteLine($"Auction: #{auction.Id}\n{auction.Description}\n${auction.Bid.Price}\n");
            }
        }

        private static void PrintAllProducts()
        {
            Console.WriteLine("Write the product ID you want to find");
            var auctioninput = Console.ReadLine();

            var auction = _auctionService.GetAuction(auctioninput);

            if (auction != null)
            {
                Console.WriteLine($"Auction: #{auction.Id}\n{auction.Description}\n${auction.Bid.Price}");
            }
            else
            {
                Console.WriteLine("Couldn't find the auction - Going back to the menu");
            }
        }

        private static void BidOnProduct()
        {
            Console.WriteLine("Write a auction ID you want to do a bid on");
            var varenummerinput = Console.ReadLine();

            Console.WriteLine("Write the price you'd like to bid");
            var offerinput = Console.ReadLine();

            var offer = 0;
            int.TryParse(offerinput, out offer);

            if (offer > 0)
            {
                Console.WriteLine("Please write your name");
                var consumername = Console.ReadLine();

                Console.WriteLine("... and your phone number");
                var consumernumber = Console.ReadLine();

                var answer = _auctionService.Bid(varenummerinput, offer, consumername, consumernumber);

                Console.WriteLine(answer);
            }
            else
            {
                Console.WriteLine("Bid not valid - going back to the menu");
            }
        }
    }
}
