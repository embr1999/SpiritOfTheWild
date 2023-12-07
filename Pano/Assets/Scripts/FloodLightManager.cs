using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Video;

public class FloodLightManager : MonoBehaviour
{

    [SerializeField] [Range(0.01f, 1f)] private float searchSpeed = 1f;
    [SerializeField] private bool searchMode = false;
    [SerializeField] private GameObject lightObject = null;
    [SerializeField] private Transform lookAtTarget = null;

    private Vector3 moveVector = new Vector3(1f, 0f, 0f);
    private bool invertMovement = false;
    // Start is called before the first frame update
    void Start()
    {
        if(lightObject == null)
        {
            return;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(searchMode)
        {
            SearchModeLights();
        }
    }

    private void SearchModeLights()
    {
        if(invertMovement)
        {
           //var searchSpeedMod = -searchSpeed;
            moveVector = new Vector3(-searchSpeed, 0f, 0f);
        }
        else
        {
            moveVector = new Vector3(searchSpeed, 0f, 0f);
        }

        lightObject.transform.LookAt(lookAtTarget);
        lookAtTarget.transform.position += moveVector;

        if(lookAtTarget.transform.position.x >= 180f)
        {
            invertMovement = true;
            lookAtTarget.transform.position = new Vector3(180f, 0f, 0f);
        }
        else if(lookAtTarget.transform.position.x <= -180f)
        {
            invertMovement = false;
            lookAtTarget.transform.position = new Vector3(-180f, 0f, 0f);
        }

    }
}
