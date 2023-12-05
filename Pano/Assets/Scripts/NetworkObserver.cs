using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkObserver : MonoBehaviour
{
    [SerializeField] private int[] NetworkPorts = new int[0];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        try{
            if(NetworkPorts[1] == 100){
                print("Cat");
            }else{
                print("Owl");
            }

        }catch{
        }
    }
}
