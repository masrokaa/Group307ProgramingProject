using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Text.RegularExpressions;


public class splitString : MonoBehaviour {

    /* public string txt = "sth,sth1,sth2";
     public string splittingPattern = "\\,\\";
     public string[] arr;*/

    string text = "this,is,a,test,bla,bla,bla,this,this,this";
    string [] textSplit;

    // Use this for initialization
    void Start () {
        textSplit = text.Split(","[0]);
        Debug.Log(text); //this is a test bla bla bla this this this
        Debug.Log(textSplit); //System.String[]

        for (int i = 0; i < textSplit.Length; i++){
            Debug.Log(textSplit[i]); //each split
        }
        Debug.Log(textSplit[1]); //is
        Debug.Log(textSplit[3]); //test
    }
	
	// Update is called once per frame
	void Update () {

    }

}
    
