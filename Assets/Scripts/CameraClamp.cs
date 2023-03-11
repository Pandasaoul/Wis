using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraClamp : MonoBehaviour 
{
    [SerializeField]
    private Transform targetToFollow;


    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(
            Mathf.Clamp(targetToFollow.transform.position.x, -407.3f, 253.51f),
            targetToFollow.transform.position.y + 33f, -10);
    }
}
