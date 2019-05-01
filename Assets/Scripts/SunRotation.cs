using UnityEngine;
using System.Collections;

public class SunRotation : MonoBehaviour
{

    [HideInInspector]
    public GameObject sun;
    [HideInInspector]
    public Light sunLight;

    [Range(0, 24)]
    public float timeOfDay = 12;

    public float colorDailyTransitionY = 1.0f; // yellow
    public float colorDailyTransitionG = 1.0f; // yellow

    public float secondsPerMinute = 60;
    [HideInInspector]
    public float secondsPerHour;
    [HideInInspector]
    public float secondsPerDay;

    public float timeMultiplier = 1;

    void Start()
    {
        sun = gameObject;
        sunLight = gameObject.GetComponent<Light>();

        secondsPerHour = secondsPerMinute * 60;
        secondsPerDay = secondsPerHour * 24;
    }

    // Update is called once per frame
    void Update()
    {
        SunUpdate();

        timeOfDay += (Time.deltaTime / secondsPerDay) * timeMultiplier;

        if (timeOfDay >= 24)
        {
            timeOfDay = 0;
        }
    }

    public void SunUpdate()
    {
        sun.transform.localRotation = Quaternion.Euler(((timeOfDay / 24) * 360f) - 90, 90, 0);
        sunLight.color = new Color(1.0f, colorDailyTransitionG, colorDailyTransitionY, 0.0f);

        if (timeOfDay > 12 && timeOfDay < 19)
        {
            colorDailyTransitionY -= 0.00058f;
            colorDailyTransitionG -= 0.0003f;
        }
        else if (timeOfDay > 5 && timeOfDay < 12)
        {
            colorDailyTransitionY += 0.00058f;
            colorDailyTransitionG += 0.0003f;
        }
        else if (timeOfDay > 18.5 || timeOfDay < 4.5)
        {
            sunLight.intensity = 0;
        }
        else
        {
            sunLight.intensity = 2;
        }

    }
}
