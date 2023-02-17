using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControlcodes : MonoBehaviour
{
    public oyuncontrol oyunC;
    public AudioClip altinn, dusmann;
    public UnityEngine.UI.Button btn;

    private float hiz=5;

    void Start()
    {
        
    }

   
    void Update()
    {
        if (oyunC.oyunAktif)
        {
            float x = Input.GetAxis("Horizontal");
            float y = Input.GetAxis("Vertical");

            x *= Time.deltaTime * hiz;
            y *= Time.deltaTime * hiz;


            transform.Translate(x, 0f, y);
        }
    }


    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.tag.Equals("altin"))
        {

            GetComponent<AudioSource>().PlayOneShot(altinn, 0.8f);
            oyunC.altinArti();
                Destroy(c.gameObject);
            
        }


        else if (c.gameObject.tag.Equals("dusman"))
        {

            GetComponent<AudioSource>().PlayOneShot(dusmann, 0.7f);
            oyunC.oyunAktif = false;
            btn.gameObject.SetActive(true);

            oyunC.altinYokEt();


        }
        
    }


}
