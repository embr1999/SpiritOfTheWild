using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float totalTime = 300f; // 5 minutes in seconds

    private float currentTime = 0f;

    void Update()
    {
        // Increment the timer
        currentTime += Time.deltaTime;

        // Ensure currentTime does not exceed totalTime
        currentTime = Mathf.Clamp(currentTime, 0f, totalTime);

        // Calculate the interpolation factor based on the current time
        float t = currentTime / totalTime;

        // Perform linear interpolation between pointA and pointB
        Vector3 newPosition = Vector3.Lerp(pointA.position, pointB.position, t);

        // Set the GameObject's position only on the X-axis
        transform.position = new Vector3(newPosition.x, transform.position.y, transform.position.z);

        // Check if the movement is complete
        if (currentTime >= totalTime)
        {
            // Movement is complete, you can perform additional actions here
            //Debug.Log("Movement complete!");

            // Optionally, you can reset the timer or stop the movement
            // currentTime = 0f; // Uncomment this line to reset the timer
            // enabled = false; // Uncomment this line to stop the movement
        }
    }
}

