using ChainOfResponsabilityPattern.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.BehavioralPatterns.ChainOfResponsibility
{
    public static class MainChainOfResponsability
    {
        public static void Start()
        {
            BitStorageUnitDisplayer bitStorage = new BitStorageUnitDisplayer();
            ByteStorageUnitDisplayer byteStorage = new ByteStorageUnitDisplayer();
            KiloByteStorageUnitDisplayer kiloByteStorage = new KiloByteStorageUnitDisplayer();
            MegaByteStorageUnitDisplayer megaByteStorage = new MegaByteStorageUnitDisplayer();
            GigaByteStorageUnitDisplayer gigaByteStorage = new GigaByteStorageUnitDisplayer();

            bitStorage.SetNext(byteStorage)
                .SetNext(kiloByteStorage)
                .SetNext(megaByteStorage)
                .SetNext(gigaByteStorage);

            Console.WriteLine(bitStorage.Handle(7));
            Console.WriteLine(bitStorage.Handle(32));
            Console.WriteLine(bitStorage.Handle(10000));
            Console.WriteLine(bitStorage.Handle(1000000));
            Console.WriteLine(bitStorage.Handle(1000000000));
        }
    }
}
