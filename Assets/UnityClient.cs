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

       
        if (server != null) {
            Debug.Log("server started and has " + server.clients.Count + " clients connected to the server");
            /*
            if(Application.loadedLevelName == "Lobby") {
                if (server.clients.Count == 1)
                {
                    GameObject.Find("Player 2").GetComponent<Text>().text = "Player 2";
    
               }
                if (server.clients.Count == 2)
                {
                    GameObject.Find("Player 3").GetComponent<Text>().text = "Player 3";

                }
                if (server.clients.Count == 3)
                {
                    GameObject.Find("Player 4").GetComponent<Text>().text = "Player 4";

                }

            }
            */


        }

    }
}
