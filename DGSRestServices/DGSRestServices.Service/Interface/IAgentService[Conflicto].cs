using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Service
{
    
    /// <summary>
    /// method what allows get  agent info
    /// </summary>
    /// <param name="agent"></param>
    /// <param name="idUser"></param>
    /// <returns></returns>
    public partial interface IDGSWCFService : IDisposable
    {

        [OperationContract]
        [WebInvoke(UriTemplate = "agentGetInfoService",
            Method = "GET")]
        string agentGetInfoService(string agent, short idUser);

    }

   
   
}
