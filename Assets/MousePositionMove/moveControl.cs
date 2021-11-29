using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveControl : MonoBehaviour
{
    Vector3 oldPosition;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 10));
            oldPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            transform.localScale += (Input.mousePosition - oldPosition) / 100;
            oldPosition = Input.mousePosition;
        }
    }
}
