using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Fungus;

public class HablarMamaLupo : MonoBehaviour
{
    [SerializeField] Button botonAccion;

    [SerializeField] Flowchart murmullos;

    [SerializeField] Flowchart misionPan;

    public bool activarDialogo;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            botonAccion.image.sprite = Resources.Load<Sprite>("BotonHablar");
            

            murmullos.SetBooleanVariable("LupoEntra", true);

        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            botonAccion.image.sprite = Resources.Load<Sprite>("BotonHablar");


            murmullos.SetBooleanVariable("LupoEntra", true);

        }
    }



    public void OnTriggerExit(Collider other)
    {

        botonAccion.image.sprite = Resources.Load<Sprite>("BotonOriginal");
        

        murmullos.SetBooleanVariable("LupoEntra", false);

        misionPan.SetBooleanVariable("CargarDialogo", false);
    }

}
