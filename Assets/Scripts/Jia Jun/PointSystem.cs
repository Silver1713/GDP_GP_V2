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
        if (FindObjectOfType<ChoiceManager>().choice1isPicked == true)
        {
            Score -= 10;
            FindObjectOfType<ChoiceManager>().choice1isPicked = false;
            return;
        }
        if (FindObjectOfType<ChoiceManager>().choice2isPicked == true)
        {
            Score += 0;
            FindObjectOfType<ChoiceManager>().choice2isPicked = false;
            return;
        }
        if (FindObjectOfType<ChoiceManager>().choice3isPicked == true)
        {
            Score += 10;
            FindObjectOfType<ChoiceManager>().choice3isPicked = false;
            return;
        }
    }
}
