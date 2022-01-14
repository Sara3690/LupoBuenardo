using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntrarCasaLupoGuay : MonoBehaviour
{
    public GameObject casaFuera;
    public GameObject casaDentro;

    public bool activarCasa;

    private void Start()
    {
        activarCasa = false;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activarCasa = true;
            casaDentro.SetActive(true);
            casaFuera.SetActive(false);

        }
       
    }
    private void OnTriggerExit(Collider other)
    {
        activarCasa = false;
        casaDentro.SetActive(false);
        casaFuera.SetActive(true);
    }

    
}
