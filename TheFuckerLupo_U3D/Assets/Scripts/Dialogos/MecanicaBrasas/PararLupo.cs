using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PararLupo : MonoBehaviour
{
    public MovimientoJugador movimientoLupo;
   
    public Button botonAccion;

    public Animator desplazarLupo;

    public GameObject botonAccionador;

    private void Start()
    {
        movimientoLupo.GetComponent<MovimientoJugador>();
      
       
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonHablar");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        movimientoLupo.enabled = true;
        if (other.gameObject.CompareTag("Player"))
        {
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonSaltar");
        }
    }

    public void ParacionLupo()
    {
        movimientoLupo.pausarMovimientoLupo = true;
        desplazarLupo.SetFloat("esCaminar", 0);
        botonAccionador.SetActive(false);

    }

    public void MoverLupo()
    {
       
        movimientoLupo.pausarMovimientoLupo = false;
        botonAccionador.SetActive(true);
    }
}
