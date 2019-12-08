using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Objective : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (FindObjectOfType<TableTrigger>().isTableDiaPrompted == true)
        {
            GameObject.Find("Objective1").GetComponent<TextMeshProUGUI>().SetText("Leisure Room 0/1");
            GameObject.Find("Objective2").GetComponent<TextMeshProUGUI>().SetText("Toilet 0/1");
        }
        if (FindObjectOfType<DialogueTrigger1>().isDialogueRan == true)
        {
            GameObject.Find("Objective1").GetComponent<TextMeshProUGUI>().SetText("Leisure Room Cleared");
        }
        if (FindObjectOfType<DialogueTrigger2>().isDialogueRan == true)
        {
            GameObject.Find("Objective2").GetComponent<TextMeshProUGUI>().SetText("Toilet Cleared");
        }
    }
}
