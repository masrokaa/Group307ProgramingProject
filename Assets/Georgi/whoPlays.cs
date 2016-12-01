using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class whoPlays : MonoBehaviour {

    public static int currentPlayer;
    public Text player;
    


    public  void switchPlayer()
    {
        if (Dice.diceroll < 6)
        {
            currentPlayer++;
            if (currentPlayer == 5)
            {
                currentPlayer = 1;
            }
        }
            player.text = "player " + currentPlayer;
    }




	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
