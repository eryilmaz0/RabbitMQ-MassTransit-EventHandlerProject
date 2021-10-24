using EventHandler.Processor.EventInfoObjects;
using EventHandler.Processor.MessageContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.EventHandlers
{
    public interface IEventHandler<TEventInfo> where TEventInfo : IEventInfoObject
    {
        void ProcessEvent(TEventInfo eventInfo);
    }
}
