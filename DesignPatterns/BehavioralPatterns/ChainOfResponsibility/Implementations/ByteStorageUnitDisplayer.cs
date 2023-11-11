using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern.Implementations
{
    public class ByteStorageUnitDisplayer:BitStorageUnitDisplayer
    {
        public override string Handle(double request)
        {
            if (request.ToString().Length<=3)
            {
                return $"{request/8} B";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
