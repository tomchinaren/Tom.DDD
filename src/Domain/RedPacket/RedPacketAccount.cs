using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.RedPacket
{
    class RedPacketAccount : IAggregateRoot
    {
        public double Balance { get; set; }
        public double FreezedBalance { get; set; }
    }
}
