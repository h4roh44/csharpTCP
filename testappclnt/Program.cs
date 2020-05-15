using System;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace testappclnt
{
    class Program
    {
        static void Main(string[] args)
        {
            string server = "localhost";
            int port = 6969;
            // declare Server variables

            TcpClient tcpclnt = new TcpClient();
            // Create TCP Client

            Console.WriteLine("Connecting");

            tcpclnt.Connect(server, port);
            // Connect using the TCP Client

            if (tcpclnt.Connected == true)
            {
                Console.WriteLine("connected to " + server);
            }
        }
    }
}
