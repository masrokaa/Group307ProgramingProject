using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System.Collections;

public class Dice : MonoBehaviour
{
    public static float diceroll;
    Text writeText;
    public Sprite[] sprites;
    Image randomImg;
    public int rndDice;

    // Use this for initialization
    void Start()
    {   
        randomImg = GameObject.Find("DiceImage").GetComponent<Image>();
    }

    public void WriteToTextField()
    {
        rndDice = Random.Range(1, 7);
        diceroll = rndDice;
        randomImg.sprite = sprites[rndDice - 1];
    }
}


