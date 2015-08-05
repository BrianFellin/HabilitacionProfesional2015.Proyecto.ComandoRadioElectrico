using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComandoRadioElectrico.Core.Services.Interfaces;

namespace ComandoRadioElectrico.Core.Services.Implementations
{
    public class BaseService
    {   
        public T Resolve<T>()
        {
            return CoreServerModuleImpl.UnityContainer.Resolve<T>();
        }

        public IDataSession GetSession()
        {
            return this.Resolve<IDataSession>();
        }
    }
}
