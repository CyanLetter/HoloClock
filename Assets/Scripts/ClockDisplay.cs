using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockDisplay : MonoBehaviour {

    // array of seven segmetn displays, from left to right
    public SevenSegmentDisplay[] numberDisplays;
    int[] timeArray;

    string currentTime;

	// Use this for initialization
	void Start () {
        timeArray = new int[numberDisplays.Length];
        WaitAndUpdateTime();
    }

    void WaitAndUpdateTime() {
        StartCoroutine(SetTime());
    }

    IEnumerator SetTime() {
        yield return new WaitForSeconds(1f);

        currentTime = DateTime.Now.ToString("hh:mm:ss");

        print(currentTime);

        if (numberDisplays.Length >= 2) {
            // hours
            Int32.TryParse(currentTime[0].ToString(), out timeArray[0]);
            Int32.TryParse(currentTime[1].ToString(), out timeArray[1]);
        }

        if (numberDisplays.Length >= 4)
        {
            // minutes
            Int32.TryParse(currentTime[3].ToString(), out timeArray[2]);
            Int32.TryParse(currentTime[4].ToString(), out timeArray[3]);
        }

        if (numberDisplays.Length >= 6)
        {
            // seconds
            Int32.TryParse(currentTime[6].ToString(), out timeArray[4]);
            Int32.TryParse(currentTime[7].ToString(), out timeArray[5]);
        }

        for (int i = 0; i < numberDisplays.Length; i++)
        {
            numberDisplays[i].SetNumber(timeArray[i]);
        }

        WaitAndUpdateTime();
    }
}
