using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoreManager : MonoBehaviour
{
    //Core/Data/Game Manager should be a singleton
    //They should not have more then one instances

    public static CoreManager mainframe;
    private int CharacterState;
    private void Awake()
        //Making it a singleton class
    {
        if (mainframe == null)
        {
            mainframe = this;
        }
        else if (mainframe != this) Destroy(gameObject);
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


    


}
