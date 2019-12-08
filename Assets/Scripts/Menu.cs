using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    public GameObject currentScreen;
    public GameObject nextScreen;
    public CoreManager core;

    private void Start()
    {
        core = CoreManager.mainframe;
    }

    public void playgame()
    {
        if (characterSelector.mSelected == characterSelector.fSelected) return;
        if (characterSelector.mSelected == 1)
        {
            core.setCharState(0);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        } else
        {
            core.setCharState(1);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
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