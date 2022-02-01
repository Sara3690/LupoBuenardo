using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioCasasLupo : MonoBehaviour
{
    [SerializeField] GameObject casaInterior;
    [SerializeField] GameObject casaExterior;

    public SigueAlJugador zum;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            casaInterior.SetActive(true);
            casaExterior.SetActive(false);
            zum.zoom = 0;
           
        }
    }

    public void OnTriggerExit (Collider other)
    {
        casaInterior.SetActive(false);
        casaExterior.SetActive(true);
        zum.zoom = 1;
    }
}
