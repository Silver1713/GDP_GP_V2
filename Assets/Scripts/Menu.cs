using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject currentScreen;
    public GameObject nextScreen;
    public CoreManager core;

    public void playgame()
    {
        core = CoreManager.mainframe;
        core.setCharState(0); //Male
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void navigateScreen()
    {
        if (nextScreen)
        {
            nextScreen.SetActive(true);
            currentScreen.SetActive(false);
        }
    }
    public void end()
    {
#if (UNITY_EDITOR)
        UnityEditor.EditorApplication.isPlaying = false;
        

#endif
        Application.Quit();
    }
}