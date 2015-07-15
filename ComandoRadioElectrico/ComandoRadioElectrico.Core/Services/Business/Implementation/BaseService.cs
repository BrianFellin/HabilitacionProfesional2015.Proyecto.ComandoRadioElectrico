using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComandoRadioElectrico.Core.Services.Business.Implementation
{
    public abstract class BaseService
    {
        public T Resolve<T>()
        {
            return ImplementationsContainer.UnityContainer.Resolve<T>();
        }
        
    }
}
