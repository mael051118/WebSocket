using System;
using System.Collections.Generic;
using System.Line;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    Class Program
    {
        private static WebSocketServer;
        static void Main(string[] args)
        {
            wsServer = new WebSocketServer();
            int port = 8088
            wsServer.Setup(port);
            wsServer.NewSessionConnected += WsServer_NewSessionConnected;
            wsServer.NewMessageReceived += WsServer_NewMessageReceived;
            wsServer.NewDataReceived += WsServer_NewDataReceived;
            wsServer.SessionClosed += WsServer_SessionClosed;
            wsServer.Start();
            Console.WriteLine("Servidor ejecutando");

        }

        private static void WsServer_SessionClosed(WebSocketSession session, SuperSocket.SocketBase.CloseReason)
        {
            Console.WriteLine("SessionClosed");
        }
        private static void WsServer_NewDataReceived(WebSocketSession session, byte[] value)
        {
            Console.WriteLine("NewDataReceived");
        }
        private static void WsServer_NewMessageReceived(WebSocketSession session, string value)
        {
            Console.WriteLine("NewMessageReceived" + value);
            if (value =="Hello server")
            {
                session.Send("Hola Cliente")
            }
        }
        private static void WsServer_SessionClosed(WebSocketSession session )
        {
            Console.WriteLine("NewSessionConnected");
        }
    }   
}

