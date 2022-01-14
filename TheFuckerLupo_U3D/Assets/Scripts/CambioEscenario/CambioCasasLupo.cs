using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioCasasLupo : MonoBehaviour
{
    [SerializeField] GameObject casaInterior;
    [SerializeField] GameObject casaExterior;

    public int cambioZoom;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            casaInterior.SetActive(true);
            casaExterior.SetActive(false);
            cambioZoom = 0;
           
        }
    }

    public void OnTriggerExit (Collider other)
    {
        casaInterior.SetActive(false);
        casaExterior.SetActive(true);
        cambioZoom = 1;
    }
}
