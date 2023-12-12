using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Demo_MoveDoe : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.transform.position + new Vector3(movementSpeed*Time.deltaTime, 0f, 0f);
    }
}
