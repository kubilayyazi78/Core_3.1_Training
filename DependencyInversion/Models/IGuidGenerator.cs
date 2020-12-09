using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInversion.Models
{
   public interface IGuidGenerator
    {
        Guid Guid { get;}


    }

    public interface ISingletonGuid : IGuidGenerator
    {

    }

    public interface ITransientGenerator : IGuidGenerator
    {

    }

    public interface IScopedGenerator : IGuidGenerator
    {

    }
}
