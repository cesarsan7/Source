using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DGSRestServices.Common.Utilities
{
    public static class DataMessage
    {
        // Methods
        public static bool ObtenerMensaje(MessageInfo message)
        {
            Func<XElement, bool> predicate = null;
            bool flag;
            XDocument document = null;
            try
            {
                document = XDocument.Load(MessageManagerSettings.GetInstance().PathDataMessage);
                if (predicate == null)
                {
                    predicate = p => p.Element("MessageID").Value == message.MessageID.ToString();
                }
                MessageInfo mensaje2 = (from p in document.Elements("DataMessage").Elements<XElement>("MessageInfo").Where<XElement>(predicate) select new MessageInfo { MessageID = Convert.ToInt32(p.Element("MessageID").Value), MessageDescription = p.Element("MessageDescription").Value, MessageLog = p.Element("MessageLog").Value, Success = Convert.ToBoolean(p.Element("Success").Value) }).DefaultIfEmpty<MessageInfo>((from q in document.Elements("DataMessage").Elements<XElement>("MessageInfo")
                                                                                                                                                                                                                                                                                                                                                                                                                 where q.Element("MessageID").Value == "0"
                                                                                                                                                                                                                                                                                                                                                                                                                 select new MessageInfo { MessageID = Convert.ToInt32(q.Element("MessageID").Value), MessageDescription = q.Element("MessageDescription").Value, MessageLog = q.Element("MessageLog").Value, Success = Convert.ToBoolean(q.Element("Success").Value) }).FirstOrDefault<MessageInfo>()).FirstOrDefault<MessageInfo>();
                message.MessageID = mensaje2.MessageID;
                message.MessageDescription = mensaje2.MessageDescription;
                message.MessageLog = mensaje2.MessageLog;
                message.Success = mensaje2.Success;
                flag = true;
            }
            catch (Exception exception)
            {
                message.MessageID = -10001;
                message.MessageDescription = exception.Message;
                message.MessageLog = (exception.InnerException != null) ? exception.InnerException.ToString() : exception.Message;
                message.Success = false;
                flag = false;
            }
            finally
            {
                document = null;
            }
            return flag;
        }

        public static MessageInfo ObtenerMensaje(int MessageID)
        {
            MessageInfo message = new MessageInfo
            {
                MessageID = MessageID
            };
            ObtenerMensaje(message);
            return message;
        }
    }




}
