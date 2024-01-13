using UnityEngine;
using System.Collections;
using System.Security.Policy;

public class Sendonoffgreen : MonoBehaviour
{

    public OSC osc;

    // Use this for initialization
    void Start()
    {

    }
    public bool On = true;

    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            On = !On;
        }
        if (On)
        { 
            OscMessage message;

            message = new OscMessage();
            message.address = "/Songreen";
            message.values.Add(1);
            osc.Send(message);
        }
        else 
        {
            OscMessage message;

            message = new OscMessage();
            message.address = "/Songreen";
            message.values.Add(0);
            osc.Send(message);
        }
    }

}


