using EventHandler.Processor.EventInfoObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.MessageContracts
{
    public class Event<TInfo> : IEvent<TInfo> where TInfo : IEventInfoObject
    {
        public TInfo EventInfo { get; set; }
    }
}
