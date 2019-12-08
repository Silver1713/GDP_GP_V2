using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    public string selectedCharacter;
    private CoreManager gameCore;
    private void Awake()
    {
        gameCore = CoreManager.mainframe;
        selectedCharacter = gameCore.getCharState();
    }

    private void Start()
    {
        if (selectedCharacter != null)
        {
            Transform currentCharacter = transform.Find(selectedCharacter);
            currentCharacter.gameObject.SetActive(true);
        }
    }
}
