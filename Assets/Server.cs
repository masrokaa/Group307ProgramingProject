
using System;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Collections.Generic;
using System.Text;

using System.Threading;
public class Server  {
    Thread server;
    public List<Thread> clients = new List<Thread>();
    

    public string storedData = "none";

    public void StartServer()
    {
        server = new Thread(Run);
        server.Start();

    }

    public void Run()
    {
        

        

        int port = 1700;
        TcpListener listener = new TcpListener(IPAddress.Loopback, port);
        listener.Start();

        while (clients.Count<3)
        {

            TcpClient client = listener.AcceptTcpClient();
            Thread temp = new Thread(clientThread);
            temp.Start(client);
            clients.Add(temp);

            
          
        }

      
    }
    public void clientThread(object cliento)
    {
        TcpClient client = (TcpClient)cliento;
        NetworkStream stream = client.GetStream();
        StreamWriter writer = new StreamWriter(stream, Encoding.ASCII) { AutoFlush = true };
        StreamReader reader = new StreamReader(stream, Encoding.ASCII);

        while (true)
        {



            storedData = reader.ReadLine();






        }
    }

}
