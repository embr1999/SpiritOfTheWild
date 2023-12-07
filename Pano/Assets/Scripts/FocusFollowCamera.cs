using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FocusFollowCamera : MonoBehaviour
{
    [SerializeField] private Transform targetTransform = null;
    private Transform rootTransform = null;

    // Start is called before the first frame update
    void Start()
    {
        if(targetTransform == null)
        {
            return;
        }

        rootTransform = this.transform;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void TrackTarget()
    {

    }

    private void FollowTarget()
    {
        
    }
}
