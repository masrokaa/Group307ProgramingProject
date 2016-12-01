using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Net;
using UnityEngine.UI;



public class UnityClient : MonoBehaviour {
    Server server;
    Client client;
    public Text textGui;
    public static bool isHost = false;

    string ip= "localHost";


    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void Host()
    {
        isHost = true;
        Application.LoadLevel("Lobby");
        server = new Server();

        Debug.Log("starting server");
        server.StartServer();
    }

   

   public void join()
    {
        ip = textGui.text;
        client = new Client(ip);
        Debug.Log("starting client");
        client.StartClient();
        Debug.Log("client started");

       
    }

	// Use this for initialization
	void Start () {
        Debug.Log(ip);
    }


	
	// Update is called once per frame
	void Update () {


        if (server != null && client.dataGottenFromServer != "")
            Application.LoadLevel("Lobby");

        if (server != null) {
            Debug.Log("server started and has " + server.clients.Count + " clients connected to the server");
        }

    }

    public int GetNumberOfPlayersInLobby()
    {
        int number = 1;
        number += server.clients.Count;
        return number;
    }


}
