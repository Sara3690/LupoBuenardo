using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioMolinos : MonoBehaviour
{
    [SerializeField] GameObject molinoInterior;
    [SerializeField] GameObject molinoExterior;

    [SerializeField ] Flowchart misionRatas;
    public bool puedeEntrar = false;

    public int cambioZoom;

    public AtaqueJugador contadorRatas;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && puedeEntrar)
        {
            molinoInterior.SetActive(true);
            molinoExterior.SetActive(false);
            cambioZoom = 4;

            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        molinoInterior.SetActive(false);
        molinoExterior.SetActive(true);

        cambioZoom = 5;
    }

    private void Update()
    {
        if (misionRatas.GetBooleanVariable("YaHablaron"))
        {
            
            puedeEntrar = true;
        }
    }
}
