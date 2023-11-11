using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern.Implementations
{
    public class BitStorageUnitDisplayer:StorageUnitDisplayer
    {
        public override string Handle(double request)
        {
            if (request<8)
            {
                return $"{request} bits";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
