using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEditor.VFX;
using UnityEditor.VFX.UI;

public class OnPlayOff : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<VisualEffect>().Stop();
    }
   
    
  
}
