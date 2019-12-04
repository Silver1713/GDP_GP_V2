using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceManager : MonoBehaviour
{
    public bool choice1isPicked;
    public bool choice2isPicked;
    // Start is called before the first frame update
    void Start()
    {
    }

    public void choice1Picked()
    {
        FindObjectOfType<DialogueTrigger>().isChoicesRunning = false;
        choice1isPicked = true;
        FindObjectOfType<DialogueTrigger>().choicePicked();
        FindObjectOfType<DialogueManager>().animatorChoiceBox.SetBool("isOpen", false);
    }
    public void choice2Picked()
    {
        FindObjectOfType<DialogueTrigger>().isChoicesRunning = false;
        choice2isPicked = true;
        FindObjectOfType<DialogueTrigger>().choicePicked();
        FindObjectOfType<DialogueManager>().animatorChoiceBox.SetBool("isOpen", false);
    }
}
