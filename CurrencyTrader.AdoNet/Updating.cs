using CurrencyTrader.AdoNet;
using CurrencyTrader.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple.AdoNet
{
    class Updating : ITradeStorage
    {
        public void Persist(IEnumerable<TradeRecord> trades)
        {
            Task.Run(SynchTradeStorage.Persist(trades));
            
        }
    }
}
