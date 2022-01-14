using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HablarMolinero : MonoBehaviour
{
    [SerializeField] Button botonAccion;

    [SerializeField] Flowchart murmullosMolinero;

    public bool activarDialogo = false;

    public SaltoJugador bloqueoSalto;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activarDialogo = true;
            bloqueoSalto.isGrounded = false;

            if (activarDialogo == true)
            {
                botonAccion.image.sprite = Resources.Load<Sprite>("BotonHablar");


                murmullosMolinero.SetBooleanVariable("LupoEntra", true);
            }

        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activarDialogo = true;
            bloqueoSalto.isGrounded = false;

            if (activarDialogo == true)
            {
                botonAccion.image.sprite = Resources.Load<Sprite>("BotonHablar");


                murmullosMolinero.SetBooleanVariable("LupoEntra", true);
            }

        }
    }

    public void OnTriggerExit(Collider other)
    {
        activarDialogo = false;

        if (activarDialogo == false)
        {
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonOriginal");


            murmullosMolinero.SetBooleanVariable("LupoEntra", false);
        }

    }
}
