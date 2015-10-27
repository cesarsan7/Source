/******************************************************************************
* Clase         : BookController
* Objetivo      : Class used to define the controller board business book
* Autor         :
* Fecha         : 21/10/2015
*
******************************************************************************/


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
    public class BookController
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
        public BookController()
        {
             entities = new DGSDATAEntities();
        }

        #endregion

        #region Methods CRUD 

        #region GET Methods 

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idUser"></param>
        /// <returns></returns>
        public IEnumerable<BookModel> getBookGetList(short idUser)
        {
                        
            DGSDATAEntities entities = new DGSDATAEntities();

            try
            {
                var lstEntity = entities.Book_GetList(idUser);
                
                if (lstEntity != null)
                {

                    var result = (from data in lstEntity
                                  select new BookModel
                                  {
                                      IdBook = data.IdBook,
                                      Description = data.BookName
                                  }).ToList();                   

                    return result;
                }
                return null;
            }
            catch
            {
                throw;
            }

        }
        #endregion  GET Methods 

        #region POST Methods 

        public int addBookController (BookModel model)
        {
            int res = 0;
            res = entities.Book_Insert(model.Description, model.IdWebColumn, model.LastModificationUser);
            return res;
        }
        #endregion  POST Methods 

        #region PUT Methods 
        #endregion  PUT Methods


        #region DELETE Methods 
        #endregion  DELETE Methods

        #endregion Methods CRUD

    }
}
