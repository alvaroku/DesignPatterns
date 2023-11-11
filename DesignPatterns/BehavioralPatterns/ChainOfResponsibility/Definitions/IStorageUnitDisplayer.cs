using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern.Definitions
{
    public interface IStorageUnitDisplayer
    {
        IStorageUnitDisplayer SetNext(IStorageUnitDisplayer handler);

        string Handle(double request);
    }
}
