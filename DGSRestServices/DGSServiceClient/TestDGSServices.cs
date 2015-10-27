using DGSRestServices.Facade.Class;
using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DGSServiceClient
{
    public class TestDGSServices
    {        
        public static void Main(string[] args)
        {
            #region AgentModel
            AgentModel objModel = new AgentModel();
            objModel.IdAgent = 10013;
            objModel.IdCurrency = 328;
            objModel.IdBook = 607;
            objModel.Agent = "SaLoSanchez";
            objModel.IdAgentType = 254;
            objModel.IdGrouping = 742;
            objModel.Distributor = 596;
            objModel.Password = "L1YTHHQ6J";
            objModel.Enable = false;
            objModel.Name = "SaLoSanchez";
            objModel.Address1 = "CARVAJAL SANTA MONICA";
            objModel.Address2 = "CARVAJAL SANTA MONICA";
            objModel.City = "Cali";
            objModel.State = "Valle del cauca";
            objModel.Country = "Colombia";
            objModel.Zip = "760001";
            objModel.Phone = "3113585328";
            objModel.Fax = "3113585328";
            objModel.Email = "SaLoSanchez@hotmail.com";
            objModel.IsDistributor = true;
            objModel.CommSports = 167;
            objModel.CommCasino = 39;
            objModel.CommHorses = 166;
            objModel.PerHeadSports = 0;
            objModel.PerHeadCasino = 1473147;
            objModel.PerHeadHorses = 10000;
            objModel.OnlineAccess = true;
            objModel.OnlineMessage = "Message";
            //objModel.LastModification = "2015-11-06 17:54:51";
            objModel.LastModificationUser = 2;
            objModel.IdLineType = 131;
            #endregion
            
            //stDGSServices.DGSService.
            DGSServiceClient.DGSService.DGSWCFServiceClient objDGSServiceClient = new DGSService.DGSWCFServiceClient();

            BookModel objModelBook = new BookModel();
            objModelBook.Description = "TEST";
            objModelBook.IdWebColumn = 4;
            objModelBook.LastModificationUser = 2;

            objDGSServiceClient.addAgentService(objModel);

            BookFacade BookFacade1 = new BookFacade();
            BookFacade1.addBookFacade(objModelBook);



            //const string WEBSERVICE_URL = "http://localhost:16687/DGSWCFService.svc/addBook";

            //string jsonData = "{ \"key1\" : \"value1\", \"key2\":\"value2\"  }";
            //try
            //{
            //    var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
            //    if (webRequest != null)
            //    {
            //        webRequest.Method = "POST";
            //        webRequest.Timeout = 20000;
            //        webRequest.ContentType = "application/json";

            //        using (System.IO.Stream s = webRequest.GetRequestStream())
            //        {
            //            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(s))
            //                sw.Write(jsonData);
            //        }

            //        using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
            //        {
            //            using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
            //            {
            //                var jsonResponse = sr.ReadToEnd();
            //                System.Diagnostics.Debug.WriteLine(String.Format("Response: {0}", jsonResponse));
            //            }
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    System.Diagnostics.Debug.WriteLine(ex.ToString());
            //}






            //DGSServiceClient.DGSService.DGSWCFServiceClient objDGSServiceClient = new DGSService.DGSWCFServiceClient();

            //var result = objDGSServiceClient.agentGetInfoService("LUFKIN", "2");

        }
    }

   
}
