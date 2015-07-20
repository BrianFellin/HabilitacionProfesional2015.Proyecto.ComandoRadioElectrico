
using System.Collections.Generic;
namespace ComandoRadioElectrico.Core.Servicios.Business.Interface
{
    public interface ICRUDBase<T> where T:class 
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
        T Create(T pEntity);

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
