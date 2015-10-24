using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Model.Class
{
    public class BookModel
    {
        short IdBook { get; set; }
        string Description { get; set; }
        int IdWebColumn { get; set; }
        DateTime LastModification { get; set; }
        DateTime LastModificationUser { get; set; }

        #region Constructor 
        public BookModel ()
        {

        }
        #endregion
    }
}
