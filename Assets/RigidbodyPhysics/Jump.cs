using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    private Rigidbody2D myRigidbody;

    public float jumpForce = 50f;
    private bool _shouldJump;

    private void Awake() => myRigidbody = GetComponent<Rigidbody2D>();

    void Update()
    {
        if (_shouldJump == false)
            _shouldJump = Input.GetKeyDown(KeyCode.Space);
    }

    void FixedUpdate()
    {
        if (_shouldJump)
        {
            myRigidbody.AddForce(jumpForce * Vector3.up);
            _shouldJump = false;
        }
    }
}
