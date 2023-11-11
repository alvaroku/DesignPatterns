using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern.Implementations
{
    public class KiloByteStorageUnitDisplayer:StorageUnitDisplayer
    {
        public override string Handle(double request)
        {
            if (request.ToString().Length<=6)
            {
                return $"{(request/1000)} KB";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
