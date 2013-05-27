using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace CardsMultiplayer
{
    class ConnectionManager
    {
        int port = 5891;
        string HOST;
        TcpClient client;
        //TcpListener listener;

        public ConnectionManager(string host)
        {
            HOST = host;
        }

        public string sendSignal(string signal, bool response)
        {
            try
            {
                client = new TcpClient(HOST, port);
                if (!response) signal += ";noresponse=true";
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(signal);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                String responseData = "-1";
                if (response)
                {
                    data = new Byte[256];
                    Int32 bytes = stream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                }
                stream.Close();
                client.Close();
                return responseData;
            }
            catch
            {
                return "-1";
            }
        }

        public IPAddress GetIPAddress()
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip;
                }
            }
            return null;
        }
    }
}
