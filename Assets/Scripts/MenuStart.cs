using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuStart : MonoBehaviour
{
    public void changeMenuScreen(string sceneName)
    {
        Application.LoadLevel(sceneName);
    }
}
