using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class FloorTimer : MonoBehaviour
{
    public int secondCount;
    public int minuteCount;
    public bool addingTime;
    public GameObject timeDisplay;

    void Update()
    {
        if (!addingTime)
        {
            StartCoroutine(AddSecond());
        }
    }

    IEnumerator AddSecond()
    {
        addingTime = true;

        yield return new WaitForSeconds(1);

        secondCount++;
        if (secondCount >= 60)
        {
            secondCount = 0;
            minuteCount++;
        }

        string result = "";
        if (minuteCount <= 9)
        {
            result += "0" + minuteCount;
        }
        else
        {
            result += minuteCount;
        }
        if (secondCount <= 9)
        {
            result += ":0" + secondCount;
        }
        else
        {
            result += ":" + secondCount;
        }
        timeDisplay.GetComponent<Text>().text = result;

        addingTime = false;
    }
}
