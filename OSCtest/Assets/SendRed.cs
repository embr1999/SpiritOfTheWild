using UnityEngine;
using System.Collections;
using System.Security.Policy;

public class SendRed : MonoBehaviour
{

    public OSC osc;

    // Use this for initialization
    void Start()
    {
    }

  
    void OnMouseOver()
        {
        if (Input.GetMouseButton(0))
        {

            OscMessage message = new OscMessage();

            message.address = "/SRed";
            message.values.Add(1);
            osc.Send(message);
        }
        else
        {
            OscMessage message = new OscMessage();

            message.address = "/SRed";
            message.values.Add(0);
            osc.Send(message);
        }
        }
    
}






