using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchControl : MonoBehaviour
{
    void Update()
    {
        int parmakSayisi = Input.touchCount;
        for (int i = 0; i < parmakSayisi; i++)
        {
            Touch parmak = Input.GetTouch(i);
            if (parmak.phase == TouchPhase.Stationary)
            {
                transform.position = Camera.main.ScreenToWorldPoint(new Vector3(parmak.position.x, parmak.position.y, 10));
            }
        }

    }

    //void Update()
    //{
    //    int parmakSayisi = Input.touchCount;
    //    for (int i = 0; i < parmakSayisi; i++)
    //    {
    //        Touch parmak = Input.GetTouch(i);
    //        if (parmak.phase == TouchPhase.Began)
    //        {
    //            transform.position = Camera.main.ScreenToWorldPoint(new Vector3(parmak.position.x, parmak.position.y, 10));
    //        }
    //        else if (parmak.phase == TouchPhase.Moved)
    //        {
    //            transform.localScale += (Vector3)parmak.deltaPosition / 100;
    //        }
    //    }

    //}
}
