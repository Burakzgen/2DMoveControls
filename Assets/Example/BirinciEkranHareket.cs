using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirinciEkranHareket : MonoBehaviour
{
    //Unity i�inden hiz almak i�in bu girdi�i olu�turudm.
    public float hiz;
    public float donmeHiz;
         
    void Update()
    {
        HareketKontrol();
    }


    void HareketKontrol()
    {
        //Input.anyKey ekranda herhangi bir yere t�klad�n��nda bunu t�klama olarak varsay�p herhangi t�klanan  neyse onu tu� kabul etmesi i�in yaz�l�r.
        // burada mouse pozisyonuna g�re ekran� ikiye b�lerek sol taraf i�in ilk if blo�u // yani E�er mouse sola t�klarsa ekrandaki obje sola do�ru gidecek.
        if (Input.anyKey)
        {
            if (Input.mousePosition.x < Screen.width / 2 && transform.position.x > -8f)
            {
                transform.position = new Vector3(transform.position.x - hiz * Time.deltaTime, transform.position.y, transform.position.z);
                transform.Rotate(0, 0, -donmeHiz * Time.deltaTime);//D�nd�rmek 
            }
            //Ekran�n yar�s�n�n sa� taraf�na t�kland���nda obje sa� do�ru gidecek. gitme hizini yukar�da belirledi�imiz float de�ere g�re yap�yo.
            if (Input.mousePosition.x > Screen.width / 2 && transform.position.x < 8f)
            {
                //burada Time.deltaTime yapt���m�zda her (frame)saniye i�in 0.025 yparak g�r�nt�n�n daha ak�c� akmas�n� sa�l�yor.
                transform.position = new Vector3(transform.position.x + hiz * Time.deltaTime, transform.position.y, transform.position.z);
                transform.Rotate(0, 0, donmeHiz * Time.deltaTime);//D�nd�rmek i�in


            }
        }
    }
}
