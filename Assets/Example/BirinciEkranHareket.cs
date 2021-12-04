using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirinciEkranHareket : MonoBehaviour
{
    //Unity içinden hiz almak için bu girdiði oluþturudm.
    public float hiz;
    public float donmeHiz;
         
    void Update()
    {
        HareketKontrol();
    }


    void HareketKontrol()
    {
        //Input.anyKey ekranda herhangi bir yere týkladýnðýnda bunu týklama olarak varsayýp herhangi týklanan  neyse onu tuþ kabul etmesi için yazýlýr.
        // burada mouse pozisyonuna göre ekraný ikiye bölerek sol taraf için ilk if bloðu // yani Eðer mouse sola týklarsa ekrandaki obje sola doðru gidecek.
        if (Input.anyKey)
        {
            if (Input.mousePosition.x < Screen.width / 2 && transform.position.x > -8f)
            {
                transform.position = new Vector3(transform.position.x - hiz * Time.deltaTime, transform.position.y, transform.position.z);
                transform.Rotate(0, 0, -donmeHiz * Time.deltaTime);//Döndürmek 
            }
            //Ekranýn yarýsýnýn sað tarafýna týklandýðýnda obje sað doðru gidecek. gitme hizini yukarýda belirlediðimiz float deðere göre yapýyo.
            if (Input.mousePosition.x > Screen.width / 2 && transform.position.x < 8f)
            {
                //burada Time.deltaTime yaptýðýmýzda her (frame)saniye için 0.025 yparak görüntünün daha akýcý akmasýný saðlýyor.
                transform.position = new Vector3(transform.position.x + hiz * Time.deltaTime, transform.position.y, transform.position.z);
                transform.Rotate(0, 0, donmeHiz * Time.deltaTime);//Döndürmek için


            }
        }
    }
}
