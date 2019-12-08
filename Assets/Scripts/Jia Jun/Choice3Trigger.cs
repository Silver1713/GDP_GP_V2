using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choice3Trigger : MonoBehaviour
{
    public void PromptChoiceManager3()
    {
        FindObjectOfType<ChoiceManager>().choice3Picked();
    }
}
