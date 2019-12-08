using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public bool choice1isPicked;
    public bool choice2isPicked;
    public bool choice3isPicked;
    // Start is called before the first frame update

    public void choice1Picked()
    {
        FindObjectOfType<DialogueTrigger>().isChoicesRunning = false;
        FindObjectOfType<DialogueTrigger1>().isChoicesRunning = false;
        FindObjectOfType<DialogueTrigger2>().isChoicesRunning = false;
        FindObjectOfType<DialogueTrigger3>().isChoicesRunning = false;
        choice1isPicked = true;
        if (FindObjectOfType<DialogueTrigger>().isDialogueRan == false)
        {
            FindObjectOfType<DialogueTrigger>().choicePicked();
        }
        if (FindObjectOfType<MaryTrigger>().MaryTriggered == true)
        {
            FindObjectOfType<MaryTrigger>().MaryTriggered = false;
            FindObjectOfType<DialogueTrigger1>().choicePicked();
        }
        if (FindObjectOfType<AlexTrigger>().AlexTriggered == true)
        {
            FindObjectOfType<AlexTrigger>().AlexTriggered = false;
            FindObjectOfType<DialogueTrigger2>().choicePicked();
        }
        if (FindObjectOfType<TableTrigger>().isTableDia2Prompted == true)
        {
            FindObjectOfType<TableTrigger>().isTableDia2Prompted = false;
            FindObjectOfType<DialogueTrigger3>().choicePicked();
        }
        FindObjectOfType<DialogueManager>().animatorChoiceBox.SetBool("isOpen", false);
    }
    public void choice2Picked()
    {
        FindObjectOfType<DialogueTrigger>().isChoicesRunning = false;
        FindObjectOfType<DialogueTrigger1>().isChoicesRunning = false;
        FindObjectOfType<DialogueTrigger2>().isChoicesRunning = false;
        FindObjectOfType<DialogueTrigger3>().isChoicesRunning = false;
        choice2isPicked = true;
        if (FindObjectOfType<DialogueTrigger>().isDialogueRan == false)
        {
            FindObjectOfType<DialogueTrigger>().choicePicked();
        }
        if (FindObjectOfType<MaryTrigger>().MaryTriggered == true)
        {
            FindObjectOfType<MaryTrigger>().MaryTriggered = false;
            FindObjectOfType<DialogueTrigger1>().choicePicked();
        }
        if (FindObjectOfType<AlexTrigger>().AlexTriggered == true)
        {
            FindObjectOfType<AlexTrigger>().AlexTriggered = false;
            FindObjectOfType<DialogueTrigger2>().choicePicked();
        }
        if (FindObjectOfType<TableTrigger>().isTableDia2Prompted == true)
        {
            FindObjectOfType<TableTrigger>().isTableDia2Prompted = false;
            FindObjectOfType<DialogueTrigger3>().choicePicked();
        }
        FindObjectOfType<DialogueManager>().animatorChoiceBox.SetBool("isOpen", false);
    }
    public void choice3Picked()
    {
        FindObjectOfType<DialogueTrigger>().isChoicesRunning = false;
        FindObjectOfType<DialogueTrigger1>().isChoicesRunning = false;
        FindObjectOfType<DialogueTrigger2>().isChoicesRunning = false;
        FindObjectOfType<DialogueTrigger3>().isChoicesRunning = false;
        choice3isPicked = true;
        if (FindObjectOfType<DialogueTrigger>().isDialogueRan == false)
        {
            FindObjectOfType<DialogueTrigger>().choicePicked();
        }
        if (FindObjectOfType<MaryTrigger>().MaryTriggered == true)
        {
            FindObjectOfType<MaryTrigger>().MaryTriggered = false;
            FindObjectOfType<DialogueTrigger1>().choicePicked();
        }
        if (FindObjectOfType<AlexTrigger>().AlexTriggered == true)
        {
            FindObjectOfType<AlexTrigger>().AlexTriggered = false;
            FindObjectOfType<DialogueTrigger2>().choicePicked();
        }
        if (FindObjectOfType<TableTrigger>().isTableDia2Prompted == true)
        {
            FindObjectOfType<TableTrigger>().isTableDia2Prompted = false;
            FindObjectOfType<DialogueTrigger3>().choicePicked();
        }
        FindObjectOfType<DialogueManager>().animatorChoiceBox.SetBool("isOpen", false);
    }
}
