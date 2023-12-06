using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Video;

public class FloodLightManager : MonoBehaviour
{

    [SerializeField] private bool searchMode = false;
    [SerializeField] private GameObject light = null;

    [SerializeField] private float rotationSpeed = 0f;
    [SerializeField] private bool limitToOneEighty = false;
    [Range(0,360)] private float rotationState = 0f;

    // Start is called before the first frame update
    void Start()
    {
        if(light == null)
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
        light.transform.Rotate(0, rotationSpeed * Time.deltaTime, 0f);
    }
}
