using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfPrøveEksamen
{
    [ServiceContract]
    public interface IAuctionService
    {
        [OperationContract]
        List<Auction> GetAuctions();

        [OperationContract]
        Auction GetAuction(string ID);

        [OperationContract]
        string Bid(string ID, int price, string name, string phone);
    }
}
