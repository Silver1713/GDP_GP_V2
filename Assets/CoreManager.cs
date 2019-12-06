using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoreManager : MonoBehaviour
{

    //Core/Data/Game Manager should be a singleton
    //They should not have more then one instances

    public static CoreManager mainframe;
    private int CharacterState;
    public Transform Canvas;
    public Transform winLoseGui;
    private void Awake()
        //Making it a singleton class
    {
        if (mainframe == null)
        {
            mainframe = this;
        }
        else if (mainframe != this) Destroy(gameObject);

        //Find Canvas in game.
        bool objectFound = GameObject.Find("Canvas") != null;

        if (objectFound)
        {
            Canvas = GameObject.Find("Canvas").transform;
        }
    }
    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnLevelLoad;
    }
    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnLevelLoad;
    }

    private void OnLevelLoad(Scene scene, LoadSceneMode mode)
    {
        bool objectFound = GameObject.Find("Canvas") != null;

        if (objectFound)
        {
            Canvas = GameObject.Find("Canvas").transform;
        }
    }

    public string getCharState()
    {
        if (CharacterState == 0)
        {
            return "Male";
        } else if (CharacterState == 1)
        {
            return "Female";
        } else
        {
            return null;
        }
    }

    public void setCharState(int characterState)
    {
        this.CharacterState = characterState;
    }

    public void winGame()
    {
        Transform winUI = winLoseGui.GetChild(0);
        if (winUI != null)
        {
            Transform cloneUI = Instantiate(winUI, Canvas) as Transform;
            cloneUI.gameObject.SetActive(true);
        }
    }

    public void loseGame()
    {
        Transform loseUI = winLoseGui.GetChild(1);
        if (loseUI != null)
        {
            Transform cloneUI = Instantiate(loseUI, Canvas) as Transform;
            cloneUI.gameObject.SetActive(true);
        }
    }





}
