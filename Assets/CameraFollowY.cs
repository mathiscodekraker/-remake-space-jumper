using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowY : MonoBehaviour
{
    public Transform target;         // The object to follow
    public float smoothSpeed = 0.125f; // Smooth movement

    private Vector3 offset;
    private float startY;            // Starting Y position of the camera

    void Start()
    {
        if (target != null)
        {
            offset = transform.position - target.position;
        }

        startY = transform.position.y; // Save the starting Y position
    }

    void LateUpdate()
    {
        if (target != null)
        {
            // Desired Y position, clamped to not go below startY
            float desiredY = Mathf.Max(target.position.y + offset.y, startY);

            // Keep X and Z the same
            Vector3 desiredPosition = new Vector3(transform.position.x, desiredY, transform.position.z);

            // Smoothly move the camera
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        }
    }
}
