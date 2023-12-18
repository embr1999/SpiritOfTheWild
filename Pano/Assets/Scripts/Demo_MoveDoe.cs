using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo_MoveDoe : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0f;
    [SerializeField] private bool invertDirection = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var m = movementSpeed*Time.deltaTime;

        if(invertDirection)
        {
            m*=-1;
        }

        this.transform.position = this.transform.position + new Vector3(m, 0f, 0f);
    }
}
