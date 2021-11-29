using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransformPositionInputSmoothly : MonoBehaviour
{
    public float moveSpeed = 2f;
    public float turnSpeed = 30f;

    //GETKEY = EVERY FRAME MOVE 
    void Update()
    {
        //IF WE WANT TO SET SMOOTHLY

        //if (Input.GetKey(KeyCode.RightArrow))
        //    transform.position += Vector3.right * moveSpeed * Time.deltaTime;

        //if (Input.GetKey(KeyCode.LeftArrow))
        //    transform.position += Vector3.left * moveSpeed * Time.deltaTime;

        //if (Input.GetKey(KeyCode.UpArrow))
        //    transform.position += Vector3.up * moveSpeed * Time.deltaTime;

        //if (Input.GetKey(KeyCode.DownArrow))
        //    transform.position += Vector3.down * moveSpeed * Time.deltaTime;


        //IF WE WANT TO SET SMOOTHLY AND ROTATION 

        // 3D
            //if (Input.GetKey(KeyCode.Q))
            //    transform.Rotate(Vector3.down * turnSpeed * Time.deltaTime);

            //if (Input.GetKey(KeyCode.E))
            //    transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);

        // 2D
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(Vector3.forward * turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.E))
            transform.Rotate(Vector3.back * turnSpeed * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.position += transform.right * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.LeftArrow))
            transform.position += -transform.right * moveSpeed * Time.deltaTime; // negative right gives us left

        if (Input.GetKey(KeyCode.UpArrow))
            transform.position += transform.up * moveSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.DownArrow))
            transform.position += -transform.up * moveSpeed * Time.deltaTime; // negative up(forward) gives us backward
    }
}
