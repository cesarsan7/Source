
using CDGSRestServices.Data;
using DGSRestServices.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DGSRestServices.Data
{
    /// <summary>
    /// Implementa los métodos del patrón repositorio.
    /// </summary>
    public class Repository<TEntidad> : IRepository<TEntidad> where TEntidad : class
    {
        DGSDATAEntities context = null;

        /// <summary>
        /// 
        /// </summary>
        private DbSet<TEntidad> EntitySet
        {
            get
            {
                return context.Set<TEntidad>();
            }
        }

        /// <summary>
        /// Constructor de la clase.
        /// </summary>
        public Repository()
        {
            context = new DGSDATAEntities();
            context.Configuration.ProxyCreationEnabled = false;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        public TEntidad InsertarRegistro(TEntidad entidad)
        {
            TEntidad resultado = null;
            try
            {
                EntitySet.Add(entidad);
                context.SaveChanges();
                resultado = entidad;
            }
            catch
            {
                //if (entidad is FichaDistribucion)
                throw;
            }
            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        /// <param name="count"></param>
        /// <param name="commitCount"></param>
        /// <param name="recreateContext"></param>
        /// <param name="lastEntity">Inidica que es el ultimo registro a insertar y debe hacer commit a la base de datos</param>
        public void AddEntityToContext(TEntidad entity, int count, int commitCount, bool recreateContext, bool lastEntity)
        {
            context.Set<TEntidad>().Add(entity);

            if ((count % commitCount == 0) || lastEntity)
            {
                context.SaveChanges();
                if (recreateContext)
                {
                    context.Dispose();
                    context = new DGSDATAEntities();
                    context.Configuration.AutoDetectChangesEnabled = false;
                }
            }

            //return context;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        public IEnumerable<TEntidad> InsertarRegistros(IEnumerable<TEntidad> lstentidad)
        {
            IEnumerable<TEntidad> resultado = null;
            try
            {
                EntitySet.AddRange(lstentidad);
                context.SaveChanges();
                resultado = lstentidad;
            }
            catch
            {
                // if (entidad is Empresa)
                resultado = null;
                throw;
            }
            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        public bool ActualizarRegistro(TEntidad entidad)
        {
            bool resultado = false;
            try
            {
                EntitySet.Attach(entidad);
                context.Entry<TEntidad>(entidad).State = EntityState.Modified;
                resultado = context.SaveChanges() > 0;
            }
            catch { }
            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        public bool EliminarRegistro(TEntidad entidad)
        {
            bool resultado = false;
            try
            {
                EntitySet.Attach(entidad);
                EntitySet.Remove(entidad);
                resultado = context.SaveChanges() > 0;
            }
            catch { }
            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        public bool EliminarRegistros(IEnumerable<TEntidad> lstEntidad)
        {
            bool resultado = false;
            //bool error     = false;
            try
            {
                foreach (TEntidad entidad in lstEntidad)
                {

                    //context.Entry<TEntidad>(entidad).State = EntityState.Deleted;
                    EntitySet.Attach(entidad);
                    EntitySet.Remove(entidad);
                    resultado = context.SaveChanges() > 0;
                    if (!resultado)
                    {
                        //break;
                        return false;
                    }



                }

            }
            catch { }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="criterioBusqueda"></param>
        /// <returns></returns>
        public TEntidad ConsultarEntidad(System.Linq.Expressions.Expression<Func<TEntidad, bool>> criterioBusqueda)
        {
            TEntidad resultado = null;
            try
            {
                resultado = EntitySet.FirstOrDefault(criterioBusqueda);
            }
            catch { }
            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criterioBusqueda"></param>
        /// <param name="top200">Indica si el resultado se retorna en un top 200</param>
        /// <returns></returns>
        public List<TEntidad> ConsultarInformacion(System.Linq.Expressions.Expression<Func<TEntidad, bool>> criterioBusqueda, bool top200 = true)
        {
            List<TEntidad> resultado = null;

            try
            {
                if (top200)
                    resultado = criterioBusqueda != null ? EntitySet.Where(criterioBusqueda).Take(200).ToList() : EntitySet.ToList();
                else
                    resultado = criterioBusqueda != null ? EntitySet.Where(criterioBusqueda).ToList() : EntitySet.ToList();


            }
            catch (Exception  e) { }
            return resultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TType">Tipo de dato por el cual se ordena la consulta</typeparam>
        /// <param name="criterioBusqueda"></param>
        /// <param name="orden"></param>
        /// <returns></returns>
        public List<TEntidad> ConsultarInformacionOrderDescendingBy<TType>(System.Linq.Expressions.Expression<Func<TEntidad, bool>> criterioBusqueda, System.Linq.Expressions.Expression<Func<TEntidad, TType>> orden)
        {
            List<TEntidad> resultado = null;

            try
            {
                resultado = criterioBusqueda != null ? EntitySet.Where(criterioBusqueda).Take(200).OrderByDescending(orden).ToList() : EntitySet.ToList();


            }
            catch { }
            return resultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="criterioBusqueda"></param>
        /// <returns></returns>
        public List<TEntidad> ConsultarInformacion(System.Linq.Expressions.Expression<Func<TEntidad, bool>> criterioBusqueda, int top)
        {
            List<TEntidad> resultado = null;

            try
            {
                resultado = criterioBusqueda != null ? EntitySet.Where(criterioBusqueda).Take(top).ToList() : EntitySet.Take(top).ToList();


            }
            catch { }
            return resultado;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="criterioBusqueda"></param>
        /// <returns></returns>
        public TEntidad ConsultarUltimoRegistroEntidad(System.Linq.Expressions.Expression<Func<TEntidad, bool>> criterioBusqueda)
        {
            TEntidad resultado = null;
            try
            {
                resultado = EntitySet.Where(criterioBusqueda).LastOrDefault();
            }
            catch { }
            return resultado;
        }

        /// <summary>
        /// Método que retorna la cantidad de registros de una consulta select 
        /// </summary>
        /// <param name="criterioBusqueda">Criterio de Busqueda</param>
        /// <param name="distinct">Indica si se debe contar los registros duplicados</param>
        /// <returns></returns>
        public long ObtenerTotalRegistros(System.Linq.Expressions.Expression<Func<TEntidad, bool>> criterioBusqueda, bool distinct = false)
        {
            long resultado = 0;
            try
            {
                if (!distinct)
                    resultado = EntitySet.Where(criterioBusqueda).Count();
                else
                    resultado = EntitySet.Where(criterioBusqueda).Distinct().Count();
            }
            catch { }
            return resultado;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="criterioBusqueda"></param>
        /// <returns></returns>
        public long ObtenerTotalRegistros(System.Linq.Expressions.Expression<Func<TEntidad, bool>> criterioBusqueda)
        {
            long resultado = 0;
            try
            {
                resultado = EntitySet.Where(criterioBusqueda).Count();
            }
            catch { }
            return resultado;
        }
        /// <summary>
        /// 
        /// </summary>
        public void Dispose()
        {
            if (context != null)
                context.Dispose();
        }
    }
}
