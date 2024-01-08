using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightCycle : MonoBehaviour
{
    public GameObject lightObject = null;

    public float startValue = 0f;
    public float targetValue = 20f;
    public float totalTime = 300f; // 5 minutes in seconds

    private float currentTime;

    void Start()
    {

        if(lightObject == null)
        {
            return;
        }

        currentTime = 0f; // Start time from 0
    }

    void Update()
    {
        // Update the timer
        currentTime += Time.deltaTime;

        // Ensure currentTime does not exceed totalTime
        currentTime = Mathf.Clamp(currentTime, 0f, totalTime);

        // Interpolate the value from startValue to targetValue over time
        float interpolatedValue = Mathf.Lerp(startValue, targetValue, currentTime / totalTime);

        // Do something with the interpolated value (e.g., assign it to a variable or update a property)
        Debug.Log("Interpolated Value: " + interpolatedValue);

        var rotationAxis = lightObject.transform.rotation;
        lightObject.transform.rotation = Quaternion.Euler(interpolatedValue,0f,0f);


        // Check if the interpolation is complete
        if (currentTime >= totalTime)
        {
            // Interpolation is complete, you can perform additional actions here
            Debug.Log("Interpolation complete!");
        }
    }
}
