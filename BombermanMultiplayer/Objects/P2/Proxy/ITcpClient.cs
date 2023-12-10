using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BombermanMultiplayer.Objects.Proxy
{
    public interface ITcpClient
    {
        void Connect(string endPointIP, int endPointPort);
        void SendData(Packet obj);
        void ReceiveData(ref Packet obj);
        void Disconnect();
        bool GetConnectionState();
    }
}
