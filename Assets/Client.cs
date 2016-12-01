using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;

public class Client  {

    Thread client;
    public string dataGottenFromServer = "";
    string ipAdress;
    bool sendData = false;
    string data = "data that was send";
    public string recivedData;

    public Client(string ipAdress)
    {
        this.ipAdress = ipAdress;
    }

    public void StartClient()
    {
        client = new Thread(Connect);
        client.Start();
    }

    public void Connect()
    {
        

        int port = 1700;
        TcpClient client = new TcpClient(ipAdress, port);
        NetworkStream stream = client.GetStream();
        StreamReader reader = new StreamReader(stream);
        StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };
      

        while (true)
        {


            dataGottenFromServer = reader.ReadLine();
            writer.WriteLine(data);

               
        }
    }


   
}
