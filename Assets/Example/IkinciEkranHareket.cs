using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IkinciEkranHareket : MonoBehaviour
{
    //Parmagimiz ilk tikladigimiz yerden ikinci tikladignan yere dogru belirlenin hiz miktarin gore hareket eder.
    private Vector2 baslangicPozisyonu, bitisPozisyon;
     
        
    void Update()
    {
        //Tiklanan yer baþlangici 
        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            baslangicPozisyonu = Input.GetTouch(0).position;
        }
        //Tiklanan yerin bitis noktasi
        if(Input.touchCount>0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            //Ekran icin gerekli kisitlamlar Tamamen kameradan cikmasin diye.
            bitisPozisyon = Input.GetTouch(0).position;
            if ((bitisPozisyon.x < baslangicPozisyonu.x) && transform.position.x>-6.5f)
            {
                transform.position = new Vector3(transform.position.x - 0.5f, transform.position.y, transform.position.z);

            }
            if ((bitisPozisyon.x > baslangicPozisyonu.x) && transform.position.x < +6.5f)
            {
                transform.position = new Vector3(transform.position.x + 0.5f, transform.position.y, transform.position.z);

            }
        }
    }

}
