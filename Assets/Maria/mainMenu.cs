using UnityEngine;
using System.Collections;

public class mainMenu : MonoBehaviour {

    public Texture2D rules;

    int cases = 0;
   
    void OnGUI()
    {
        GUIStyle big = new GUIStyle();
        big.fontSize = 35;
       

       
        switch (cases)
        {
            case 0: 
               
                GUI.Label(new Rect(Screen.width / 2.5f+25, 40, 300, 50), "Ludo", big);

                if (GUI.Button(new Rect(Screen.width / 2.5f, 100, 130, 50), "Play"))
                {
                    cases = 4;
                }

                if (GUI.Button(new Rect(Screen.width / 2.5f, 200, 130, 50), "Host"))
                {
                    cases = 1;
                }

                if (GUI.Button(new Rect(Screen.width / 2.5f, 300, 130, 50), "Server"))
                {
                    cases = 2;
                }

                if (GUI.Button(new Rect(Screen.width / 2.5f, 400, 130, 50), "Rules"))
                {
                    cases = 3;
                }

                if (GUI.Button(new Rect(Screen.width / 2.5f, 500, 130, 50), "Quit"))
                {
                    Application.Quit();
                }
                break;

            case 1: 
               

                    //Back button:
                    if (GUI.Button(new Rect(Screen.width / 2.5f, 500, 130, 50), "Back"))
                {
                    cases = 0;
                }

                break;

            case 2: 


                if (GUI.Button(new Rect(Screen.width / 2.5f, 500, 130, 50), "Back"))
                {
                    cases = 0;
                }

                break;

            case 3:

                GUI.TextArea(new Rect(Screen.width / 2.5f, 50, 130, 50), "Rules of Ludo");


                GUI.DrawTexture(new Rect(Screen.width / 2.5f - 165, 30, rules.width - 50, rules.height - 50), rules);


                if (GUI.Button(new Rect(Screen.width / 2.5f, 500, 130, 50), "Back"))
                {
                    cases = 0;
                }

          
                break;

            case 4:

                if (GUI.Button(new Rect(Screen.width / 2.5f, 510, 100, 30), "Exit"))
                {
                    cases = 0;
                }      

                break;

            case 5:

                if (GUI.Button(new Rect(Screen.width / 2.5f+50, 510, 100, 30), "Exit"))
                {
                    cases = 0;

                }

                break;
                
            case 6: 

                //Back button:
                if (GUI.Button(new Rect(Screen.width / 2.5f, 500, 130, 50), "Back"))
                {
                    cases = 1;
                }

                break;
           
        }
    }
        

	
}
