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
            new Auction() { Varenummer = "001", Varebetegnelse = "Test1", Vurdering = 100, BudPris = 0},
            new Auction() { Varenummer = "002", Varebetegnelse = "Test2", Vurdering = 200, BudPris = 100},
            new Auction() { Varenummer = "003", Varebetegnelse = "Test3", Vurdering = 300, BudPris = 50}
        };

        private object _auctionlock = new object();

        public string Bid(string varenummer, int budpris, string kundenavn, string kundetelefon)
        {
            var auctions = _auctions.ToList();

            lock (_auctionlock)
            {
                var auction = auctions.FirstOrDefault(x => x.Varenummer == varenummer);

                if (auction != null)
                {
                    if (budpris > auction.BudPris)
                    {
                        auction.BudPris = budpris;
                        auction.BudKundeNavn = kundenavn;
                        auction.BudKundeTelefon = kundetelefon;
                        auction.BudTidspunkt = DateTime.Now;

                        return "OK";
                    }
                    else
                    {
                        return "Bud for lavt";
                    }
                }
                else
                {
                    return "Vare findes ikke";
                }
            }
        }

        public Auction GetAuction(string varenummer)
        {
            var auctions = _auctions.ToList();

            lock (_auctionlock)
            {
                var auction = auctions.FirstOrDefault(x => x.Varenummer == varenummer);

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
