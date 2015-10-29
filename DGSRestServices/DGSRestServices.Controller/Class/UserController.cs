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
    public class UserController
    {
		#region Atributes
		DGSDATAEntities entities = null;
		#endregion Atributes

		#region Properties
		#endregion Properties

		#region Method Constructor 

		/// <summary>
		/// Method constructor the class BookController
		/// </summary>
		public UserController()
		{
			entities = new DGSDATAEntities();
		}

		#endregion

		#region Methods CRUD 

		#region GET Methods 

		public void usersGetIDController(string loginName,  ref ObjectParameter prmIdUser)
		{

			//short idUser = -1;
			

			DGSDATAEntities entities = new DGSDATAEntities();

			try
			{
				 entities.Users_GetID(loginName, prmIdUser);
				// return idUser;
			}
                       
			catch
			{
				throw;
			}
			
		}
		#endregion  GET Methods 

		#region POST Methods 

		public int addUsersController(UserModel model, short IdUser)
		{
			int res = 0;
			res = entities.Users_Insert(model.IdUserProfile, model.IdDepartment, model.LoginName, model.Name, model.Password, model.Status, IdUser);
			return res;
		}
		#endregion  POST Methods 

		#region PUT Methods 

		public int updateUsersController(UserModel model, short IdUser)
		{
			int res = 0;
			res = entities.Users_Update(model.IdUser,model.IdUserProfile, model.IdDepartment, model.LoginName, model.Name, model.Password, model.Status, IdUser);
			return res;
		}

		#endregion  PUT Methods


		#region DELETE Methods 
		public int deleteUsersController(short idUser, short userId)
		{
			int res = 0;
			res = entities.Users_Delete(userId, idUser);
			return res;
		}

		#endregion  DELETE Methods

		#endregion Methods CRUD
	}
}
