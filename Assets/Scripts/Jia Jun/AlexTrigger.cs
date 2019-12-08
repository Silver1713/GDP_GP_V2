using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlexTrigger : MonoBehaviour
{
    public bool isAlexTrigger;
    public bool AlexTriggered = false;
    public bool AlexTriggers = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Player" && isAlexTrigger == false && FindObjectOfType<TableTrigger>().isTableDiaPrompted == true)
        {
            AlexTriggers = true;
            AlexTriggered = true;
            isAlexTrigger = true;
            FindObjectOfType<DialogueManager>().isDiaEnded = false;
        }
       else
        {
            FindObjectOfType<DialogueManager>().isDiaEnded = true;
        }
    }
}
