using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioPanaderias : MonoBehaviour
{
    [SerializeField] GameObject panaderiaInterior;
    [SerializeField] GameObject panaderiaExterior;

    public int cambioZoom;

    public GameObject misionFlores;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            panaderiaInterior.SetActive(true);
            panaderiaExterior.SetActive(false);

            cambioZoom = 2;

            misionFlores.SetActive(true);
        }
    }

    public void OnTriggerExit (Collider other)
    {
        panaderiaInterior.SetActive(false);
        panaderiaExterior.SetActive(true);

        cambioZoom = 3;
    }
}
