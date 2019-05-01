using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightController1 : MonoBehaviour
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
        // Toggle light on/off when K key is pressed.
        if (Input.GetKeyUp(KeyCode.K))
        {
            light.enabled = !light.enabled;
        }
    }
}