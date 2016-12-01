using UnityEngine;
using System.Collections;

public class Pawn : MonoBehaviour {

<<<<<<< HEAD
=======
    public string[] greenPawns = new string[] { "green1", "green2", "green3", "green4"};
>>>>>>> parent of 039b40b... PrawnPawn
    bool home;
    float homePosition;
    float startPosition;
    float currentPosition;

<<<<<<< HEAD

    public void colorStartPosition()
    {

        if ( pawnColor == "green")
=======
    public void colorHomePosition()
    {
        for (int i = 0; i < greenPawns.Length; i++)
        {

        }

        /*if ( == 0)
>>>>>>> parent of 039b40b... PrawnPawn
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
<<<<<<< HEAD
            //startPosition = kordinat[30];
        } 
    }

   public void homeToActive()
=======
            float homePosition = kordinat[30];
        } */
    }

   /*static void homeToActive()
>>>>>>> parent of 039b40b... PrawnPawn
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
