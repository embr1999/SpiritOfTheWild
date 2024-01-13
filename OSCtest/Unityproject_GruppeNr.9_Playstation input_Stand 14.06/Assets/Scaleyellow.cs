using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaleyellow : MonoBehaviour
{
    public OSC osc;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            OscMessage message;

            message = new OscMessage();
            message.address = "/Scaleyellow";
            message.values.Add(0);
            osc.Send(message);

        }
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            OscMessage message;

            message = new OscMessage();
            message.address = "/Scaleyellow";
            message.values.Add(1);
            osc.Send(message);

        }
    }
}
