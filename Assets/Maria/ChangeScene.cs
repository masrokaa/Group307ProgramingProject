using UnityEngine;
using System.Collections;

public class ChangeScene : MonoBehaviour
{
      public void SceneChange(int index)
    {
        Application.LoadLevel(index);
    }

    public void SceneChange(string levelName)
    {
        Application.LoadLevel(levelName);
    }
}

