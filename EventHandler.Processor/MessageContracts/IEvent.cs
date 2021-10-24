using EventHandler.Processor.EventInfoObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHandler.Processor.MessageContracts
{
    public interface IEvent<TInfo> where TInfo : IEventInfoObject
    {
        TInfo EventInfo { get; set; }
    }
}
