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

    public int zoom;

    private void Start()
    {
        //jugador = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3( alturaX + jugador.transform.position.x, alturaY + jugador.transform.position.y, alturaZ + jugador.transform.position.z );

        if (zoom == 0)
        {
            Camera.main.fieldOfView = 34f;

            alturaY = 10.47f;
            alturaZ = -14.9f;

            this.transform.rotation = Quaternion.Euler(30f, 0, 0);

        }

        if (zoom == 1)
        {
            Camera.main.fieldOfView = 42.2f;

            alturaY = 8f;
            alturaZ = -17f;

            this.transform.rotation = Quaternion.Euler(17.7f, 0, 0);

        }

        if (zoom == 2)
        {
            Camera.main.fieldOfView = 34f;
            alturaY = 10.47f;
            alturaZ = -14.9f;

            this.transform.rotation = Quaternion.Euler(30f, 0, 0);
        }

        if (zoom == 3)
        {
            Camera.main.fieldOfView = 42.2f;

            alturaY = 8f;
            alturaZ = -17f;

            this.transform.rotation = Quaternion.Euler(17.7f, 0, 0);
        }

        if (zoom == 4)
        {
            Camera.main.fieldOfView = 34f;
            alturaY = 10.47f;
            alturaZ = -14.9f;
            this.transform.rotation = Quaternion.Euler(30f, 0, 0);
        }

        if (zoom == 5)
        {
            Camera.main.fieldOfView = 42.2f;

            alturaY = 8f;
            alturaZ = -17f;

            this.transform.rotation = Quaternion.Euler(17.7f, 0, 0);
        }

    }
}
