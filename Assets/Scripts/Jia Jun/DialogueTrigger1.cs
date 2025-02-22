﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger1 : MonoBehaviour
{
    public Dialogue dialogue;
    public bool isChoicesRunning;
    public bool isDialogueRan;


    public void TriggerDialogue()
    {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);  
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        TriggerChoices();
        if (collision.gameObject.tag == "Player" && Input.GetKeyDown(KeyCode.Space) && !isDialogueRan)
        {
            TriggerDialogue();
        }
        if (collision.gameObject.tag == "Player" && (Input.GetKeyDown(KeyCode.Space) || FindObjectOfType<Interacting>().isInteracting == true) && isDialogueRan)
        {
            FindObjectOfType<Interacting>().isInteracting = false;
            FindObjectOfType<DialogueManager>().RepeatedDialogue(dialogue);
        }
    }

    public void TriggerChoices()
    {
        if((string)dialogue.sentences.GetValue(dialogue.sentences.Length-1) == FindObjectOfType<DialogueManager>().dialogueText.text && FindObjectOfType<DialogueManager>().sentences.Count == 0 
            && (dialogue.choicetext.Length != 0 || dialogue.choice2text.Length != 0 || dialogue.choice3text.Length != 0))
        {
            isChoicesRunning = true;
            FindObjectOfType<DialogueManager>().Choice1(dialogue);
            FindObjectOfType<DialogueManager>().Choice2(dialogue);
            FindObjectOfType<DialogueManager>().Choice3(dialogue);
        }
    }

    public void choicePicked()
    {
        if (FindObjectOfType<ChoiceManager>().choice1isPicked == true || FindObjectOfType<ChoiceManager>().choice2isPicked == true || FindObjectOfType<ChoiceManager>().choice3isPicked == true)
        {
            FindObjectOfType<DialogueManager>().NextDialogue(dialogue);
        }
    }
}
