using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class SunMoonCycler : MonoBehaviour
{

[SerializeField] private bool dayNightCycle = false;
[SerializeField] [Range(0, 360)] private float cycleState = 0f;
[SerializeField] [Range(0, 1)] private float lightIntensity = 0.1f;

[Space(10)]

[SerializeField] private bool enablePresets = false;

[SerializeField] private GameObject directionalLight =  null;

#region Hidden / Private variables

#endregion

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        OverrideLightSettings();
    }

    private void OverrideLightSettings()
    {
        //Grab the light component of the Directional Light
        var lightComponent = directionalLight.GetComponent<Light>();

        //Grab the light intensity and override it with the lightIntensity
        lightComponent.intensity = lightIntensity;


        //Gab the X transform rotation of the Directional Light and override it with the CycleState
        directionalLight.transform.rotation = Quaternion.Euler(cycleState, 0f, 0f);
    }
}
