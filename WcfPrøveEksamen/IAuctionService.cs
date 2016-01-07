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
        Auction GetAuction(string varenummer);

        [OperationContract]
        string Bid(string varenummer, int budpris, string kundenavn, string kundetelefon);
    }
}
