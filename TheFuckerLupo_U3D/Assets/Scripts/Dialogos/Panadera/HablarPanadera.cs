using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HablarPanadera : MonoBehaviour
{
    [SerializeField] Button botonAccion;

    [SerializeField] Flowchart murmullosPanadera;
    public Flowchart misionFlores;

    public bool activarDialogo = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activarDialogo = true; 

            if (activarDialogo == true)
            {
                botonAccion.image.sprite = Resources.Load<Sprite>("BotonHablar");


                murmullosPanadera.SetBooleanVariable("LupoEntracion", true);
            }

        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            activarDialogo = true;

            if (activarDialogo == true)
            {
                botonAccion.image.sprite = Resources.Load<Sprite>("BotonHablar");


                murmullosPanadera.SetBooleanVariable("LupoEntracion", true);
            }

        }
    }



    public void OnTriggerExit(Collider other)
    {
        //if (other.gameObject.CompareTag("Player"))
        //{
            activarDialogo = false;

            if (activarDialogo == false)
            {
                botonAccion.image.sprite = Resources.Load<Sprite>("BotonOriginal");


                murmullosPanadera.SetBooleanVariable("LupoEntracion", false);
                misionFlores.SetBooleanVariable("CargarDialogacion", false);
            }
        //}
        
     
    }

}

