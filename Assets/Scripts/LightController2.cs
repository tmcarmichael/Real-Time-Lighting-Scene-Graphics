using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController2 : MonoBehaviour
{
    Light light;

    // Use this for initialization
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        // Toggle light on/off when J key is pressed.
        if (Input.GetKeyUp(KeyCode.J))
        {
            light.enabled = !light.enabled;
        }
    }
}