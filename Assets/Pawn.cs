using UnityEngine;
using System.Collections;

public class Pawn : MonoBehaviour {

    bool home;
    float homePosition;
    float startPosition;
    float currentPosition;
    public string pawnColor;


    public void colorStartPosition()
    {

        if ( pawnColor == "green")
        {
            //startPosition = kordinat[0];
        }

        if (pawnColor == "red")
        {
             //startPosition = kordinat[10];
        }

        if (pawnColor == "blue")
        {
             //startPosition = kordinat[20];
        }

        if (pawnColor == "yellow")
        {
            //startPosition = kordinat[30];
        } 
    }

   public void homeToActive()
    {
        if (Dice.diceValue == 6)
            home = false;
            homePosition = startPosition;
            //roll dice
    }

    public void movePawn()
    {
        currentPosition = currentPosition + Dice.diceValue;
    }

    public void killPawn()
    {
        homePosition = currentPosition;
        home = true;
    } 


    // Use this for initialization
    void start()
    {
  
    }

    // Update is called once per frame
    void Update()
    {

    }
}
