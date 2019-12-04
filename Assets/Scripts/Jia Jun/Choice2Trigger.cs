using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice2Trigger : MonoBehaviour
{
    public void PromptChoiceManager2()
    {
        FindObjectOfType<ChoiceManager>().choice2Picked();
    }

}
