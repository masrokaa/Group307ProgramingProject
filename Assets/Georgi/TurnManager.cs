using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TurnManager : MonoBehaviour {

    
    public Text player;
    public Text action;
    public keepTrack keeptrack;

    public GameObject selectedPawn;

    int diceRolls = 0;

    public  void DiceRolled()
    {
        diceRolls++;
        selectedPawn.GetComponent<pawn>().isPawnActive = true;
        keeptrack.MovePawn(selectedPawn, (int)Dice.diceroll);

        player.text = "Outcome " + Dice.diceroll;
        if (diceRolls > 99)
            action.text = "player "+UnityClient.currentPlayer+" turn";
        else {
            if (Dice.diceroll != 6)
            {
                if (keeptrack.IsThereAnActivePawn())
                {

                    action.text = "Choose Pawn to move";
                    

                }
                else if (diceRolls < 3)
                    action.text = "Roll Again";

            }
            else if (keeptrack.IsThereAnActivePawn() == true)
                action.text = "choose pawn to move or release a pawn";
            else
            {
                action.text = "pawn released";
               // keeptrack.ReleasePawn();
            }
                

        }

    }


    void releasePawn()
    {
        
    }

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
