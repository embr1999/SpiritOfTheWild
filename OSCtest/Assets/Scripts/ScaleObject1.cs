using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleObject1 : MonoBehaviour
{

    // Start is called before the first frame update
   
    void OnMouseOver()
    {


        if (Input.GetKeyDown(KeyCode.JoystickButton3))
        {
            transform.localScale = new Vector3(0.13f, 0.13f, 0.13f);
            
        }
       
        if (Input.GetKeyDown(KeyCode.JoystickButton0))
        {
            transform.localScale = new Vector3(0.18f, 0.18f, 0.18f);
            
        }

      

    }

}


