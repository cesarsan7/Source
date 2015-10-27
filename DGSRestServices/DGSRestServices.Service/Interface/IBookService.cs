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
    /// 
    /// </summary>
    public partial interface IDGSWCFService : IDisposable
    {


        #region Book methods 

        #region REST Methods


        #region POST 
        [WebInvoke(Method = "POST", UriTemplate = "Books")]
        [OperationContract]
        string addBookService(BookModel bookModel);

        #endregion END POST

        #region PUT 
        #endregion END PUT

        #region GET 
        #endregion END GET

        #region DELETE 
        #endregion END DELETE

        #endregion //REST Methods
        #endregion //Book methods 
    }
}
