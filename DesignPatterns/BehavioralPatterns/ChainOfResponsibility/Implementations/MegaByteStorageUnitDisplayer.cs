using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern.Implementations
{
    public class MegaByteStorageUnitDisplayer:StorageUnitDisplayer
    {
        public override string Handle(double request)
        {
            if (request.ToString().Length <= 9)
            {
                return $"{(request / 1000)/1000} MB";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
