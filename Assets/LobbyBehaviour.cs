using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LobbyBehaviour : MonoBehaviour {
    public Text player1, player2, player3, player4;
    bool ishost;
    float passedTime = 0;
    UnityClient multiplayerInfo;

	// Use this for initialization
	void Start () {
       

        multiplayerInfo = (UnityClient) GameObject.FindObjectOfType<UnityClient>();


        ishost = UnityClient.isHost;
        if (ishost)
            TurnManager.thisPlayer = 1;
        else
        {
           
            multiplayerInfo.UpdateSharedInfo();
            TurnManager.thisPlayer = UnityClient.numberOfPlayers;
        }

        Debug.Log(ishost);
	}
	
	// Update is called once per frame
	void Update () {



        passedTime += Time.deltaTime;
        if (passedTime > 1)
        {
            Debug.Log("you are player " + TurnManager.thisPlayer);
            updatePlayers();
            passedTime = 0;
        }

	}

    

    void updatePlayers()
    {

        Debug.Log("updating players");
        int numberOfPlayers = 0;
        multiplayerInfo.UpdateSharedInfo();
        numberOfPlayers = UnityClient.numberOfPlayers;
      

        if (numberOfPlayers > 0)
            player1.text = "Green Player";
        else
            player1.text = "";
        if (numberOfPlayers > 1)
            player2.text = "Red Player";
        else
            player2.text = "";
        if (numberOfPlayers > 2)
            player3.text = "Blue Player";
        else
            player3.text = "";
        if (numberOfPlayers > 3)
            player4.text = "Yellow Player";
        else
            player4.text = "";
    }
}
