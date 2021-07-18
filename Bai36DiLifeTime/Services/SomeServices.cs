using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bai36DiLifeTime.Services
{
    public class SomeServices : ITransientService, IScopedService, ISingletonService
    {
        Guid _id;
        public SomeServices()
        {
            _id = Guid.NewGuid();
        }
       
        public Guid GetID()
        {
            return _id;
        }
    }
}
