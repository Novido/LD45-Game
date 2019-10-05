using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Object we are following
    public Transform target;

    // Zeroes out the velocity
    Vector3 velocity = Vector3.zero;

    // Time to follow target
    public float smoothTime = 0.15f;


    // Update is called once per frame
    void Update()
    {
        // Target position
        Vector3 targetPos = target.position;

        // Align the camera and the targets position
        targetPos.z = transform.position.z;

        // Using smooth damp we will gradually change the camera transform position to the target position based on the transform velocity and our smooth timer.
        transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
    }
}
