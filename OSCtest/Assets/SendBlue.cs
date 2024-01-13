using UnityEngine;
using System.Collections;
using System.Security.Policy;

public class SendBlue : MonoBehaviour
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

            message.address = "/SBlue";
            message.values.Add(1);
            osc.Send(message);
        }
        else
        {
            OscMessage message = new OscMessage();

            message.address = "/SBlue";
            message.values.Add(0);
            osc.Send(message);
        }
        }
    
}






