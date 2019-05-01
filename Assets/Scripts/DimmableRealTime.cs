using UnityEngine;
using System.Collections;

public class DimmableRealTime : MonoBehaviour
{

    [HideInInspector]
    public GameObject dimmableLight;
    [HideInInspector]
    public Light dimmableLightIntensity;

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
        dimmableLight = gameObject;
        dimmableLightIntensity = gameObject.GetComponent<Light>();

        secondsPerHour = secondsPerMinute * 60;
        secondsPerDay = secondsPerHour * 24;
    }

    // Update is called once per frame
    void Update()
    {
        DimmableUpdate();

        timeOfDay += (Time.deltaTime / secondsPerDay) * timeMultiplier;

        if (timeOfDay >= 24)
        {
            timeOfDay = 0;
        }
    }

    public void DimmableUpdate()
    {
        if (timeOfDay > 19 && timeOfDay < 20)
        {
            dimmableLightIntensity.intensity += 0.05f;
        }
        else if (timeOfDay > 4 && timeOfDay < 5)
        {
            dimmableLightIntensity.intensity -= 0.05f;

        }

    }
}
