using UnityEngine;
using System.Collections;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Net;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class UnityClient : MonoBehaviour {
    Server server;
    Client client;
    string[] shardData;
    string sharedDataString;
    public static int numberOfPlayers;
    public static int currentPlayer=4;
    public static int[] player1PawnPos;
    public static int[] player2PawnPos;
    public static int[] player3PawnPos;
    public static int[] player4PawnPos;




    public Text textGui;
    public static bool isHost = false;

    public Scene Lobby;

    string ip= "localHost";


    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    public void Host()
    {
        isHost = true;
        SceneManager.LoadScene("Lobby");
        server = new Server();

        Debug.Log("starting server");
        server.StartServer("1,0," + "0,0,0,0," + "0,0,0,0," + "0,0,0,0," + "0,0,0,0");

        
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


        if (client != null && client.dataGottenFromServer != "" &&  SceneManager.GetActiveScene().name != "Lobby")
            SceneManager.LoadScene("Lobby");



        /*
        if (server != null) {
            Debug.Log("server started and has " + server.clients.Count + " clients connected to the server");
        }
        */
    }

   void convertString()
    {
        shardData = sharedDataString.Split(","[0]);


    }

    public void UpdateSharedInfo()
    {
        getDataFromServerOrClient();
        convertString();

        numberOfPlayers = int.Parse(shardData[0]);
        currentPlayer = int.Parse(shardData[1]);
        for (int i = 2; i < 2+4; i++)
        {
            player1PawnPos[i] = int.Parse(shardData[i]);
        }
        for (int i = 6; i < 6 + 4; i++)
        {
            player2PawnPos[i] = int.Parse(shardData[i]);
        }
        for (int i = 10; i < 10 + 4; i++)
        {
            player3PawnPos[i] = int.Parse(shardData[i]);
        }
        for (int i = 14; i < 14 + 4; i++)
        {
            player4PawnPos[i] = int.Parse(shardData[i]);
        }


        
    }

    public void getDataFromServerOrClient()
    {
        if (isHost)
        {
           sharedDataString = server.storedData;
        }
        else
        {
            sharedDataString = client.dataGottenFromServer;
        }

    }



}
