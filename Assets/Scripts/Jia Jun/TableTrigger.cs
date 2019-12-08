using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableTrigger : MonoBehaviour
{
    public bool isTableDiaPrompted;
    public bool isTableDia2Prompted;
    public bool isTableDia2Triggered;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && isTableDiaPrompted == false)
        {
            GameObject.Find("BossTable").GetComponent<DialogueTrigger>().TriggerDialogue();
            isTableDiaPrompted = true;
        }
        if (collision.gameObject.tag == "Player" && FindObjectOfType<DialogueTrigger1>().isDialogueRan == true && FindObjectOfType<DialogueTrigger2>().isDialogueRan == true
            && isTableDia2Triggered == false)
        {
            GameObject.Find("BossTable").GetComponent<DialogueTrigger3>().TriggerDialogue();
            isTableDia2Prompted = true;
            isTableDia2Triggered = true;

        }
    }
}
