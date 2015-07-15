using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComandoRadioElectrico.Core1.Servicios.Business.Interface
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
    }
}
