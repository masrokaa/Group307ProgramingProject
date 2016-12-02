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
    string[] shardData = new string[18];
    public string sharedDataString;
    public static int numberOfPlayers;
    public static int currentPlayer=4;
    public static int[] player1PawnPos = new int[4];
    public static int[] player2PawnPos = new int[4];
    public static int[] player3PawnPos = new int[4];
    public static int[] player4PawnPos = new int[4];
    public static string gameStarted;




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
       
        server.StartServer("1,0," + "0,0,0,0," + "0,0,0,0," + "0,0,0,0," + "0,0,0,0"+",0");

        
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
       


    }

    public void UpdateSharedInfo()
    {
        getDataFromServerOrClient();


        shardData = sharedDataString.Split(","[0]);
    

        numberOfPlayers = int.Parse(shardData[0]);
        
        currentPlayer = int.Parse(shardData[1]);
        player1PawnPos[0] = int.Parse(shardData[2]);
        player1PawnPos[1] = int.Parse(shardData[3]);
        player1PawnPos[2] = int.Parse(shardData[4]);
        player1PawnPos[3] = int.Parse(shardData[5]);
        player2PawnPos[0] = int.Parse(shardData[6]);
        player2PawnPos[1] = int.Parse(shardData[7]);
        player2PawnPos[2] = int.Parse(shardData[8]);
        player2PawnPos[3] = int.Parse(shardData[9]);
        player3PawnPos[0] = int.Parse(shardData[10]);
        player3PawnPos[1] = int.Parse(shardData[11]);
        player3PawnPos[2] = int.Parse(shardData[12]);
        player3PawnPos[3] = int.Parse(shardData[13]);
        player4PawnPos[0] = int.Parse(shardData[14]);
        player4PawnPos[1] = int.Parse(shardData[15]);
        player4PawnPos[2] = int.Parse(shardData[16]);
        player4PawnPos[3] = int.Parse(shardData[17]);

        gameStarted = shardData[18];


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

    public void StartGame()
    {
        shardData[18] = "1";
        sharedDataString = "";
        for (int i = 0; i < shardData.Length; i++)
        {
            if (i == shardData.Length - 1)
                sharedDataString += shardData[i];
            else
                sharedDataString += shardData[i] + ",";
        }

        server.updateData(sharedDataString);
    }


}
