using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Model.Class
{
    public class BookModel
    {
        public short IdBook { get; set; }
        public string Description { get; set; }
        public int IdWebColumn { get; set; }
        public DateTime LastModification { get; set; }
        public short LastModificationUser { get; set; }

        #region Constructor 
        public BookModel ()
        {

        }
        #endregion
    }
}
