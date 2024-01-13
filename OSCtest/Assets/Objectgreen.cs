using UnityEngine;
using System.Collections;

public class Objectgreen : MonoBehaviour {

	public OSC osc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	  OscMessage message = new OscMessage();

        message.address = "/ObjgreenXYZ";
        message.values.Add(transform.position.x);
        message.values.Add(transform.position.y);
        message.values.Add(transform.position.z);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjgreenX";
        message.values.Add(transform.position.x);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjgreenY";
        message.values.Add(transform.position.y);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjgreenZ";
        message.values.Add(transform.position.z);
        osc.Send(message);


    }


}
