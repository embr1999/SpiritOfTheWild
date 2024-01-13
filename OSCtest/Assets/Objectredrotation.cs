using UnityEngine;
using System.Collections;

public class Objectredrotation : MonoBehaviour {

	public OSC osc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	  OscMessage message = new OscMessage();

        message.address = "/ObjredrotXYZ";
        message.values.Add(transform.rotation.x);
        message.values.Add(transform.rotation.y);
        message.values.Add(transform.rotation.z);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjredrotX";
        message.values.Add(transform.rotation.x);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjredrotY";
        message.values.Add(transform.rotation.y);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjredrotZ";
        message.values.Add(transform.rotation.z);
        osc.Send(message);


    }


}
