using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class character1 : MonoBehaviour
{
    [SerializeField]
    private Transform ch1Place;

    private Vector2 initialPosition;

    private Vector2 mousePosition;

    private float deltaX, deltaY;

    public static bool locked;
    void Start()
    {
        initialPosition = transform.position;
    }

    void Update()
    {
        if (!locked)
        {
            deltaX = Camera.main.ScreenToWorldPoint(Input.mousePosition).x - transform.position.x;
            deltaY = Camera.main.ScreenToWorldPoint(Input.mousePosition).y - transform.position.y;
        }
    }

    private void OnMouseDrag()
    {
        if (!locked)
        {
            mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = new Vector2(mousePosition.x, mousePosition.y - deltaY);
        }
    }

    private void OnMouseUp()
    {
        if (!locked)
        {
            if (Mathf.Abs(transform.position.x - ch1Place.position.x) <= 0.5f &&
                Mathf.Abs(transform.position.y - ch1Place.position.y) <= 0.5f)
            {
                transform.position = new Vector2(ch1Place.position.x, ch1Place.position.y);
                locked = true;
            }
            else
            {
                transform.position = new Vector2(initialPosition.x, initialPosition.y);
            }
        }
    }
}
