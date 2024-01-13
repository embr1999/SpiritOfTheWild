using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEditor.VFX;
using UnityEditor.VFX.UI;

public class VFXStart : MonoBehaviour
{
    public bool IsPlaying = false;
    void OnMouseOver()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton1))
        {
            IsPlaying = !IsPlaying;
        }

        if (IsPlaying)
        {
            GetComponent<VisualEffect>().Play();
        }
        else
        {
            GetComponent<VisualEffect>().Stop();
        }
    }
 
}