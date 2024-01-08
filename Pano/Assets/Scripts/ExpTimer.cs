using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class ExpTimer : MonoBehaviour
{

[Tooltip("metrics in secons")]    
public float totalTime = 300f; // 5 minutes in seconds
private float currentTime;

#region Hidden / Private variables

#endregion

    // Start is called before the first frame update
    void Start()
    {
        currentTime = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        DayLightCycle();
    }


    private void DayLightCycle()
    {
        // Update the timer
        currentTime -= Time.deltaTime;

        // Check if the timer has reached zero
        if (currentTime <= 0f)
        {
            // Timer has reached zero, you can perform actions here
            Debug.Log("Timer reached zero!");
        }

        // Display the timer value if needed
        Debug.Log("Time remaining: " + Mathf.CeilToInt(currentTime));
    }
}
