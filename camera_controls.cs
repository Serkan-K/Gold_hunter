using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cameracontrolkod : MonoBehaviour
{
    public oyuncontrol oyunK;

    float sens = 8f;
    float soft = 8f;

    Vector2 cameraSens;
    Vector2 cameraPos;

    GameObject player;


    void Start()
    {
        player = transform.parent.gameObject;
        cameraPos.x = 12f;
    }

    
    void Update()
    {
        if (oyunK.oyunAktif)
        {
            Vector2 mousePos = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
            cameraSens = Vector2.Scale(mousePos, new Vector2(sens * soft, sens * soft));

            cameraSens.x = Mathf.Lerp(cameraSens.x, mousePos.x, 1f / soft);
            cameraSens.y = Mathf.Lerp(cameraSens.y, mousePos.y, 1f / soft);
            cameraPos += mousePos;

            transform.localRotation = Quaternion.AngleAxis(-cameraPos.y, Vector3.right);
            player.transform.localRotation = Quaternion.AngleAxis(cameraPos.x, player.transform.up);
        }
    }
}
