using UnityEngine;
using System.Collections;

public class keepTrack : MonoBehaviour {

    double[,] green = { { -2.89, 3.63 }, { -2.09, 2.83 }, { -2.86, 2.06 }, { -3.7, 2.83 }, { -3.13, -0.01 }, { -2.43, -0.01 }, { -1.7, -0.01 }, { -0.96, -0.01 }, { -0.05, 0.02 }, };
    double[,] red = { { 2.02, 2.83 }, { 2.79, 3.63 }, { 3.59, 2.86 }, { 2.79, 2.06 }, { -0.05, 3.1 }, { -0.05, 2.36 }, { -0.05, 1.62 }, { -0.05, 0.92 }, { -0.05, 0.02 }, };
    double[,] blue = { { 2.79, -2.09 }, { 3.59, -2.93 }, { 2.82, -3.63 }, { 2.02, -2.86 }, { 3.06, 0.01 }, { 2.32, 0.01 }, { 1.58, 0.01 }, { 0.88, 0.01 }, { -0.05, 0.02 }, };
    double[,] yellow = { { -2.9, -3.63 }, { -3.64, -2.83 }, { -2.87, -2.09 }, { -2.13, -2.89 }, { -0.02, -3.12 }, { -0.02, -2.35 }, { -0.02, -1.68 }, { -0.02, -0.91 }, { -0.05, 0.02 }, };

    public GameObject[] redPlayersPawns;
    public GameObject[] greenPlayersPawns;
    public GameObject[] yellowPlayersPawns;
    public GameObject[] bluePlayersPawns;

    // Use this for initialization
    void Start () {
        //Debug.Log(kordinator[0, 0]);
        //Debug.Log(kordinator[0, 1]);
        redPlayersPawns[1].transform.position =(new Vector3((float)red[0, 0], (float)red[0, 1], 0));
        redPlayersPawns[1].transform.position = (new Vector3((float)red[0, 0], (float)red[0, 1], 0));
        redPlayersPawns[1].transform.position = (new Vector3((float)red[0, 0], (float)red[0, 1], 0));
        redPlayersPawns[1].transform.position = (new Vector3((float)red[0, 0], (float)red[0, 1], 0));

        greenPlayersPawns[1].transform.position = (new Vector3((float)green[0, 0], (float)green[0, 1], 0));
        greenPlayersPawns[1].transform.position = (new Vector3((float)green[0, 0], (float)green[0, 1], 0));
        greenPlayersPawns[1].transform.position = (new Vector3((float)green[0, 0], (float)green[0, 1], 0));
        greenPlayersPawns[1].transform.position = (new Vector3((float)green[0, 0], (float)green[0, 1], 0));

        bluePlayersPawns[1].transform.position = (new Vector3((float)blue[0, 0], (float)blue[0, 1], 0));
        bluePlayersPawns[1].transform.position = (new Vector3((float)blue[0, 0], (float)blue[0, 1], 0));
        bluePlayersPawns[1].transform.position = (new Vector3((float)blue[0, 0], (float)blue[0, 1], 0));
        bluePlayersPawns[1].transform.position = (new Vector3((float)blue[0, 0], (float)blue[0, 1], 0));

        yellowPlayersPawns[1].transform.position = (new Vector3((float)yellow[0, 0], (float)yellow[0, 1], 0));
        yellowPlayersPawns[1].transform.position = (new Vector3((float)yellow[0, 0], (float)yellow[0, 1], 0));
        yellowPlayersPawns[1].transform.position = (new Vector3((float)yellow[0, 0], (float)yellow[0, 1], 0));
        yellowPlayersPawns[1].transform.position = (new Vector3((float)yellow[0, 0], (float)yellow[0, 1], 0));
    }
	
	// Update is called once per frame
	void Update () {

	}
}
