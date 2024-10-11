using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hareket_sc : MonoBehaviour
{
    // Start is called before the first frame update
    public int hiz = 5;
    [SerializeField] //Prive tanımları bu satır kod ile erişebilir hale getirebiliriz.
    private float hiz2 = 6.0f; 
    void Start()
    {
        //script ile nesnenin konumunu bir kez değiştirme.
        transform.position = new Vector3(5, 0,0); 
        //
    }

    // Update is called once per frame
    void Update()
    {
        //Konumunun sürekli değişmesi Her bir framede kod 1 kere çalışır.
        transform.Translate(Vector3.up);//Her bir framede yukarı gitmesine yarar

        transform.Translate(Vector3.up * Time.deltaTime * hiz2);//Vektörü Time.deltaTime Fonks ile çarptımız zaman saniyede 1 birim ilerler

        transform.Translate(Vector3.up * Time.deltaTime * hiz);//Hız ile çarpınca dışardan değişikliklede hızını kontrol edebiliriz.

        float horizontalInput = Input.GetAxis("Horizontal");// Yatay eksendeki algılama için
        float verticalInput = Input.GetAxis("Vertical");//Dikey eksen için
        transform.Translate(new Vector3(1,0,0) * Time.deltaTime * hiz * horizontalInput);
        transform.Translate(new Vector3(0,1,0)  * Time.deltaTime * hiz * verticalInput);
    }
}
