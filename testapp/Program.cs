using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace testapp
{
    class Program
    {
        static void Main(string[] args)
        {
            IPAddress IP = IPAddress.Parse("127.0.0.1");
             // IP Server will run on

            TcpListener tcplist = new TcpListener(IP,6969);
            // Initialize TCP Listener on server

            tcplist.Start();
            // Start the TCP Listener

            Console.WriteLine("Starting TCP Listener on " + IP + ":6969");
            Console.WriteLine("Be patient, I'll accept your socket in one second");

            Socket sock = tcplist.AcceptSocket();
            Console.WriteLine("See what did I say? I accepted your connection from " + sock.RemoteEndPoint);



        }

    }
}
