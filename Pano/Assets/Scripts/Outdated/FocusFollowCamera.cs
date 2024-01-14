using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class FocusFollowCamera : MonoBehaviour
{
    [SerializeField] [Range(-10f, 10)] float verticalOffset = 0;
    [SerializeField] [Range(-10f, 10)] float horizontalOffsetX = 0;
    [SerializeField] [Range(-10f, 10)] float horizontalOffsetZ = 0;
    [SerializeField] private bool trackTarget = false;
    [SerializeField] [Range(0.1f, 100f)] private float trackFollowSpeed = 1f;
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
        if(trackTarget)
        {
            TrackTarget();
        }

        FollowTarget();
    }

    private void TrackTarget()
    {
        this.transform.LookAt(targetTransform);
    }

    private void FollowTarget()
    {
        this.transform.position = targetTransform.position - new Vector3(horizontalOffsetX, verticalOffset*-1, horizontalOffsetZ);
    }
}
