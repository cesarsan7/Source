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

	
	public partial class DGSWCFService : IDGSWCFService
	{


		#region Atributos

		/// <summary>
		/// Declaración e inicialización de objeto facade, el cual permitira hacer el llamado a los metodos 
		/// de la clase fachada, quien se encarga de interatuar con el servicio y el controlador de la aplicación
		/// </summary>
		private UserFacade objUserFacade = new UserFacade(); //object what allow call methods the agent the class Facade

		

		#endregion


		#region  Agent Methods

		

		#region Methods GET
		/// <summary>
		/// method what allows get  agent info
		/// </summary>
		/// <param name="agent"></param>
		/// <param name="idUser"></param>
		/// <returns></returns>
		public string usersGetIDService(string loginName)
		{

			return objUserFacade.usersGetIDFacade(loginName);

		}
	   
		#endregion Methods GET

	



		#endregion Agent methods

	}
}