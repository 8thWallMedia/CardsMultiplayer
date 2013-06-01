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

        public void sendSignal(Object StateObject) //For async stuff
        {
            SignalState state = StateObject as SignalState;
            try
            {
                if (state != null)
                {
                    client = new TcpClient(HOST, port);
                    string signal = state.command;
                    if (!state.returnResult) signal += ";noresponse=true";
                    Byte[] data = System.Text.Encoding.ASCII.GetBytes(signal);
                    NetworkStream stream = client.GetStream();
                    stream.Write(data, 0, data.Length);
                    String responseData = "-1";
                    if (state.returnResult)
                    {
                        data = new Byte[256];
                        int bytes = stream.Read(data, 0, data.Length);
                        responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                    }
                    stream.Close();
                    client.Close();
                    state.eventWaitHandle.Set();
                }
            }
            catch (SocketException SE)
            {
                state.result = SE.ErrorCode;
                state.eventWaitHandle.Set();
            }
            catch
            {
                state.result = -1;
                state.eventWaitHandle.Set();
            }
        }

        public int sendSignal(string signal, bool returnresult) //For async stuff
        {
            try
            {
                client = new TcpClient(HOST, port);
                if (!returnresult) signal += ";noresponse=true";
                Byte[] data = System.Text.Encoding.ASCII.GetBytes(signal);
                NetworkStream stream = client.GetStream();
                stream.Write(data, 0, data.Length);
                String responseData = "-1";
                if (returnresult)
                {
                    data = new Byte[256];
                    int bytes = stream.Read(data, 0, data.Length);
                    responseData = System.Text.Encoding.ASCII.GetString(data, 0, bytes);
                }
                stream.Close();
                client.Close();
                return Convert.ToInt32(responseData);
            }
            catch (SocketException SE)
            {
                return SE.ErrorCode;
            }
            catch
            {
                return -1;
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
