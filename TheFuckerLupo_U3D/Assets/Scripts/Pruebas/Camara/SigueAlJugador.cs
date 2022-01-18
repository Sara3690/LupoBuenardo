using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigueAlJugador : MonoBehaviour
{
    public GameObject jugador;

    [Header("PosicionCamara")]
    public float alturaX;
    public float alturaY;
    public float alturaZ;

    [Header("CambioZoom")]
    public CambioCasasLupo casaLupo;
    public CambioPanaderias panaderias;
    public CambioMolinos molinos;


    private void Start()
    {
        //jugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3( alturaX + jugador.transform.position.x, alturaY + jugador.transform.position.y, alturaZ + jugador.transform.position.z );

        if (casaLupo.cambioZoom == 0)
        {
            Camera.main.fieldOfView = 34f;

            alturaY = 10.47f;
            alturaZ = -14.9f;
            
        }

        if (casaLupo.cambioZoom == 1)
        {
            Camera.main.fieldOfView = 50f;

            alturaY = 12f;
            alturaZ = -12f;

        }

        if (panaderias.cambioZoom == 2)
        {
            Camera.main.fieldOfView = 34f;
            alturaY = 10.47f;
            alturaZ = -14.9f;
        }

        if (panaderias.cambioZoom == 3)
        {
            Camera.main.fieldOfView = 50f;
            alturaY = 12f;
            alturaZ = -12f;
        }

        if (molinos.cambioZoom == 4)
        {
            Camera.main.fieldOfView = 34f;
            alturaY = 10.47f;
            alturaZ = -14.9f;
        }

        if (molinos.cambioZoom == 5)
        {
            Camera.main.fieldOfView = 50f;
            alturaY = 12f;
            alturaZ = -12f;
        }

    }
}
