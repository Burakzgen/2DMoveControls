using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithForceUseTransformRotationClampVelocity : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    public float movementForce = 10f;
    public double maxVelocity = 10f;

    private void Awake() => myRigidbody = GetComponent<Rigidbody2D>();

    private void FixedUpdate() // Rigidbody is more useful to use this
    {
        if (myRigidbody.velocity.magnitude >= maxVelocity)
            return;

        if (Input.GetKey(KeyCode.RightArrow))
            myRigidbody.AddForce(Vector3.right * movementForce);

        if (Input.GetKey(KeyCode.LeftArrow))
            myRigidbody.AddForce(Vector3.left * movementForce);

        if (Input.GetKey(KeyCode.UpArrow))
            myRigidbody.AddForce(Vector3.up * movementForce);

        if (Input.GetKey(KeyCode.DownArrow))
            myRigidbody.AddForce(Vector3.down * movementForce);
    }
}
