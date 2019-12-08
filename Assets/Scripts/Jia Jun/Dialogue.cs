using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue //Remove monobehaviour, there is no need of any intervention from unity
{
    public string name; //assigning type<string> to variable

    [TextArea(3, 10)]
    public string[] sentences; //assigning reference value<array<string>> to variable
    [TextArea(3, 10)]
    public string[] sentencesAfterChoice1;
    [TextArea(3, 10)]
    public string[] sentencesAfterChoice2;
    [TextArea(3, 10)]
    public string[] sentencesAfterChoice3;

    public string choicetext;
    public string choice2text;
    public string choice3text;

    [TextArea(3, 10)]
    public string[] RepeatedsentencesAfterTRUEdialogue;
}
    

