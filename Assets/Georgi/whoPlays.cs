using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class whoPlays : MonoBehaviour {

    public static int currentPlayer;
    public Text player;
    


    public  void switchPlayer()
    {
        

            player.text = "Outcome " + Dice.diceroll;
            
    }




	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
