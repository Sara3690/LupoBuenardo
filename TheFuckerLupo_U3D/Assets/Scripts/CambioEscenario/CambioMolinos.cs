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

    public SigueAlJugador zum;

    public AtaqueJugador contadorRatas;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && puedeEntrar)
        {
            molinoInterior.SetActive(true);
            molinoExterior.SetActive(false);
            zum.zoom = 4;

            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        molinoInterior.SetActive(false);
        molinoExterior.SetActive(true);

        zum.zoom = 5;
    }

    private void Update()
    {
        if (misionRatas.GetBooleanVariable("YaHablaron"))
        {
            
            puedeEntrar = true;
        }
    }
}
