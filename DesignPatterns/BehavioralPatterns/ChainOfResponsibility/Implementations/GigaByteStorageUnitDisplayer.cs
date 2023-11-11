using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern.Implementations
{
    public class GigaByteStorageUnitDisplayer:StorageUnitDisplayer
    {
        public override string Handle(double request)
        {
            if (request.ToString().Length >= 10)
            {
                return $"{((request / 1000) / 1000)/1000} GB";
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
