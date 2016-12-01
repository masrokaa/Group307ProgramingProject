using UnityEngine;
using System.Collections;

public class keepTrack : MonoBehaviour {

    double[,] green = { { -2.89, 3.63 }, { -2.09, 2.83 }, { -2.86, 2.06 }, { -3.7, 2.83 }, { -3.13, -0.01 }, { -2.43, -0.01 }, { -1.7, -0.01 }, { -0.96, -0.01 }, { -0.05, 0.02 }, };
    double[,] red = { { 2.02, 2.83 }, { 2.79, 3.63 }, { 3.59, 2.86 }, { 2.79, 2.06 }, { -0.05, 3.1 }, { -0.05, 2.36 }, { -0.05, 1.62 }, { -0.05, 0.92 }, { -0.05, 0.02 }, };
    double[,] blue = { { 2.79, -2.09 }, { 3.59, -2.93 }, { 2.82, -3.63 }, { 2.02, -2.86 }, { 3.06, 0.01 }, { 2.32, 0.01 }, { 1.58, 0.01 }, { 0.88, 0.01 }, { -0.05, 0.02 }, };
    double[,] yellow = { { -2.9, -3.63 }, { -3.64, -2.83 }, { -2.87, -2.09 }, { -2.13, -2.89 }, { -0.02, -3.12 }, { -0.02, -2.35 }, { -0.02, -1.68 }, { -0.02, -0.91 }, { -0.05, 0.02 }, };

    public int currentPlayer = 1;

    public GameObject[] redPlayersPawns;
    public GameObject[] greenPlayersPawns;
    public GameObject[] yellowPlayersPawns;
    public GameObject[] bluePlayersPawns;

    // Use this for initialization
    void Start () {
        

        greenPlayersPawns[0].transform.position = (new Vector3((float)green[0, 0], (float)green[0, 1], 0));
        greenPlayersPawns[1].transform.position = (new Vector3((float)green[1, 0], (float)green[1, 1], 0));
        greenPlayersPawns[2].transform.position = (new Vector3((float)green[2, 0], (float)green[2, 1], 0));
        greenPlayersPawns[3].transform.position = (new Vector3((float)green[3, 0], (float)green[3, 1], 0));

        redPlayersPawns[0].transform.position =(new Vector3((float)red[0, 0], (float)red[0, 1], 0));
        redPlayersPawns[1].transform.position = (new Vector3((float)red[1, 0], (float)red[1, 1], 0));
        redPlayersPawns[2].transform.position = (new Vector3((float)red[2, 0], (float)red[2, 1], 0));
        redPlayersPawns[3].transform.position = (new Vector3((float)red[3, 0], (float)red[3, 1], 0));

        bluePlayersPawns[0].transform.position = (new Vector3((float)blue[0, 0], (float)blue[0, 1], 0));
        bluePlayersPawns[1].transform.position = (new Vector3((float)blue[1, 0], (float)blue[1, 1], 0));
        bluePlayersPawns[2].transform.position = (new Vector3((float)blue[2, 0], (float)blue[2, 1], 0));
        bluePlayersPawns[3].transform.position = (new Vector3((float)blue[3, 0], (float)blue[3, 1], 0));

        yellowPlayersPawns[0].transform.position = (new Vector3((float)yellow[0, 0], (float)yellow[0, 1], 0));
        yellowPlayersPawns[1].transform.position = (new Vector3((float)yellow[1, 0], (float)yellow[1, 1], 0));
        yellowPlayersPawns[2].transform.position = (new Vector3((float)yellow[2, 0], (float)yellow[2, 1], 0));
        yellowPlayersPawns[3].transform.position = (new Vector3((float)yellow[3, 0], (float)yellow[3, 1], 0));
    }
	
    public bool IsThereAnActivePawn()
    {
        bool result = false;
        if(currentPlayer == 1)
            for (int i = 0; i < greenPlayersPawns.Length; i++)
            {
                if (greenPlayersPawns[i].GetComponent<pawn>().isPawnActive == true)
                    result = true;
            }
        else if (currentPlayer == 2)
            for (int i = 0; i < redPlayersPawns.Length; i++)
            {
                if (redPlayersPawns[i].GetComponent<pawn>().isPawnActive == true)
                    result = true;
            }
        else if (currentPlayer == 3)
            for (int i = 0; i < bluePlayersPawns.Length; i++)
            {
                if (bluePlayersPawns[i].GetComponent<pawn>().isPawnActive == true)
                    result = true;
            }
        else if (currentPlayer == 4)
            for (int i = 0; i < yellowPlayersPawns.Length; i++)
            {
                if (yellowPlayersPawns[i].GetComponent<pawn>().isPawnActive == true)
                    result = true;
            }

        return result;

    }
    public void ReleasePawn()
    {
       if( UnityClient.currentPlayer == 1)
        {
            for (int i = 0; i < greenPlayersPawns.Length; i++)
            {
                //if (greenPlayersPawns[i].GetComponent<pawn>().isPawnActive == false)
                  //  greenPlayersPawns[i].transform.position 
                   
            }
        }
    }

}
