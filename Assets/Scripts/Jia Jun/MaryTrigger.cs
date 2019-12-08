using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MaryTrigger : MonoBehaviour
{
    public bool isMaryTrigger;
    public bool MaryTriggered = false;
    public bool MaryTriggers;

    private void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !isMaryTrigger && FindObjectOfType<TableTrigger>().isTableDiaPrompted == true)
        {
            MaryTriggered = true;
            isMaryTrigger = true;
            MaryTriggers = true;
            FindObjectOfType<DialogueManager>().isDiaEnded = false;
        } else { FindObjectOfType<DialogueManager>().isDiaEnded = true; }
    }
}
