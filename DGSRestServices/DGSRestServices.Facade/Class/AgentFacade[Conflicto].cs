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

        #region Methods GET
        /// <summary>
        /// allows for the information of the agent, which is sent as a parameter
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public string agentGetInfoFacade(string agent, short idUser)
        {

           
            try
            {
                //Add arguments to  list
                List<keyValue> lstParams = new List<keyValue>();
                lstParams.Add(new keyValue("agent", agent)); lstParams.Add(new keyValue("idUser", idUser));
                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);

                //get result 
                var resultController = objController.agentGetInfoController(agent, idUser);
                var result =controllerResponse(resultController, lstParams, method);

                return result;
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "Se presento una excepcion  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        /// <summary>
        /// allows get  a list  the information of the agents, according parameters sent
        /// </summary>
        /// <param name="agent"></param>
        /// <param name="name"></param>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public string agentFindListFacade(string agent, string name, short idUser)
        {
            try
            {
                var result = objController.agentFindListController(agent, name, idUser);
                if (result == null)
                {
                    responseOperation.messageID = 2;
                    Log4NetHelper.addLog(Log4NetHelper.levelLog.INFO, "La Consulta no arrojo resultados .");

                }

                object obj = new object[] { responseOperation, result };
                return JavaScriptSerializerHelper.GetString(obj);
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "Se presento una excepcion  .", exc);
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
        public string agentGetAgentsListFacade(int? idAgent, byte? decimasl, byte? trunc)
        {
            try
            {   
                var result = objController.agentGetAgentsListController(idAgent, decimasl, trunc);
                if (result == null)
                {
                    responseOperation.messageID = 2;
                    Log4NetHelper.addLog(Log4NetHelper.levelLog.INFO, "La Consulta no arrojo resultados .");

                }

                object obj = new object[] { responseOperation, result };
                return JavaScriptSerializerHelper.GetString(obj);
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "Se presento una excepcion  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }

        public string agentGetDistributorFacade(int idAgent)
        {
            try
            {
                var result = objController.agentGetDistributorController(idAgent);
                if (result == null)
                {
                    responseOperation.messageID = 2;
                    Log4NetHelper.addLog(Log4NetHelper.levelLog.INFO, "La Consulta no arrojo resultados .");

                }

                object obj = new object[] { responseOperation, result };
                return JavaScriptSerializerHelper.GetString(obj);
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "Se presento una excepcion  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
        }


        #endregion Methods GET


        /// <summary>
        /// 
        /// </summary>
        /// <param name="objResultController"></param>
        /// <param name="listParams"></param>
        /// <param name="method"></param>
        /// <returns></returns>
        public string controllerResponse ( object objResultController , List<keyValue> listParams,string method)
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
    }
}
