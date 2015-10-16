using DGSRestServices.Controller.Class;
using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DGSRestServices.Common.Utilities;
using System.Reflection;

namespace DGSRestServices.Facade.Class
{
    public class AgentFacade
    {
        #region Atributes

        AgentController objController;
        private MessageInfo responseOperation = null;
        #endregion

        #region Contructor

        public AgentFacade ()
        {
            objController = new AgentController();
        }


        #endregion

       
        /// <summary>
        /// allows for the information of the agent, which is sent as a parameter
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public string agentGetInfoFacade(string agent, string idUser)
        {
            try
            {
                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("agent", agent)); lstParams.Add(new keyValue("idUser", idUser));
                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetInfoController(agent, short.Parse(idUser));
                var result =controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        #region Methods GET
        /// <summary>
        /// allows get  a list  the information of the agents, according parameters sent
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="name"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public string agentFindListFacade(string agent, string name, string idUser)
        {
            StringBuilder sbError = new StringBuilder();
           try
            {   

                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("agent", agent)); lstParams.Add(new keyValue("name", name)); lstParams.Add(new keyValue("idUser", idUser,true));

                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

              
                //get result 
                var resultController = objController.agentFindListController(agent, name, short.Parse(idUser));
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }

        }

        /// <summary>
        /// allows get  a list  the information of the agents, according parameters sent
        /// </summary>
        /// <param name="idAgent"></param>
        /// <param name="decimasl"></param>
        /// <param name="trunc"></param>
        /// <returns></returns>
        public string agentGetAgentsListFacade(string pridAgent, string prdecimasl, string prtrunc)
        {

            int idAgent;
            byte decimasl;
            byte trunc;

            try
            {

                bool residAgent = int.TryParse(pridAgent, out idAgent);
                bool resdecimals = byte.TryParse(prdecimasl, out decimasl);
                bool restrunc = byte.TryParse(prtrunc, out trunc);

                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idAgent", pridAgent)); lstParams.Add(new keyValue("decimasl", prdecimasl)); lstParams.Add(new keyValue("trunc", prtrunc));

                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetAgentsListController(idAgent, decimasl, trunc);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public string agentGetDistributorFacade(string pridAgent)
        {
            int idAgent;
            try
            {
               
                bool res = int.TryParse(pridAgent, out idAgent);
                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idAgent", idAgent)); 

                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetDistributorController(idAgent);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        /// <summary>
        /// Allow get info the agent distributor 
        /// </summary>
        /// <param name="idAgent">id agent</param>
        /// <returns>string whit info agent distributor</returns>
        public string agentGetInfoDistributorFacade(string  pridAgent)
        {
            int idAgent;
            try
            {
                bool res = int.TryParse(pridAgent, out idAgent); 
                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idAgent", idAgent));

                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetInfoDistributorController(idAgent);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        /// <summary>
        /// Allow get info the agent according a user id
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public string agentGetListFacade(string pridUser)
        {

            try
            {
                short idUser;
                bool res =short.TryParse(pridUser, out idUser);
                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idUser", idUser));

                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetListController( idUser);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }

        /// <summary>
        /// Allow get info the agent book  
        /// </summary>
        /// <param name="idBook"></param>
        /// <returns></returns>
        public string agentGetListByBookFacade(string prdidBook)
        {

            try
            {
                short idBook;

                bool res = short.TryParse(prdidBook, out idBook);
                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idBook", idBook));

                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetListByBookController(idBook);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }

        /// <summary>
        /// allow get info the agent notes
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public string agentGetNotesFacade(string  pridAgent)
        {

            try
            {
                int idAgent;
                bool res = int.TryParse(pridAgent, out idAgent);
                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idAgent", idAgent));

                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetNotesController(idAgent);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        /// <summary>
        /// allow get info the players agent , according params (idAgent, decimals, trunc, idCurrency)
        /// </summary>
        /// <param name="Idagent"></param>
        /// <param name="decimals"></param>
        /// <param name="trunc"></param>
        /// <param name="idCurrency"></param>
        /// <returns></returns>
        public string agentGetPlayersListFacade(string prIdagent, string prdecimals, string prtrunc, string pridCurrency)
        {

            int Idagent; byte decimals; byte trunc; short idCurrency;

            try
            {

                bool residAgent = int.TryParse(prIdagent, out Idagent);
                bool resdecimals = byte.TryParse(prdecimals, out decimals);
                bool restrunc = byte.TryParse(prtrunc, out trunc);
                bool resCurrency = short.TryParse(pridCurrency, out idCurrency);

                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idAgent", Idagent));
                lstParams.Add(new keyValue("decimals", decimals));
                lstParams.Add(new keyValue("trunc", trunc));
                lstParams.Add(new keyValue("idCurrency", idCurrency));

                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetPlayersListController(Idagent, decimals, trunc, idCurrency);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }

        /// <summary>
        /// Allow get info the palyers agent, according idagent.
        /// </summary>
        /// <param name="Idagent"></param>
        /// <returns></returns>
        public string agentGetPlayersIDFacade(string  pridAgent)
        {
            int idAgent;
            try
            {
                bool res = int.TryParse(pridAgent, out idAgent);
                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idAgent", idAgent));
           

                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetPlayersIDController( idAgent);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        /// <summary>
        /// Allow get stastistics the agent player game
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public string agentGetStatisticsFacade(string pridAgent)
        {

            try
            {
                int idAgent;
                bool res = int.TryParse(pridAgent, out idAgent);
                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idAgent", idAgent));


                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetStatisticsController( idAgent);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        /// <summary>
        /// Allow get info the agent Line type
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public string agentLineTypesGetListFacade(string pridAgent)
        {

            try
            {
                int idAgent;
                bool res = int.TryParse(pridAgent, out idAgent);

                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idAgent", idAgent));


                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentLineTypesGetListController( idAgent);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        /// <summary>
        /// Allow get info the agent Line type add
        /// </summary>
        /// <param name="idAgent"></param>
        /// <returns></returns>
        public string agentLineTypesGetListAddedFacade(string pridAgent)
        {

            try
            {
                int idAgent;
                bool res = int.TryParse(pridAgent, out idAgent);

                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("idAgent", idAgent));


                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentLineTypesGetListAddedcontroller( idAgent);
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string agentRightsGetListFacade()
        {

            try
            {
                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();

                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentRightsGetListController();
                var result = controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        #endregion Methods GET
        

        #region Methods PUT
        #endregion Methods PUT


        #region Methods POST
        #endregion Methods POST


        #region Methods DELETE
        #endregion Methods DELETE
        

        #region Private Methods


        /// <summary>
        /// Method to call the corresponding method of the controller class , as well as write to the execution log
        /// </summary>
        /// <param name="objResultController"></param>
        /// <param name="listParams"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public string controllerResponse(object objResultController, List<keyValue> listParams, string method)
        {

            string result = string.Empty;
            try
            {
                StringBuilder sbParams = new StringBuilder();
                responseOperation = new MessageInfo();

                foreach (var item in listParams)
                {
                    sbParams.AppendFormat(" Method :[{0}] - Params {1} = [{2}] \t ", method, item.key, item.value.ToString());

                }

                //Log parameters the method
                Log4NetHelper.addLog(Log4NetHelper.levelLog.DEBUG, sbParams.ToString());

                if (objResultController == null)
                {
                    Log4NetHelper.addLog(Log4NetHelper.levelLog.INFO, "result not found for request.");
                }

                else
                {
                    responseOperation.messageID = 1;
                    object obj = new object[] { responseOperation, objResultController };
                    DataMessage.ObtenerMensaje(responseOperation);
                    result = JavaScriptSerializerHelper.GetString(obj);
                }
            }

            catch (Exception ex)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, string.Format(" Method [{0}]. An exception is presented .", method), ex);
            }

            return result;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objResultController"></param>
        /// <param name="listParams"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public bool validateParams ( List<keyValue> listParams, string method)
        {

            foreach (var item in listParams)
            {
                //sbParams.AppendFormat(" Method :[{0}] - Params {1} = [{2}] \t ", method, item.key, item.value.ToString());
               if((item.validateObligatory) && (string.IsNullOrEmpty(item.value.ToString())))
                {   
                    //Escribir en el log
                    return false;
                }

            }
            return true;
        }
        #endregion Private Methods

    }
}
