/******************************************************************************
* Clase         : AgentController
* Objetivo      : Clase utilizada para definir el controlador del negocio de la tabla Agente
* Autor         :
* Fecha         : 21/10/2015
*
******************************************************************************/


using DGSRestServices.Data;
using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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


        #region Methods POST
        /// <summary>
        /// Allow create a new agent
        /// </summary>
        /// <param name="model"> Objet type ModelAgent</param>
        /// <param name="prmOutIdAgent">New id agent record</param>
        /// <param name="prmOutResult">Result the process created</param>
        public void addAgentController(AgentModel model, ref ObjectParameter  prmOutIdAgent, ref ObjectParameter  prmOutResult)
        {

            int res = 0;
            Repository<AGENT> objInsert = new Repository<AGENT>();

            //Repository<AgentInsert> objInsert = new Repository<AgentInsert>();
            DGSDATAEntities entities = new DGSDATAEntities();
            try
            {

                res = entities.Agent_Insert(
                    model.Enable,
                    model.DontXferPlayerActivity, //prmDontXfer
                    model.IsDistributor,
                    model.IdUser,   // prmIdUser,
                    model.Distributor,
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
                    model.IdLineType,
                    prmOutIdAgent,
                    prmOutResult);

                   //object obj = new object[] { prmOutIdAgent, prmOutResult };

                //return obj;
            }
            catch 
            {
                throw;
            }

           
            
        }

        #endregion Methods POST

        #region Methods PUT 

        /// <summary>
        /// Allow update a record the agent
        /// </summary>
        /// <param name="model"></param>
        public int updateAgentController (AgentModel model)
        {
            int res = 0;
            DGSDATAEntities entities = new DGSDATAEntities();
            try
            {
                res = entities.Agent_Update(             
                               model.IdAgent ,
                               model.Enable ,
                               model.DontXferPlayerActivity,//prmDontXfer
                               model.IsDistributor ,
                               model.IdUser ,
                               model.Distributor ,
                               model.Makeup ,
                               model.CommSports ,
                               model.CommCasino ,
                               model.CommHorses ,
                               model.PerHeadSports ,
                               model.PerHeadCasino ,
                               model.PerHeadHorses ,
                               model.IdAgentType ,
                               model.IdCurrency ,
                               model.IdBook ,
                               model.IdGrouping ,
                               model.Agent ,
                               model.Name ,
                               model.Password ,
                               model.City ,
                               model.State ,
                               model.Country ,
                               model.Address1 ,
                               model.Address2 ,
                               model.Email ,
                               model.Phone ,
                               model.Fax ,
                               model.Zip ,
                               model.OnlineAccess,
                               model.OnlineMessage ,
                               model.IdLineType
               );
                return res;
            }
            catch
            {
                throw;
            }
            
        }
        #endregion Methods PUT 

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

        /// <summary>
        /// allows get player acording idagent
        /// </summary>
        /// <param name="Idagent"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentGetPlayersIDController(int Idagent)
        {

           // Repository<Agent_GetPlayers_Result> objResult = new Repository<Agent_GetPlayers_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_GetPlayersID(Idagent);

                if (lstEntity != null)
                {
                    var result = (from data in lstEntity
                                  select new
                                  {  
                                     data.Value
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
        /// All get the game Statistics
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentGetStatisticsController(int idAgent)
        {

            // Repository<Agent_GetPlayers_Result> objResult = new Repository<Agent_GetPlayers_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Agent_GetStatistics( idAgent);

                if (lstEntity != null)
                {
                    var result = (from data in lstEntity
                                  select new
                                  {
                                      AccountOpened=data.AccountOpened,
                                      CurrentBalance = data.CurrentBalance,
                                      IdAgent = data.IdAgent,
                                      LastModification = data.LastModification,
                                      LastModificationUser = data.LastModificationUser,
                                      LastWeek = data.LastWeek,
                                      LastWeekMakeUp = data.LastWeekMakeUp,
                                      LifeTimeComm = data.LifeTimeComm,
                                      LifeTimeLose = data.LifeTimeLose,
                                      LifetimeWin = data.LifetimeWin,
                                      MakeUp = data.MakeUp,
                                      ThisWeek = data.ThisWeek,
                                      YTDComm = data.YTDComm,                                     
                                      YTDWin = data.YTDWin
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
        /// Allow get  list the agent  Line types
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentLineTypesGetListController(int idAgent)
        {

            // Repository<Agent_GetPlayers_Result> objResult = new Repository<Agent_GetPlayers_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.AgentLineTypes_GetList(idAgent);

                if (lstEntity != null)
                {
                    var result = (from data in lstEntity
                                  select new
                                  {
                                      data.IdLineType,
                                      data.LineType
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
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public IEnumerable<dynamic> agentLineTypesGetListAddedcontroller(int idAgent)
        {

            // Repository<Agent_GetPlayers_Result> objResult = new Repository<Agent_GetPlayers_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.AgentLineTypes_GetListAdded(idAgent);

                if (lstEntity != null)
                {
                    var result = (from data in lstEntity
                                  select new
                                  {
                                      data.IdLineType,
                                      data.LineType
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
        /// <returns></returns>
        public IEnumerable<dynamic> agentRightsGetListController()
        {

            // Repository<Agent_GetPlayers_Result> objResult = new Repository<Agent_GetPlayers_Result>();
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.AgentRights_GetList();

                if (lstEntity != null)
                {
                    var result = (from data in lstEntity
                                  select new
                                  {
                                      Category=data.Category,
                                      Description=data.Description,
                                      IdForm=data.IdForm,
                                      IdRight=data.IdRight
                                  
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
        public void playerProfileInsert ()
        {
           // Repository<PlayerProfileBook_Insert> objResult = new Repository<PlayerProfileBook_Insert>();

        }
        #endregion Methods GET

        #region Methods DELETE
        /// <summary>
        /// Allow delete a record de Agent and 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public int deleteAgentController(int idAgent , short idUser)
        {
            int res = 0;
            DGSDATAEntities entities = new DGSDATAEntities();
            try
            {
                res = entities.Agent_Delete(idAgent, idUser);
               
                return res;
            }
            catch
            {
                throw;
            }
        }
        #endregion

    }
}
 #endregion
