using DGSRestServices.Common.Utilities;
using DGSRestServices.Controller.Class;
using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Facade.Class
{
    public class BookFacade
    {
        #region Atributes

        BookController objController;
        private MessageInfo responseOperation = null;
        #endregion

        #region Contructor

        public BookFacade()
        {
            objController = new BookController();
        }

        #endregion

        #region Methods POST 

        public string addAgentFacade(BookModel BookModel)
        {
            responseOperation = new MessageInfo();
            try
            {
                string method = string.Format("{0}.{1}", MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name);
                int res = 0;

                res = objController.addBookController(BookModel);

                DataMessage.ObtenerMensaje(responseOperation);
                responseOperation.MessageLog = " It was created on record [Book]";
                Log4NetHelper.addLog(Log4NetHelper.levelLog.INFO, string.Format(" It was created on record [Book] and return:", res));
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }
            catch (Exception exc)
            {
                responseOperation.messageID = 3;
                responseOperation.MessageLog = exc.ToString();
                DataMessage.ObtenerMensaje(responseOperation);
                Log4NetHelper.addLog(Log4NetHelper.levelLog.ERROR, "An exception is presented  .", exc);
                return JavaScriptSerializerHelper.GetString(new object[] { responseOperation, null });
            }

        }
        #endregion Methods POST
    }
}
