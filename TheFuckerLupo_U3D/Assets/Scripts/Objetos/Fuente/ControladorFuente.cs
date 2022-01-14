using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorFuente : MonoBehaviour
{
    [SerializeField] Button botonAccion;
    [SerializeField] Flowchart misionAgua;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag ("Player"))
        {
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonFuente");
            misionAgua.SetBooleanVariable("PreCogerAgua", true);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonFuente");
            

        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            misionAgua.SetBooleanVariable("PreCogerAgua", false);

        }
    }
}
