using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PointSystem : MonoBehaviour
{
    public TextMeshProUGUI merits;

    public int Score;
    // Start is called before the first frame update
    void Start()
    {
        merits.SetText("Merits: " + Score);
    }

    // Update is called once per frame
    void Update()
    {
        merits.SetText("Merits: " + Score);
        if (FindObjectOfType<DialogueTrigger>().dialogue.choicetext == GameObject.Find("Choice1").GetComponentInChildren<TextMeshProUGUI>().text && 
            FindObjectOfType<ChoiceManager>().choice1isPicked == true)
        {
            Score += 10;
            FindObjectOfType<ChoiceManager>().choice1isPicked = false;
            return;
        }
        if (FindObjectOfType<DialogueTrigger>().dialogue.choice2text == GameObject.Find("Choice2").GetComponentInChildren<TextMeshProUGUI>().text &&
            FindObjectOfType<ChoiceManager>().choice2isPicked == true)
        {
            Score -= 10;
            FindObjectOfType<ChoiceManager>().choice2isPicked = false;
            return;
        }
    }
}
