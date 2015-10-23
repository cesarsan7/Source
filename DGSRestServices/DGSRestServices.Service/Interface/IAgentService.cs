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


        #region Agent methods 

        #region Methods GET

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        /// 
        [OperationContract]
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "agentInfo/{agent}/{idUser}")]
        string agentGetInfoService(string agent, string idUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="name"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "agentFindList/{agent}/{name}/{idUser}")]
        string agentFindListService(string agent, string name, string idUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <param name="decimasl"></param>
        /// <param name="trunc"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
           RequestFormat = WebMessageFormat.Json,
           ResponseFormat = WebMessageFormat.Json,
           UriTemplate = "agentGetAgentsList/{idAgent}/{decimasl}/{trunc}")]
        string agentGetAgentsListService(string idAgent, string decimasl, string trunc);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          UriTemplate = "agentGetDistributor/{idAgent}")]
        string agentGetDistributorService(string idAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "agentGetInfoDistributor/{idAgent}")]
        string agentGetInfoDistributorService(string idAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pridUser"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "agentGetList/{pridUser}")]
        string agentGetListService(string pridUser);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idBook"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "agentGetListByBook/{idBook}")]
        string agentGetListByBookService(string idBook);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "agentGetNotes/{idAgent}")]
        string agentGetNotesService(string idAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Idagent"></param>
        /// <param name="decimals"></param>
        /// <param name="trunc"></param>
        /// <param name="idCurrency"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "agentGetPlayersList/{Idagent}/{decimals}/{trunc}/{idCurrency}")]
        string agentGetPlayersListService(string Idagent, string decimals, string trunc, string idCurrency);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "agentGetPlayersID/{idagent}")]
        string agentGetPlayersIDService(string idAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "agentGetStatistics/{idagent}")]
        string agentGetStatisticsService(string idAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "agentLineTypesGetList/{idagent}")]
        string agentLineTypesGetListService(string idAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "agentLineTypesGetListAdded/{idagent}")]
        string agentLineTypesGetListAddedService(string idAgent);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [OperationContract]
        [WebInvoke(Method = "GET",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        UriTemplate = "agentRightsGetList")]
        string agentRightsGetListService();

        #endregion Methods GET

        #region Methods POST

        [OperationContract]
        [WebInvoke(Method = "POST",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        UriTemplate = "addAgent")]
        string addAgentService(AgentModel agentModel);


        #endregion Methods POST

        #region Methods PUT

        [OperationContract]
        [WebInvoke(Method = "PUT",
        ResponseFormat = WebMessageFormat.Json,
        RequestFormat = WebMessageFormat.Json,
        UriTemplate = "updateAgent")]
        string updateAgentService(AgentModel agentModel);

        #endregion Methods PUT

        #region Methods DELETE

     
        [WebInvoke(Method = "DELETE", UriTemplate = "deleteAgent/{idAgent}/{idUser}")]
        [OperationContract]
        string deleteAgentService(string idAgent, string idUser);

        #endregion Methods DELETE

        #endregion Agent methods 

    }



}
