﻿/******************************************************************************
* Clase         : AgentController
* Objetivo      : Clase utilizada para definir el controlador del negocio de la tabla Agente
* Autor         :
* Fecha         : 21/10/2015
******************************************************************************/


using DGSRestServices.Data;
using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Controller.Class
{
    public class AgentController
    {

        #region Atributes 

        Repository<AGENT> objRespository;
        #endregion


        #region Vars
        #endregion 

        #region Method Constructor 

        public AgentController()
        {
            objRespository = new Repository<AGENT>();
        }
        #endregion 


        #region Method CRUD
        public void createAgent(AgentModel model)
        {
            Repository<AgentInsert> objInsert = new Repository<AgentInsert>();
            DGSDATAEntities entities = new DGSDATAEntities();
            try
            {

                object obj = new object();

                obj = entities.Agent_Insert(true, true, true, 1, 1.0, 1, 1, 1, 2.0, 3.0, 4.0, 3, 4, 2, 1, "", "name", "pass", "city", "state", "coontry", "addres1", "addres2", "email"
                    , "", "", "zip", true, "", obj);


                var result = entities.Agent_Insert(model.Enable,
                                                     model.DontXferPlayerActivity,
                                                     model.IsDistributor,
                                                     model.IdUser,
                                                     model.Makeup,
                                                     model.CommSports,
                                                     model.CommCasino,
                                                     model.CommHorses,
                                                     model.PerHeadSports,
                                                     model.PerHeadCasino,
                                                     model.PerHeadHorses,
                                                     model.IdAgentType,
                                                     model.IdCurrency,
                                                     model.IdBook,
                                                     model.IdGrouping,
                                                     model.Agent,
                                                     model.Name,
                                                     model.Password,
                                                     model.City,
                                                     model.State,
                                                     model.Country,
                                                     model.Address1,
                                                     model.Address2,
                                                     model.Email,
                                                     model.Phone,
                                                     model.Fax,
                                                     model.Zip,
                                                     model.OnlineAccess,
                                                     model.OnlineMessage,
                                                     null
                                                    );

            }
            catch (Exception exc)
            {
                throw;
            }

        }


        #region Methods GET
        /// <summary>
        /// allows for the information of the agent, which is sent as a parameter
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentGetInfoController(string agent, short idUser)
        {

            Repository<Agent_GetInfo_Result> objResult = new Repository<Agent_GetInfo_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_GetInfo(agent, idUser);

                if (lstEntity != null)
                {
                    var result = (from datos in lstEntity
                                  select new
                                  {
                                      Address1 = datos.Address1,
                                      Address2 = datos.Address2,
                                      Agent = datos.Agent,
                                      City = datos.City,
                                      CommCasino = datos.CommCasino,
                                      CommHorses = datos.CommHorses,
                                      CommSports = datos.CommSports,
                                      Country = datos.Country,
                                      Currency = datos.Currency,
                                      Distributor = datos.Distributor,
                                      DontXferPlayerActivity = datos.DontXferPlayerActivity,
                                      Email = datos.Email,
                                      Enable = datos.Enable,
                                      Fax = datos.Fax,
                                      IdAgent = datos.IdAgent,
                                      IdAgentType = datos.IdAgentType,
                                      IdBook = datos.IdBook,
                                      IdCurrency = datos.IdCurrency,
                                      IdGrouping = datos.IdGrouping,
                                      IdLineType = datos.IdLineType,
                                      IsDistributed = datos.IsDistributed,
                                      IsDistributor = datos.IsDistributor,
                                      LastModification = datos.LastModification,
                                      LastModificationUser = datos.LastModificationUser,
                                      Name = datos.Name,
                                      OnlineAccess = datos.OnlineAccess,
                                      OnlineMessage = datos.OnlineMessage,
                                      Password = datos.Password,
                                      PerHeadCasino = datos.PerHeadCasino,
                                      PerHeadHorses = datos.PerHeadHorses,
                                      PerHeadSports = datos.PerHeadSports,
                                      Phone = datos.Phone,
                                      State = datos.State,
                                      Symbol = datos.Symbol,
                                      Zip = datos.Zip
                                  }).ToList();

                    return result;
                }
                return null; 
            }
            catch
            {
                throw;
            }

        }
        
        /// <summary>
        /// allows get  a list  the information of the agents, according parameters sent
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="name"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentFindListController(string agent, string name,short idUser)
        {

            Repository<Agent_FindList_Result> objResult = new Repository<Agent_FindList_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_FindList(agent, name, idUser);

                if (lstEntity != null)
                {
                    var result = (from datos in lstEntity
                                  select new
                                  {
                                      Agent =datos.Agent,
                                      IdAgent=datos.IdAgent
                                  }).ToList();

                    return result;
                }
                return null;
            }
            catch
            {
                throw;
            }

        }

        /// <summary>
        /// allows get  a list  the information of the agents, according parameters sent
        /// </summary>
        /// <param name="idAgent"></param>
        /// <param name="decimasl"></param>
        /// <param name="trunc"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentGetAgentsListController (int? idAgent ,byte? decimasl, byte? trunc)
        {

            Repository<Agent_GetAgentsList_Result> objResult = new Repository<Agent_GetAgentsList_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_GetAgentsList(idAgent, decimasl, trunc);

                if (lstEntity != null)
                {
                    var result = (from datos in lstEntity
                                  select new
                                  {
                                      IdAgent=datos.IdAgent,
                                      LifeTimeNet=datos.LifeTimeNet,
                                      MakeUp=datos.MakeUp,
                                      PerHeadCasino=datos.PerHeadCasino,
                                      PerHeadHorses=datos.PerHeadHorses,
                                      PerHeadSportsdatos=datos.PerHeadSports 
                                  }).ToList();

                    return result;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// allows get  a list  the information of the Distributor agents, according parameters sent
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentGetDistributorController(int idAgent)
        {
            //
            Repository<Agent_GetDistributor_Result> objResult = new Repository<Agent_GetDistributor_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_GetDistributor(idAgent);

                if (lstEntity != null)
                {
                    var result = (from datos in lstEntity
                                  select new
                                  {
                                      Distributor=datos.Distributor,
                                      IsDistributor=datos.IsDistributor                                      
                                  }).ToList();

                    return result;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// allows get  a list  the information of the  distributors agents , according parameter idAgent sent 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentGetInfoDistributorController(int idAgent)
        {
            //
            Repository<Agent_GetInfoDistributor_Result> objResult = new Repository<Agent_GetInfoDistributor_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_GetInfoDistributor(idAgent);

                if (lstEntity != null)
                {
                    var result = (from datos in lstEntity
                                  select new
                                  {
                                      datos.Agent,
                                      datos.CommCasino,
                                      datos.CommHorses,
                                      datos.CommSports,
                                      datos.Distributor,
                                      datos.DontXferPlayerActivity,
                                      datos.Enable,
                                      datos.IdAgent,
                                      datos.IdAgentType,
                                      datos.IdBook,
                                      datos.IdCurrency,
                                      datos.IdDistributor,
                                      datos.IdGrouping,
                                      datos.IsDistributor,
                                      datos.PerHeadCasino,
                                      datos.PerHeadHorses,
                                      datos.PerHeadSports                                  
                                  }).ToList();

                    return result;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentGetListController(short idUser)
        {
            
            Repository<Agent_GetList_Result> objResult = new Repository<Agent_GetList_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_GetList(idUser);

                if (lstEntity != null)
                {
                    var result = (from data in lstEntity
                                  select new
                                  {
                                      data.Agent,
                                      data.AgentStatus,
                                      data.IdAgent,
                                      data.IdLineType  
                                  }).ToList();

                    return result;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// allows get  a list  the information of the  agents , according parameter idBook  
        /// </summary>
        /// <param name="idBook"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentGetListByBookController(short idBook)
        {

            Repository<Agent_GetListByBook_Result> objResult = new Repository<Agent_GetListByBook_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_GetListByBook(idBook);

                if (lstEntity != null)
                {
                    var result = (from data in lstEntity
                                  select new
                                  {
                                      Agent=data.Agent,
                                      IdAgent=data.IdAgent                                     
                                  }).ToList();

                    return result;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// It allows to obtain the notes associated with an agent
        /// </summary>
        /// <param name="idBook"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentGetNotesController(int idAgent)
        {

            Repository<Agent_GetNotes_Result> objResult = new Repository<Agent_GetNotes_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_GetNotes(idAgent);

                if (lstEntity != null)
                {
                    var result = (from data in lstEntity
                                  select new
                                  {
                                      IdAgent=data.IdAgent,
                                      Notes1=data.Notes1,
                                      Notes2=data.Notes2,
                                      Notes3=data.Notes3                                      
                                       
                                  }).ToList();

                    return result;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        /// <summary>
        /// allow get information the Statistic player associated a agent
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentGetPlayersListController(int Idagent, byte decimals, byte trunc, short idCurrency)
        {

            Repository<Agent_GetPlayersList_Result> objResult = new Repository<Agent_GetPlayersList_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_GetPlayersList(Idagent, decimals, trunc, idCurrency);

                if (lstEntity != null)
                {
                    var result = (from data in lstEntity
                                  select new
                                  {
                                      CreditLimit=data.CreditLimit,
                                      Currency=data.Currency,
                                      CurrentBalance=data.CurrentBalance,
                                      EnableCasino=data.EnableCasino,
                                      EnableHorses=data.EnableHorses,
                                      EnableSports=data.EnableSports,
                                      IdPlayer=data.IdPlayer,
                                      LastWager=data.LastWager,
                                      LifeTimeNet=data.LifeTimeNet,
                                      Name=data.Name,
                                      Player=data.Player,
                                      Status=data.Status,
                                      TotalCreditLimit=data.TotalCreditLimit,
                                      TotalCurrentBalance=data.TotalCurrentBalance
                                  }).ToList();

                    return result;
                }
                return null;
            }
            catch
            {
                throw;
            }
        }

        #endregion Methods GET
    }
}
 #endregion
