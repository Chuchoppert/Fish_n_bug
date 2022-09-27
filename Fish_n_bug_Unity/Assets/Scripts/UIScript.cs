using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour
{
    
    public void ChanegScene(string name)
    {
        SceneManager.LoadScene(name);
    }


    public void ExitGame()
    {
        Application.Quit();
    }
}
