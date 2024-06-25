using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Target;
    public Vector3 offset;
    public Vector3 rotationOffset;
    public float damper = 1.0f;

    void Start()
    {
        transform.eulerAngles = rotationOffset;
    }

    void LateUpdate()
    {
        if (Target == null)
            return;

        transform.position = Target.position + offset;

        Quaternion targetRotation = Target.rotation * Quaternion.Euler(rotationOffset);

        transform.rotation = targetRotation;
    }
}
