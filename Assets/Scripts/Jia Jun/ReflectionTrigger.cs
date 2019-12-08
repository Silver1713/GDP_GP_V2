using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ReflectionTrigger : MonoBehaviour
{
    public TextMeshProUGUI Reflect1;
    public TextMeshProUGUI Reflect2;
    public Animator animatorReflectionBox;
    void Update()
    {
        if(FindObjectOfType<DialogueTrigger>().isChoicesRunning == true || FindObjectOfType<DialogueTrigger>().isChoicesRunning == false)
        {
            if(FindObjectOfType<DialogueTrigger>().tag == "Boss")
            {
                animatorReflectionBox.SetBool("isOpen", true);
                Reflect1.SetText("'Good morning, Boss! Feeling well today.' - A start off with a Good morning is never wrong, follow up with are you okay is fine.");
                Reflect2.SetText("'Yo, what's up, boss?' - This is your boss, not your friend, unless the boss specifically asked you to call him like this.");
            }
            if(FindObjectOfType<DialogueTrigger>().isChoicesRunning == false)
            {
                animatorReflectionBox.SetBool("isOpen", false);
            }
        }
    }
}
