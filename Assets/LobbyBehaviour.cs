using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LobbyBehaviour : MonoBehaviour {
    public Text player1, player2, player3, player4;
    bool ishost;


	// Use this for initialization
	void Start () {
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

    }
}
