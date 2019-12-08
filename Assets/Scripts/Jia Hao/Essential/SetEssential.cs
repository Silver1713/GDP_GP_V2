using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetEssential : MonoBehaviour
{
    ///<summary>
    /// Allow game object to not be destroy when changing scences
    /// This scripts is only applied to essential items like the mainframe of the game  
    /// </summary>
    /// 
    [Header("Essential Controls")]
    [Tooltip("Set if an object is essential and keep them when changing scene")] public bool Essential;


    private void Start()
    {
        if (Essential)
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
