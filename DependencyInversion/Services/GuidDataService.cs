using DependencyInversion.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversion.Services
{
    public class GuidDataService
    {
        public ITransientGenerator transientGenerator;
        public IScopedGenerator scopedGenerator;
        public ISingletonGuid singletonGuid;

        public GuidDataService(ITransientGenerator transientGenerator , IScopedGenerator scopedGenerator, ISingletonGuid  singletonGuid)
        {
            this.transientGenerator = transientGenerator;
            this.scopedGenerator = scopedGenerator;
            this.singletonGuid = singletonGuid;
        }
    }
}
