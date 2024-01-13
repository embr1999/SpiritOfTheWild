using UnityEngine;
using System.Collections;

public class Objectblue : MonoBehaviour {

	public OSC osc;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	  OscMessage message = new OscMessage();

        message.address = "/ObjblueXYZ";
        message.values.Add(transform.position.x);
        message.values.Add(transform.position.y);
        message.values.Add(transform.position.z);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjblueX";
        message.values.Add(transform.position.x);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjblueY";
        message.values.Add(transform.position.y);
        osc.Send(message);

        message = new OscMessage();
        message.address = "/ObjblueZ";
        message.values.Add(transform.position.z);
        osc.Send(message);


    }


}
