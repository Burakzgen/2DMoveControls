using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    public float turnSpeed = 3f;

    void Update()
    {
        float horizontal = Input.GetAxis("Mouse X");
        transform.Rotate(horizontal * turnSpeed * Vector3.forward, Space.World); //z axis =forward y axis=up
    }
}
