using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TimeDayCountdown : MonoBehaviour
{

    // Start is called before the first frame update
    public Text currentUI;
    public float currentLevel = 0;
    float firstLevel = 1;
    [Tooltip("This set how much time have pass in relation real world seconds [X number of real world second : 1 minute in game time.]")] public float ratio = 1f;
    public float[] timeLimit = { 18f, 0f };
    public float[] currentTime = { 0, 0 };
    public float[] startTime;
    public IEnumerator countdownFunc;
    private bool blinking;
    IEnumerator blinker;

    public float waitTimeBeforeGameOver;

    private void Awake()
    {
        if (startTime.Length < 2)
        {
            startTime = new float[2];
            startTime[0] = 9;
            startTime[1] = 0;
            currentTime = startTime;
            setTimeToText(currentTime, currentUI);

        }
        else
        {
            currentTime = startTime;
            setTimeToText(currentTime, currentUI);
        }

        if (currentLevel <= 0)
        {
            currentLevel = firstLevel;
        }
        countdownFunc = countdownTimer(currentTime, (ratio / 60));
        StartCoroutine(countdownFunc);
    }

    private void Update()
    {

        setTimeToText(currentTime, currentUI);
        if (checkLoseGame(currentTime, timeLimit))
        {
            loseGame();

        }
    }



    public void setTime(int hour, int min)
    {
        if (hour >= 0 && min >= 0)
        {
            //hour
            currentTime[0] = hour;
            currentTime[1] = min;
        }
    }

    public void setTimeToText(float[] _current, Text textUI)
    {
        string m = "00";
        string h = "00";

        if (_current[0] < 10)
        {
            h = "0" + _current[0].ToString();
        }
        else
        {
            h = _current[0].ToString();
        }
        if (_current[1] < 10)
        {
            m = "0" + _current[1].ToString();
        }
        else
        {
            m = _current[1].ToString();
        }

        string mmhh = h + ":" + m;
        textUI.text = mmhh;
    }

    IEnumerator countdownTimer(float[] time, float ratio)
    {
        while (true)

        {
            yield return new WaitForSecondsRealtime(60f * ratio);
            if (time[1] < 59f)
            {
                time[1]++;
            }
            else
            {
                time[0]++;
                time[1] = 0f;
            }
        }




    }

    //float convertTimeToSec(float DifferenceInHour, float DifferenceInMin)
    //{
    //    float oneHour = 3600f;
    //    float resultHour = DifferenceInHour * oneHour;
    //    float oneMin = 60f;
    //    float resultMin = DifferenceInMin * oneMin;

    //    float result = resultHour + resultMin;

    //    return result;
    //}

    public bool checkLoseGame(float[] currentTime, float[] loseTime)
    {
        bool isLost = false;

        if (currentTime[0] == loseTime[0] && currentTime[1] == loseTime[1])
        {
            isLost = true;
        }
        return isLost;
    }


    public void loseGame()
    {
        Debug.Log("Player Have Lost.");
        if (countdownFunc != null)
        {
            StopCoroutine(countdownFunc);
        }
        if (blinking == false)
        {
            blinker = Blink(1f);
            StartCoroutine(blinker);
        }
    }

    IEnumerator Blink(float blinkIntervalSeconds)
    {
        for (; ; )
        {
            blinking = true;
            yield return new WaitForSecondsRealtime(blinkIntervalSeconds / 2);
            currentUI.color = Color.red;
            yield return new WaitForSecondsRealtime(blinkIntervalSeconds / 2);
            currentUI.color = Color.white;
        }
    }


}
