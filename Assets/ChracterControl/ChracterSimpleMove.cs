using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChracterSimpleMove : MonoBehaviour
{
    // UNITY 3D PLATFORM

    public float moveSpeed = 10f;
    public float jumpSpeed = 0.5f;
    public float gravity = 2f;
    public bool isGrounded;

    CharacterController characterController;
    private Vector3 _moveDirection;
    private void Awake() => characterController = GetComponent<CharacterController>();
    public void FixedUpdate()
    {
        //float horizontal = Input.GetAxis("Horizontal");
        //float vertical = Input.GetAxis("Vertical");

        //Vector3 direction = new Vector3(horizontal, 0, vertical);
        //Vector3 movement = transform.TransformDirection(direction) * moveSpeed;
        //isGrounded = characterController.SimpleMove(movement);


        //IF WE WANT JUMP & CHARACTER MOVE

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical);
        Vector3 movement = transform.TransformDirection(direction) * moveSpeed;

        Vector3 flatMovement = moveSpeed * Time.deltaTime * movement;

        _moveDirection = new Vector3(flatMovement.x, _moveDirection.y, flatMovement.z);

        if (PlayerJumped)
            _moveDirection.y = jumpSpeed;
        else if (characterController.isGrounded)
            _moveDirection.y = 0f;
        else
            _moveDirection.y -= gravity * Time.deltaTime;

    }

    private bool PlayerJumped => characterController.isGrounded && Input.GetKey(KeyCode.Space);
}
