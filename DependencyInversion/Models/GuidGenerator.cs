using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversion.Models
{
    public class GuidGenerator : ITransientGenerator, ISingletonGuid, IScopedGenerator
    {

        private Guid guid;
        public Guid Guid => guid;


        public GuidGenerator():this(Guid.NewGuid())
        {

        }

        public GuidGenerator(Guid guid)
        {
            this.guid = guid;
        }
    }
}
