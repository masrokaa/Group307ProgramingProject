using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine.UI;
using UnityEngine;


    class Dice : MonoBehaviour
    {
    public GameObject whoplays;
        public static int diceroll;
        Text writeText;

        // Use this for initialization
        void Start()
        {
            writeText = GameObject.Find("DiceText").GetComponent<Text>();
        }



        public void WriteToTextField()
        {
        int rndDice = 0;
        rndDice = Random.Range(1, 7);

            writeText.text = "" + rndDice;
            diceroll = rndDice;
    }
}

