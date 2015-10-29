using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Service
{
	public partial interface IDGSWCFService : IDisposable
	{
		#region Book methods 

		#region REST Methods


		#region POST 
		#endregion END POST

		#region PUT 
		#endregion END PUT

		#region GET 

		[OperationContract]
		[WebInvoke(Method = "GET",
		RequestFormat = WebMessageFormat.Json,
		ResponseFormat = WebMessageFormat.Json,
		UriTemplate = "usersGetID/{loginName}")]
		string usersGetIDService(string loginName);
		#endregion END GET

		#region DELETE 
		#endregion END DELETE

		#endregion //REST Methods
		#endregion //Book methods 

	}
}
