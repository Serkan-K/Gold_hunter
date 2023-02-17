using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class oyuncontrol : MonoBehaviour
{
    public bool oyunAktif = true;
    public UnityEngine.UI.Button startbutton;
    public int altinSayisi = 0;
    public UnityEngine.UI.Text altinSayac;
    public UnityEngine.UI.Button btn;



    // Start is called before the first frame update
    void Start()
    {
        
        GetComponent<AudioSource>().Play();

    }

    // Update is called once per frame
    void Update()
    {
       
    }


    public void altinArti()
    {
        altinSayisi += 100;
        altinSayac.text = "" + altinSayisi;

    }

    public void Startbuttonu()
    {
        oyunAktif = true;
        startbutton.gameObject.SetActive(false);

    }


    public void Restart()
    {
        SceneManager.LoadScene("GoldHunter");

    }

    public void altinYokEt()
    {
        altinSayisi -= 100000;
        altinSayac.text = "" + altinSayisi;

    }


}
