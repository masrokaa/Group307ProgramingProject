using UnityEngine;
using System.Collections;

public class script : MonoBehaviour {

    public int mouseClicks;


    // Use this for initialization
    void Start () {
        writeText = GameObject.Find("DiceText").GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            int dice = Random.Range(1, 7);
            mouseClicks += 1;
        }
    }

    public void WriteToTextField()
    {
        

        writeText.text = "" + rndDice;

    }
}
