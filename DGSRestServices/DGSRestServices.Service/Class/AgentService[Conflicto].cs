using DGSRestServices.Data;
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
        private AgentFacade objAgentFacade = new AgentFacade();

        public object Log4NetHelper { get; private set; }

        #endregion
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="agentModel"></param>
        public void  addAgent(AgentModel agentModel)
        { 


           
        }

        /// <summary>
        /// method what allows get  agent info
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public string agentGetInfoService (string agent, short idUser)
        {

            return objAgentFacade.agentGetInfoFacade(agent, idUser);
                
        }

    }
}