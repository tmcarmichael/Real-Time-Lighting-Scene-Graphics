using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;

public class Clock : MonoBehaviour
{
    public Text clockReading;

    [Range(0, 24)]
    public float timeOfDay = 12;
    public float secondsPerMinute = 60;
    [HideInInspector]
    public float secondsPerHour;
    [HideInInspector]
    public float secondsPerDay;
    public float timeMultiplier = 1;

    void Start()
    {
        secondsPerHour = secondsPerMinute * 60;
        secondsPerDay = secondsPerHour * 24;
    }

    // Update is called once per frame
    void Update()
    {
        ClockUpdate();

        timeOfDay += (Time.deltaTime / secondsPerDay) * timeMultiplier;

        if (timeOfDay >= 24)
        {
            timeOfDay = 0;
        }
    }

    public void ClockUpdate()
    {
        clockReading.text = Math.Round(timeOfDay, 2).ToString();
    }
}
