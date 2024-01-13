using UnityEngine;
using System.Collections;

public class Objectred : MonoBehaviour {

	public OSC osc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	  OscMessage message = new OscMessage();

        message.address = "/ObjredXYZ";
        message.values.Add(transform.position.x);
        message.values.Add(transform.position.y);
        message.values.Add(transform.position.z);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjredX";
        message.values.Add(transform.position.x);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjredY";
        message.values.Add(transform.position.y);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjredZ";
        message.values.Add(transform.position.z);
        osc.Send(message);


    }


}
