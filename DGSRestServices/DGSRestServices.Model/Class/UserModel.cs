using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Model.Class
{
	public class UserModel
	{
		public short IdUser { get; set; }
		public short IdUserProfile { get; set; }
		public  int IdDepartment { get; set; } = 1; //default 1
		public string LoginName { get; set; }     // not null
		public string Name { get; set; }
		public string Password { get; set; }     // not null
		DateTime LastLogin { get; set; }
		public bool Status { get; set; }
		public short Type { get; set; } = 0;
		public DateTime LastModification { get; set; }
		public short LastModificationUser { get; set; }
	}
}
