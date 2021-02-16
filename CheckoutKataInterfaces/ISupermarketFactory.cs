using System;
using System.Collections.Generic;
using System.Text;

namespace CheckoutKataInterfaces
{
    public interface ISupermarketFactory
    {
        IStore Create(IStoreRepository storeRepository);
    }
}
