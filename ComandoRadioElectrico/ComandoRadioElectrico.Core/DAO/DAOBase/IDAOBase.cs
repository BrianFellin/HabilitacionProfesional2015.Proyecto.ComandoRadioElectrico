using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.DAO.DAOBase
{
    public interface IDAOBase<T> where T:class 
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEntityId"></param>
        /// <returns></returns>
        T GetById(int pEntityId);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEntity"></param>
        /// <returns></returns>
        void Create(T pEntity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEntity"></param>
        void Update(T pEntity);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pEntityId"></param>
        void Delete(int pEntityId);       

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();
    }
}
