using DGSRestServices.Facade.Class;
using DGSRestServices.Model.Class;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private BookFacade objFacade = new BookFacade(); //object what allow call methods the agent the class Facade

       // public object Log4NetHelper { get; private set; }

        #endregion



        public string addBookService(BookModel bookModel)
        {
            return objFacade.addBookFacade(bookModel);
        }


       
    }
}