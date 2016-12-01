using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LobbyBehaviour : MonoBehaviour {
    public Text player1, player2, player3, player4;
    bool ishost;
    UnityClient multiplayerInfo;

	// Use this for initialization
	void Start () {
        multiplayerInfo = (UnityClient) GameObject.FindObjectOfType<UnityClient>();
        ishost = UnityClient.isHost;
        Debug.Log(ishost);
	}
	
	// Update is called once per frame
	void Update () {
        if (Time.deltaTime % 1.2 > 1)
            updatePlayers();

	}
    void updatePlayers()
    {
        int numberOfPlayers = 0;
        numberOfPlayers = multiplayerInfo.GetNumberOfPlayersInLobby();
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
