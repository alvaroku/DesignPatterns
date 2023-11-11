using ChainOfResponsabilityPattern.Definitions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsabilityPattern.Implementations
{
    public class StorageUnitDisplayer : IStorageUnitDisplayer
    {
        private IStorageUnitDisplayer _nextHandler;

        public IStorageUnitDisplayer SetNext(IStorageUnitDisplayer handler)
        {
            this._nextHandler = handler;
            return _nextHandler;
        }

        public virtual string Handle(double request)
        {
            if (this._nextHandler != null)
            {
                return this._nextHandler.Handle(request);
            }
            else
            {
                return null;
            }
        }
    }
}
