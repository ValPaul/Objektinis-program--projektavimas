using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BombermanMultiplayer.Objects.Proxy
{
    public class TcpClientProxy : ITcpClient
    {
        private TcpClient client;
        private NetworkStream stream;
        private IFormatter formatter;

        public TcpClientProxy()
        {
            this.formatter = new BinaryFormatter();
        }

        public void Connect(string endPointIP, int endPointPort)
        {
            try
            {
                this.client = new TcpClient(endPointIP, endPointPort);
                this.stream = this.client.GetStream();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
                throw;
            }
        }

        public void SendData(Packet obj)
        {
            try
            {
                this.formatter.Serialize(this.stream, obj);
                this.stream.Flush();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error sending data: " + ex.Message);
                Disconnect();
                throw;
            }
        }

        public void ReceiveData(ref Packet obj)
        {
            try
            {
                while (this.stream.DataAvailable)
                {
                    obj = (Packet)this.formatter.Deserialize(this.stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error receiving data: " + ex.Message);
                Disconnect();
                throw;
            }
        }

        public void Disconnect()
        {
            this.client?.Close();
        }

        public bool GetConnectionState()
        {
            return this.client != null && this.client.Connected;
        }
    }
}
