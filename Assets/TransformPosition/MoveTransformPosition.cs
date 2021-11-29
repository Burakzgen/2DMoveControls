using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTransformPosition : MonoBehaviour
{
    void Update()
    {
        // Unity 2D MOVE CHARACTER

        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //    transform.position += Vector3.right;

        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //    transform.position += Vector3.left;

        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //    transform.position += Vector3.up;

        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //    transform.position += Vector3.down;


        // Unity 3D UP & DOWN

        //if (Input.GetKeyDown(KeyCode.UpArrow))
        //    transform.position += Vector3.forward;

        //if (Input.GetKeyDown(KeyCode.DownArrow))
        //    transform.position += Vector3.back;

        //if (Input.GetKeyDown(KeyCode.Space))
        //    transform.position = new Vector3(0, 0.5f, 0);


        //If WE WANT TO SET LIMITS

        if (Input.GetKeyDown(KeyCode.RightArrow) && transform.position.x < 3f)
            transform.position += Vector3.right;

        if (Input.GetKeyDown(KeyCode.LeftArrow) && transform.position.x > -3f)
            transform.position += Vector3.left;

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < 3)
            transform.position += Vector3.up;

        if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > -3)
            transform.position += Vector3.down;

    }
}
