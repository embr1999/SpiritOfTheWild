using UnityEngine;
using System.Collections;

public class Rotation : MonoBehaviour {

	public OSC osc;

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update()
	{

		var x = UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).x;
		var y = UnityEditor.TransformUtils.GetInspectorRotation(gameObject.transform).y;

		OscMessage message = new OscMessage();

		message.address = "/RotXYZ";
		message.values.Add(x);
		message.values.Add(y);
		osc.Send(message);
	}
}
