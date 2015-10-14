﻿using DGSRestServices.Data;
using DGSRestServices.Facade.Class;
using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace DGSRestServices.Service
{

    [ServiceBehavior(AddressFilterMode = AddressFilterMode.Any)]
    public partial class DGSWCFService : IDGSWCFService
    {


        #region Atributos

        /// <summary>
        /// Declaración e inicialización de objeto facade, el cual permitira hacer el llamado a los metodos 
        /// de la clase fachada, quien se encarga de interatuar con el servicio y el controlador de la aplicación
        /// </summary>
        private AgentFacade objAgentFacade = new AgentFacade(); //object what allow call methods the agent the class Facade

        public object Log4NetHelper { get; private set; }

        #endregion



        #region  Agent Methods

        #region Methods PUT
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentModel"></param>
        public void  addAgent(AgentModel agentModel)
        { 


           
        }

        #endregion Methods PUT

        #region Methods GET
        /// <summary>
        /// method what allows get  agent info
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public string agentGetInfoService (string agent, string idUser)
        {

            return objAgentFacade.agentGetInfoFacade(agent, idUser  );
                
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="name"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public string agentFindListService(string agent, string name, string idUser)
        {
            //Converter idUser string to short 

             return objAgentFacade.agentFindListFacade( agent,  name,  idUser);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <param name="decimasl"></param>
        /// <param name="trunc"></param>
        /// <returns></returns>
        public string agentGetAgentsListService(string idAgent, string decimasl, string trunc)
        {
            return objAgentFacade.agentGetAgentsListFacade(idAgent, decimasl, trunc);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public string agentGetDistributorService(string idAgent)
        {
            return objAgentFacade.agentGetDistributorFacade( idAgent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pridAgent"></param>
        /// <returns></returns>
        public string agentGetInfoDistributorService(string pridAgent)
        {
            return objAgentFacade.agentGetInfoDistributorFacade(pridAgent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pridUser"></param>
        /// <returns></returns>
        public string agentGetListService(string pridUser)
        {
            return objAgentFacade.agentGetListFacade( pridUser);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idBook"></param>
        /// <returns></returns>
        public string agentGetListByBookService(string idBook)
        {
            return objAgentFacade.agentGetListByBookFacade(idBook);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public string agentGetNotesService(string idAgent)
        {
            return objAgentFacade.agentGetNotesFacade(idAgent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="Idagent"></param>
        /// <param name="decimals"></param>
        /// <param name="trunc"></param>
        /// <param name="idCurrency"></param>
        /// <returns></returns>
        public string agentGetPlayersListService(string Idagent, string decimals, string trunc, string idCurrency)
        {
            return objAgentFacade.agentGetPlayersListFacade( Idagent,  decimals,  trunc,  idCurrency);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public string agentGetPlayersIDService(string idAgent)
        {
            return objAgentFacade.agentGetPlayersIDFacade(idAgent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public string agentGetStatisticsService(string  idAgent)
        {
            return objAgentFacade.agentGetStatisticsFacade( idAgent);
        }

        public string agentLineTypesGetListService(string idAgent)
        {
            return objAgentFacade.agentLineTypesGetListFacade( idAgent);
        }

        public string agentLineTypesGetListAddedService(string idAgent)
        {
            return objAgentFacade.agentLineTypesGetListAddedFacade(idAgent);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string agentRightsGetListService()
        {
            return objAgentFacade.agentRightsGetListFacade();
        }
        #endregion Methods GET

        #region Methods POST
        #endregion Methods POST

        #region Methods DELETE
        #endregion Methods DELETE

        #endregion Agent methods

    }
}