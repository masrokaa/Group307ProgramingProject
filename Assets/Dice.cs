using UnityEngine;
using UnityEngine.UI;
using System.Threading;
using System.Collections;

public class Dice : MonoBehaviour
{

    Text writeText;
    public Sprite[] sprites;
    Image randomImg;
<<<<<<< HEAD
=======
    public int rndDice;
>>>>>>> origin/master

    // Use this for initialization
    void Start()
    {   
        randomImg = GameObject.Find("DiceImage").GetComponent<Image>();
    }

    public void WriteToTextField()
    {
<<<<<<< HEAD
        int rndDice = Random.Range(1, 7);
=======
        rndDice = Random.Range(1, 7);
>>>>>>> origin/master
        randomImg.sprite = sprites[rndDice - 1];
    }
}


