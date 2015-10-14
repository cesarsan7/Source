using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace CDGSRestServices.Data
{
    /// <summary>
    /// Interfaz que implementa el patrón repositorio de microsoft.
    /// </summary>
    /// <typeparam name="TEntity">Entidad genérica del patrón repositorio.</typeparam>
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        /// <summary>
        /// Método que permite implementar un método que inserte un registro.
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        TEntity InsertarRegistro(TEntity entidad);

        /// <summary>
        /// Método que permite implementar un método que actualice un registro.
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        bool ActualizarRegistro(TEntity entidad);

        /// <summary>
        /// Método que permite implementar el método que elimina un registro.
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        bool EliminarRegistro(TEntity entidad);

        /// <summary>
        /// Método que permite implementar un método que permita filtar un registro de una entidad.
        /// </summary>
        /// <param name="criterioBusqueda">Criterio de búsqueda.</param>
        /// <returns></returns>
        TEntity ConsultarEntidad(Expression<Func<TEntity, bool>> criterioBusqueda);

        /// <summary>
        /// Método que permite implementar un método que permita consultar un listado de registros.
        /// </summary>
        /// <param name="criterioBusqueda">Criterio de búsqueda.</param>
        /// <returns></returns>
        List<TEntity> ConsultarInformacion(Expression<Func<TEntity, bool>> criterioBusqueda, bool top200);

        /// <summary>
        /// Método que retorna el total de registros de una tabla 
        /// </summary>
        /// <param name="criterioBusqueda"></param>
        /// <returns></returns>
        long ObtenerTotalRegistros(Expression<Func<TEntity, bool>> criterioBusqueda);
    }
}
