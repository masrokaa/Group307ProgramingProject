using UnityEngine;
using System.Collections;

public class clickObject : MonoBehaviour {

    public int mouseClicks;


    // Use this for initialization
    void Start () {
        
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

            Debug.Log("pawn clicked");
        }
    }

}
