using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class clickObject : MonoBehaviour {


    
    public GameObject selectedPawn;

    public static bool Selectable = false;
    public static bool excludeInactivePawn =false;
    
    public string componentName;
    Texture2D outline;

    // Use this for initialization
    void Start () {
        
    }

    // Update is called once per frame
    void Update() {

    }

    void OnMouseDown()
    {
        if (Selectable && Input.GetMouseButtonDown(0) && gameObject.GetComponent<pawn>().player == UnityClient.currentPlayer)
        {
            if (excludeInactivePawn && gameObject.GetComponent<pawn>().isPawnActive == false)
            {
                Debug.Log("Pawn clicked was inactive");
            }
            else {
                selectedPawn = gameObject;

                Debug.Log("The " + this.gameObject.name + " was clicked");
                componentName = this.gameObject.name;
                
                TurnManager.selectedPawn = selectedPawn;
            }
        }
    }

}
