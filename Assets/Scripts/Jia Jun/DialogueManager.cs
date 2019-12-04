using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;
    public TextMeshProUGUI choice1Text;
    public TextMeshProUGUI choice2Text;

    public Animator animatorDialogueBox;
    public Animator animatorChoiceBox;
    public static bool isDiaEnded = false;


    public bool endofSentence;

    public Queue<string> sentences; //More restrictive than array && FIFO(First In First Out)
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>(); //Instantiate || Initialise || Make > A new Queue<string>
    }

    public void StartDialogue(Dialogue dialogue)
    {
        animatorDialogueBox.SetBool("isOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }
    public void DisplayNextSentence()
    {
        if (sentences.Count == 0 && FindObjectOfType<DialogueTrigger>().isChoicesRunning == false)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        dialogueText.text = sentence;
    }

    void EndDialogue()
    {
        FindObjectOfType<DialogueManager>().animatorDialogueBox.SetBool("isOpen", false);
        print(endofSentence);
        FindObjectOfType<DialogueTrigger>().isDialogueRan = true;
        isDiaEnded = true;
    }

    public void RepeatedDialogue(Dialogue dialogue)
    {
        animatorDialogueBox.SetBool("isOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.RepeatedsentencesAfterTRUEdialogue)
        {
            sentences.Enqueue(sentence);
        }
        DisplayNextSentence();
    }

    public void NextDialogue(Dialogue dialogue)
    {
        print("running");
        animatorDialogueBox.SetBool("isOpen", true);

        sentences.Clear();

        if (FindObjectOfType<ChoiceManager>().choice1isPicked == true)
        {
            foreach (string sentence in dialogue.sentencesAfterChoice1)
            {
                sentences.Enqueue(sentence);
            }
            DisplayNextSentence();
        }

        if (FindObjectOfType<ChoiceManager>().choice2isPicked == true)
        {
            foreach (string sentence in dialogue.sentencesAfterChoice2)
            {
                sentences.Enqueue(sentence);
            }
            DisplayNextSentence();
        }
    }

    public void Choice1(Dialogue choices)
    {
        animatorChoiceBox.SetBool("isOpen", true);
        choice1Text.text = choices.choicetext;
    }

    public void Choice2(Dialogue choices2)
    {
        animatorChoiceBox.SetBool("isOpen", true);
        choice2Text.text = choices2.choice2text;
    }
}
