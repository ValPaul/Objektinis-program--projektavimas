using BombermanMultiplayer.Objects.Proxy;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombermanMultiplayer
{
    public class Client
    {
        private ITcpClient sender;

        public Client(string endPointIP, int endPointPort)
        {
            this.sender = new TcpClientProxy();
            this.sender.Connect(endPointIP, endPointPort);
        }

        public void SendData(Packet obj)
        {
            this.sender.SendData(obj);
        }

        public void ReceiveData(ref Packet obj)
        {
            this.sender.ReceiveData(ref obj);
        }

        public void Disconnect()
        {
            this.sender.Disconnect();
        }

        public bool GetConnectionState()
        {
            return this.sender.GetConnectionState();
        }
    }

}
