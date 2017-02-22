using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WcfPrøveEksamen
{
    [DataContract]
    public class AuctionService : IAuctionService
    {
        private static List<Auction> _auctions = new List<Auction>()
        {
            new Auction() { Id = "001", Description = "Test1", Rating = 100, },
            new Auction() { Id = "002", Description = "Test2", Rating = 200, Bid = new Bid() { Price = 100} },
            new Auction() { Id = "003", Description = "Test3", Rating = 300, Bid = new Bid() { Price = 50} },
        };

        /// Object for locking thread
        private readonly object _auctionlock = new object();

        public string Bid(string ID, int price, string name, string phone)
        {
            var auctions = _auctions.ToList();

            lock (_auctionlock)
            {
                var auction = auctions.FirstOrDefault(a => a.Id == ID);

                if (auction == null)
                {
                    return "ProductID doesn't exist";
                }

                if (auction.Bid.Price > price)
                {
                    return "Bid too low";
                }

                auction.Bid.Price = price;
                auction.Bid.Name = name;
                auction.Bid.Phone = phone;
                auction.Bid.Time = DateTime.Now;

                return "Bid placed";
            }
        }

        public Auction GetAuction(string ID)
        {
            var auctions = _auctions.ToList();

            lock (_auctionlock)
            {
                var auction = auctions.FirstOrDefault(a => a.Id == ID);

                return auction;
            }
        }

        public List<Auction> GetAuctions()
        {
            var auctions = _auctions.ToList();

            lock (_auctionlock)
            {
                return auctions;
            }
        }
    }
}
